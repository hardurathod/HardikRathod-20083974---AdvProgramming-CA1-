import socket
import sqlite3
import random

DB = sqlite3.connect("Admission.db")
cursor = DB.cursor()

cursor.execute("""
    CREATE TABLE IF NOT EXISTS STUDENTS(
        AppID TEXT,
        Name TEXT,
        Address TEXT,
        Qualification TEXT,
        Course TEXT,
        Year TEXT,
        Month TEXT
    )
""")
DB.commit()

server = socket.socket()
ServerHost = "127.0.0.1"
ServerPort = 5000
server.bind((ServerHost, ServerPort))
server.listen(1)

print("Server Is Running... Waiting For Incoming Connection...")

while True:
    ClientSocket, ClientAddress = server.accept()
    print("Client Connected:", ClientAddress)

    DataReceived = ClientSocket.recv(1024).decode()
    fields = DataReceived.split("|")

    Name = fields[0]
    Address = fields[1]
    Qualification = fields[2]
    Course = fields[3]
    Year = fields[4]
    Month = fields[5]

    appId = "ADM" + str(random.randint(1000, 9999))

    cursor.execute("""
        INSERT INTO STUDENTS VALUES (?, ?, ?, ?, ?, ?, ?)
    """, (appId, Name, Address, Qualification, Course, Year, Month))
    
    DB.commit()

    ClientSocket.send(appId.encode())
    ClientSocket.close()
