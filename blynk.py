import mysql.connector
import requests
import time

Connect to MySQL server
mydb = mysql.connector.connect(
    host="localhost",
    user="root",
    password="",
    database="",
)

# Create database and tables if they do not exist
mycursor = mydb.cursor()
mycursor.execute("CREATE DATABASE IF NOT EXISTS mq2database")
mycursor.execute("USE mq2database")
mycursor.execute("CREATE TABLE IF NOT EXISTS sensor_data (id INT AUTO_INCREMENT PRIMARY KEY, lpg_ppm INT, co_ppm INT, smoke_ppm INT, timestamp TIMESTAMP DEFAULT CURRENT_TIMESTAMP)")
mycursor.execute("CREATE TABLE IF NOT EXISTS admin_tb (id INT AUTO_INCREMENT PRIMARY KEY, name VARCHAR(255), username VARCHAR(255), password VARCHAR(255))")
ycursor.execute("INSERT INTO `admin_tb`(`name`, `username`, `password`) VALUES ('Wil Fred Catalan','admin','admin1')")

# check if device is offline or online
url0 = 'https://sgp1.blynk.cloud/external/api/isHardwareConnected?token=FZKqPd2xiy0ebJP8DPyb0BfcoTKcr13L'

# Blynk API value
url1 = 'https://sgp1.blynk.cloud/external/api/get?token=FZKqPd2xiy0ebJP8DPyb0BfcoTKcr13L&v1'
url2 = 'https://sgp1.blynk.cloud/external/api/get?token=FZKqPd2xiy0ebJP8DPyb0BfcoTKcr13L&v2'
url3 = 'https://sgp1.blynk.cloud/external/api/get?token=FZKqPd2xiy0ebJP8DPyb0BfcoTKcr13L&v3'
# CallmeBot API
bot1 = 'https://api.callmebot.com/whatsapp.php?phone=639054100152&text=High Amount of Gas is Detected!&apikey=6438056'
bot2 = 'https://api.callmebot.com/whatsapp.php?phone=639054100152&text=High Amount of Carbon Monoxide is Detected!&apikey=6438056'
bot3 = 'https://api.callmebot.com/whatsapp.php?phone=639054100152&text=High Amount of Smoke is Detected!&apikey=6438056'

response0 = requests.get(url0)
value0 = response0.json()

if value0 != True:
    print("Device is offline!")
else:
    while True:
        response1 = requests.get(url1)
        response2 = requests.get(url2)
        response3 = requests.get(url3)
        value1 = response1.json()
        value2 = response2.json()
        value3 = response3.json()

        print(f"LPG ppm:{value1}\tCO ppm:{value2}\tSmoke ppm:{value3}")

        if value1 >= 2000:
            requests.get(bot1)
        if value2 >= 150:
            requests.get(bot2)
        if value3 >= 80:
            requests.get(bot3)

        if value1 >=1 or value2 >=1 or value3 >=1:
        # Insert the data into the database
            sql = "INSERT INTO sensor_data (lpg_ppm, co_ppm, smoke_ppm) VALUES (%s, %s, %s)"
            val = (value1, value2, value3)
            mycursor.execute(sql, val)
            mydb.commit()
        
    time.sleep(0.1)
    
# Close the database connection
mycursor.close()
mydb.close()
