using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MQ2
{
    public partial class Form1 : Form
    {
        string SerialDataIn;
        sbyte indexOfA, indexOfB, indexOfC;
        string dataSensor1, dataSensor2, dataSensor3;

        public Form1()
        {
            InitializeComponent();
            displayChart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            load_data.Visible = false;
            comboBox_baudrate.Text = "115200";
            progressBar1.Value = 0;
        }

        private void comboBox_comport_DropDown(object sender, EventArgs e)
        {
            String[] portLists = SerialPort.GetPortNames();
            comboBox_comport.Items.Clear();
            comboBox_comport.Items.AddRange(portLists);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_comport.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudrate.Text);
                progressBar1.Value = 1;
                serialPort1.Open();
                displayChart();
                load_data.Visible = true;
                timer1.Start();

                button_open.Enabled = false;
                button_close.Enabled = true;

                // Start listening for incoming data
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                timer1.Stop();
                progressBar1.Value = 0;

                button_open.Enabled = true;
                button_close.Enabled = false;
                load_data.Visible = false;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();
                timer1.Stop();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void load_data_Click(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            displayChart();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialDataIn = serialPort1.ReadLine();
                this.BeginInvoke(new EventHandler(ProcessData));

                //chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                //chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

                //chart1.Invoke((MethodInvoker)(() => chart1.Series["LPG ppm"].Points.AddXY(DateTime.Now.ToShortTimeString(), Convert.ToInt32(dataSensor1))));
                //chart1.Invoke((MethodInvoker)(() => chart1.Series["CO ppm"].Points.AddXY(DateTime.Now.ToShortTimeString(), Convert.ToInt32(dataSensor2))));
                //chart1.Invoke((MethodInvoker)(() => chart1.Series["SMOKE ppm"].Points.AddXY(DateTime.Now.ToShortTimeString(), Convert.ToInt32(dataSensor3))));
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfA = Convert.ToSByte(SerialDataIn.IndexOf("A"));
                indexOfB = Convert.ToSByte(SerialDataIn.IndexOf("B"));
                indexOfC = Convert.ToSByte(SerialDataIn.IndexOf("C"));

                dataSensor1 = SerialDataIn.Substring(0, indexOfA);
                dataSensor2 = SerialDataIn.Substring(indexOfA + 1, (indexOfB - indexOfA) - 1);
                dataSensor3 = SerialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);

                circularProgressBar1.Value = Convert.ToInt32(dataSensor1);
                circularProgressBar2.Value = Convert.ToInt32(dataSensor2);
                circularProgressBar3.Value = Convert.ToInt32(dataSensor3);

                label7.Text = dataSensor1;
                label1.Text = dataSensor2;
                label10.Text = dataSensor3;

                if (Convert.ToInt16(dataSensor1) >= 2000)
                {
                    MessageBox.Show("High amount of LPG is detected!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Convert.ToInt16(dataSensor2) >= 150)
                {
                    MessageBox.Show("High amount of Carbon Monocide is detected!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Convert.ToInt16(dataSensor3) >= 80)
                {
                    MessageBox.Show("High amount of Smoke is detected!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                double lpg_ppm = Convert.ToInt32(dataSensor1); // Assign a valid value to lpg_ppm
                double co_ppm = Convert.ToInt32(dataSensor2); // Assign a valid value to co_ppm
                double smoke_ppm = Convert.ToInt32(dataSensor3); // Assign a valid value to smoke_ppm

                savedData(lpg_ppm, co_ppm, smoke_ppm); // Call the savedData() method with the assigned values
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void savedData(double lpg_ppm, double co_ppm, double smoke_ppm)
        {
            string connStr = "server=localhost;user=root;database=mq2_db;password=;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                timer1.Start();
                conn.Open();

                string sql = "INSERT INTO sensor_reading (lpg_ppm, co_ppm, smoke_ppm) VALUES (@data1, @data2, @data3)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@data1", lpg_ppm);
                cmd.Parameters.AddWithValue("@data2", co_ppm);
                cmd.Parameters.AddWithValue("@data3", smoke_ppm);
                cmd.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void displayChart()
        {
            string connStr1 = "server=localhost;user=root;database=mq2_db;password=;";
            MySqlConnection conn1 = new MySqlConnection(connStr1);
            try
            {
                //timer1.Start();

                string sql = "SELECT * FROM sensor_reading";
                MySqlCommand cmd = new MySqlCommand(sql, conn1);
                MySqlDataReader myReader;
                try
                {
                    conn1.Open();
                    myReader = cmd.ExecuteReader();

                    while (myReader.Read())
                    {

                        chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                        chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

                        this.chart1.Series["LPG PPM"].Points.AddY(myReader.GetInt32("lpg_ppm"));
                        this.chart1.Series["CO PPM"].Points.AddY(myReader.GetInt32("co_ppm"));
                        this.chart1.Series["SMOKE PPM"].Points.AddY(myReader.GetInt32("smoke_ppm"));
                        this.chart1.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "dd/mm/yyyy\nHH:mm:ss";
                        //this.chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd\nHH:mm:ss";
                    }
                } catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }
}
