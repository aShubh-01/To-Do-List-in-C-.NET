# To-Do-List-in-C-.NET
This is a simple to-do list I made using window forms in c#.net(database included).


Steps to run the program -
1. Download all the directories/subdirectories and their respective files. Make sure every file is in correct directory/folder.

2. Open Visual Studio 2022, Choose Open Project and select '_SMS.sln_'. This should load the program in your visual studio.
   
3. To connect the database, hit 'ctrl + alt + S' or just navigate to 'View -> Server Explorer'. There you'll see 'Data Connections' with '_SMS.mdf_' file, thats the database file, refresh it by right clicking.
   
4. Right click on the '_SMS.mdf_' and select 'Properties', you'll see a property called 'Connection String' with '___Data Source=___'. Copy the entire string from '___Data Source=....___' all the way upto the end
   '___....Security=True___'. This is basically the path where you stored your project files and where the database is located.
   
5. Once you have copied the string, paste it in specific places, for that navigate to 'View -> Solution Explorer' or just hit 'ctrl + alt + L' which will open Solution Explorer. Now open _Form1.cs_ and hit F7, this      will open its source code.
   
6. There you will see a connection object named 'SqlConnection con = new SqlConnection(@"")' on line 16 probably. Paste the copied connection string within these brackets right between the double quotes "".
   It should look like this       > _SqlConnection con = new SqlConnection(@"___Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""B:\Codes\C# Codes\SMS\SMS\SMS.mdf"";Integrated Security=True___");_
   Paste it in _Form1.cs, Form2.cs, Form3.cs, Form4.cs, Form5.cs, Form7.cs, Form8.cs & Form9.cs_ Source Code.

7. Save every form and hit Start, your program should work.

Incase you use SQL Server Management Studio, you can get the queries to all tables and database in the '_SQLQuery1.sql_'. Then you can setup your own database.
