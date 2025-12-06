# HardikRathod-20083974---AdvProgramming-CA1-
Advance Programming CA -1

Student Name and Number: Hardik Shailesh Rathod (20083974)  
Course Title:  M.Sc. Cyber Security   
Lecturer Name:  Swati Dongre   
Module/Subject Title: Advanced Programming Techniques   
Assignment Title:   CA_ONE (30%)   
No of Words: 656


# Table Of Contents
1.	INTRODUCTION…………………………………………..2
2.	C# PROGRAMMING ……………………………………...3
•	Contact Book
•	File Extension System
3.	PYTHON PROGRAMMING………………………………9
•	Client-Server Application
•	Web Scraping & CSV Handling
4.	CONCLUSION………………………………………………12
5.	REFERENCES………………………………………………12
6.	GITHUB REPOSITORY LINK……………………………12



# 1.	INTRODUCTION
I made four applications for this assignment using python and C#. I developed a file extension information system and a contact book in C#. Then, I developed a python client-server program to monitor student admission and a web scraping program for hotels that outputs data to a CSV file. I was able to gain experience with data manipulation, programming and problem solving through these assignments.


# 2.	C# PROGRAMMING

# Que.1 Contact Book
For this program, I developed a C# contact book program. 
This project contains two files:
i.	Program.cs
ii.	ContactBook.cs

I made a ContactBook class with the name, company, phone number, email, address and birthdate of every contact. At the start of the program, the array has 20 contacts. The menu lets the user add, view, update and 
remove contacts while confirming that the phone number is nine digits long. I used basic OOP concepts to test the program using dotnet run, which runs continuously until the user exits.



# Que.2 File Extension System 
To answer this question, I created a C# console application that displays information about different file extensions
I made 2 files in this program:
i.	Program.cs
ii.	FileType.cs

I created a program that generated 20 default file extensions using the DefaultExtention() method. The menu allows the user to view, add, remove, update or search an extension. If the user enters an extension but forgets to do so, the program will automatically add a dot. An error message shows up if there is not an extension. I was able to use dotnet run to debug each of the fundamental OOP concepts, such as classes, objects and methods.



# 3.	PYTHON PROGRAMMING

# Que.3 Client-Server Application
Using python sockets, I created a server program that waits for a client. I created a client program that sends information about students admissions to the server. I used SQLite to create a database file that contains all of the student information. After receiving the data, the server generates and saves a unique application number. The client receives the application number from the server. The application number is sent back to the client by the server. The application number is given to the user by the client. Databases, TCP communication and basic string manipulation are used in this work.


# Que.4 Web Scraping and CSV Handling
Since actual hotel websites do not permit web scraping for this task, I made two demo hotel webpages to practice data extraction. Since every demo website was constructed differently, I gathered the room details using two different approaches. Since JavaScript was used to generate the rooms on the first website (Hotel A), the room details are not directly displayed in the HTML. 

I opened the HTML page and saved it as plain text and used the simplest form of splitting string to find the room list inside the JavaScript code since BeautifulSoup has no idea that something created by JavaScript exists. I then extracted the names and prices of the rooms. I applied BeautifulSoup to spend a few seconds in searching all the room cards in the second site (Hotel B) and extract the name and the price since the information about the rooms was already included in the HTML. I copied all the data on the two demo websites in a CSV file and printed the results to ensure that the scraping worked.



# 4.	CONCLUSION 
I created four Python and C# applications for this project. My understanding of classes, objects, methods, and appropriate data handling has improved thanks to the Contact Book and File Extension System in C#. The Web Scraping project and the Python Client-Server application have increased my understanding of databases, networking, and CSV file storage. I gained a lot of knowledge about programming, problem-solving, and using what I learned in practical settings through these projects. All things considered, this assignment increased my confidence in my coding skills and provided me with real-world experience that I can apply to future projects.

# 5.	REFERENCES
Mitchell, R. (2018). Web Scraping with Python: Collecting data from the modern web (2nd ed.). O’Reilly Media.https://www.oreilly.com/library/view/web-scraping-with/9781491985564/

Richardson, L. (2022). Beautiful Soup documentation. https://www.crummy.com/software/BeautifulSoup/

Python Software Foundation. (2024). Python 3 documentation.
https://docs.python.org/3/

Microsoft. (2024). Classes and objects – C# documentation.
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/classes


# 6.	GITHUB REPOSITORY LINK
  https://github.com/hardurathod/HardikRathod-20083974---AdvProgramming-CA1-.git
