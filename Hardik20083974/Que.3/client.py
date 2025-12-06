import socket

client = socket.socket()
client.connect(("127.0.0.1", 5000))

print("Please Enter Your Details Below: ")

Name = input("Full Name: ")
Address = input("Address: ")
Qualification = input("Qualification: ")
Course = input("Course: ")
Year = input("Start Year: ")
Month = input("Start Month: ")

msg = Name + "|" + Address + "|" + Qualification + "|" + Course + "|" + Year + "|" + Month

client.send(msg.encode())

assignedId = client.recv(1024).decode()
print("\nYOUR APPLICATION ID IS:", assignedId)

client.close()
