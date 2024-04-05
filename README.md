# To-Do-List-in-C-.NET
This is a simple to-do list I made using window forms in c#.net(database included).


Steps to run the program -
1. Download all the directories/subdirectories and their respective files. Make sure every file is in correct directory/folder.

2. Open Visual Studio 2022, Choose Open Project and select 'SMS.sln'. This should load the program in your visual studio.
   
3. To connect the database, hit 'ctrl + alt + S' or just navigate to 'View -> Server Explorer'. There you'll see 'Data Connections' with 'SMS.mdf' file, thats the database file, refresh it by right clicking.
   
4. Right click on the 'SMS.mdf' and select 'Properties', you'll see a property called 'Connection String' with 'Data Source='. Copy the entire string from 'Data Source=....' all the way upto the end
   '....Security=True'. This is basically the path where you stored your project files and where the database is located.
   
5. Once you have copied the string, paste it in specific places, for that navigate to 'View -> Solution Explorer' or just hit 'ctrl + alt + L' which will open Solution Explorer. Now open Form1.cs and hit F7, this      will open its source code.
   
6. There you will see a connection object named 'SqlConnection con = new SqlConnection(@"")' Paste the copied connection string within these brackets right between the double quotes "".
   It should look like this       > SqlConnection con = new SqlConnection(@"___Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""B:\Codes\C# Codes\SMS\SMS\SMS.mdf"";Integrated Security=True___");
   Paste it in Form1.cs, Form3.cs, Form4.cs, Form5.cs, Form7.cs, Form8.cs & Form9.cs Source Code.

7. Save every form and hit Start, your program should work.
