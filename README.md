# Client-Management
A user can add a new client, modify an existing client, or search for a client in a database using this program.

Author: Sashary Morel 

## Table of Contents:
1.	Overview
2.	Dependencies
4.	Getting Started – Overview (Source Code)
6.	Menu Strips 
8.	Tab Control – Add Client
10.	Tab Control – Modify Client 
12.	Tab Control – Search 
13.	Error Codes

#### Note: Just a quick notice, I will only explain what I believe are very important parts of this program in this section. To get a general sense of the code, please take a look at the source code

## General Overview
The purpose of this program is to allow users to quickly store a clients’ information into a database. A user can add a new client, modify an existing client, or search for a client in the database. This program uses 2 core systems, Visual C# and a MySQL Database, to allow the program to interact with the user and store data.

## Dependencies & Important Information 
This program uses a MySQL dependency found in newer versions of Visual Studio. When installing Visual Studio 2017, you can select the MySQL dependency to be downloaded alongside it. For any older version of Visual Studio, the MySQL dependencies must be downloaded and installed into the Visual Studio IDE. More information can be found here: 
https://dev.mysql.com/downloads/windows/visualstudio/

It is also important that a table named clients is created inside a database with these values:

-id int(11) PRIMARY KEY

-first_name varchar(255) NOT NULL

-last_name varchar(255) NOT NULL

-dob varchar(255) NOT NULL

-address varchar(255)

-occupation varchar(255)

-email varchar(255)


## Getting Started – Overview
When the form starts up, the first function that occurs (for all intents and purposes) is the Form_Load. The Form load executes the following command:

            Database.ConnectToDatabase();
            Database.UpdateOverview(ref lnklblLatestClient, ref lblClientAmountNumber);
            Database.CloseDatabase(); 
            
These 3 lines are important to understanding how we retrieve data from the database. A custom class named Database was created to make sure that we can keep our source code clean. We’ll explore more about the functions about it later, but for now we will look at these three functions:

        public static void ConnectToDatabase()
        {
            string sConnect;
            sConnect =         "datasource=[REMOVED];port=3306;username=[REMOVED];password=[REMOVED];database=clients;";
            databaseConnection = new MySqlConnection(sConnect);
            databaseConnection.Open();  

        }
        public static void CloseDatabase()
        {
            databaseConnection.Close();

        }
        public static void UpdateOverview(ref LinkLabel latestClients, ref Label clientAmount)
        {
		// Too much code, check the source code in the bottom 
        }
        
For any request that we send or get from the database, we will always open and close a connection to the database to avoid any chances of a memory leak occurring. For our next method, UpdateOverview, we simply send a request from the database (SELECT * FROM clients WHERE id=SELECT MAX(id) FROM clients), that returns to use the id with the highest value. This guarantees that anytime we run this query, we will get the latest user. If a user does show up, then we change the Text values of the label. 

## Menu Strips 

There is not much to explain aside from the Clear Database query, which looks something like this:

                Database.ConnectToDatabase();
                Database.SendQuery("TRUNCATE TABLE clients");
                Database.CloseDatabase();
                
We simply send a query with the parameter of a string to the database and tell it to truncate (also known as clear) the database named clients.

## Tab Control – Add Client 
While there are many components that make up this section, we’ll focus on the validation of the Date of Birth and how the client is stored in the database. First, to make sure the user is typing the date of birth correctly is by creating a function called ConvertTextToTime:

        public static object ConvertTextToTime(string text)
        {
            int month=0, day=0, year=0;
            
This function takes the text, and tries to splits it into an array. Once split, it tries to convert the text into an integer. If it converts, then we set our variables to a certain integer and let the function continue. If by any chance, it cannot split the string correctly, then we send an error to the user. Same scenario will occur if it cannot parse the int.

     month = int.Parse(array[0]);
            day = int.Parse(array[1]);
            year = int.Parse(array[2]);
            
At the end, we simply return a new DateTime. 
     return new DateTime(year, month, day);
The possibilities with DateTime can allow us to get more technical with the Date of Birth if we decide to add more features to the program.
Another important function in this section is the way in which data is stored / modified for a client. Anytime we want to add / change / remove a client, we call the following class:

	Client client = new Client(txtbxAddClientFName.Text, txtbxAddClientLName.Text, txtbxAddClientDOB.Text, txtbxAddClientAddress.Text, cmBoxAddClientOccupation.Text, txtbxAddClientEmail.Text);
  
The class contains different constructors depending our needs, for this one we use the text of the AddClient textboxes to fill the constructor with all available client data. Our method for storying this client in the database is simple, and looks something like this:
            Database.SendQuery(@"INSERT INTO clients (first_name,last_name,dob,address,occupation,email) VALUES ('" +
                fname + "', '" + lname + "','" + dob + "','" + address + "','" + occupation + "','" + email + "')");

We simply send a query with the data we want to send out, while having a few if statements in between to make sure our data is valid and ready to go through
 

## Tab Control – Modify Client
As for the source code in this section, we’ll take a look at how we save the data into the database. 

            // For any edits to go through, first name, last name and date of birth must be filled
            if (!(String.IsNullOrWhiteSpace(txtbxEditClientFName.Text) || String.IsNullOrWhiteSpace(txtbxEditClientLName.Text) || String.IsNullOrWhiteSpace(txtbxEditClientDOB.Text)))
            {
                Database.ConnectToDatabase();
                if (Client.ConvertTextToTime(txtbxEditClientDOB.Text) != null)
                {
                    if (!String.IsNullOrWhiteSpace(txtbxEditClientID.Text))
                    {
                    
Through a series of if statements, we make sure we validate some of the data before allowing anything to occur. Once we’re sure that the data is valid and can be used, we then create a Client instance with a constructor that uses an ID to identify a client.
Client client = new Client(int.Parse(txtbxEditClientID.Text));
client.EditClient();
Lastly, we call a function inside the client class named EditClient and send a query for the database to change the client’s data.

        public void EditClient()
        {

            if (Database.DoesIDExist(id))
            {
                Database.SendQuery("UPDATE clients SET first_name = \'" + fname + "\' WHERE id = \'" + id + "\'");
                Database.SendQuery("UPDATE clients SET last_name = \'" + lname + "\' WHERE id = \'" + id + "\'");
                Database.SendQuery("UPDATE clients SET dob = \'" + dob + "\' WHERE id = \'" + id + "\'");
                Database.SendQuery("UPDATE clients SET address = \'" + address + "\' WHERE id = \'" + id + "\'");
                Database.SendQuery("UPDATE clients SET occupation = \'" + occupation + "\' WHERE id = \'" + id + "\'");
                Database.SendQuery("UPDATE clients SET email = \'" + email + "\' WHERE id = \'" + id + "\'");
            }
        }


## Tab Control – Search 
For the final part, we’ll look at how the list box loads 

                DataRow[] dr = Database.GetQueries("SELECT id,first_name,last_name,email FROM clients");
                for (int i = 0; i < dr.Length; i++)
                {
                    lstbxSearch.Items.Add("ID: " + dr[i][0].ToString() + " - " + dr[i][1].ToString() + ", " + dr[i][2].ToString() + " - Email: " + dr[i][3]);
                }
                
From the GetQueries (a different function from our other function named GetQuery, which only gets the first result from the database and returns a string) we get a data type named DataRow, which gives us a 2dimensional array that takes in columns and rows. Since we’re requesting 4 rows and we set the order in which the DataRow will receive these requests, we know that:
[0] = ID
[1] = First Name
[2] = Last Name
[3] = Email

And thus, we can hardcode the second part of our 2d array, while looping the first one (which is looping every client). 
The searching method isn’t any different, and looks something like this:

            String[] name = txtbxSearch.Text.Split(',');
            if (name.Length == 2) 
            {
                lstbxSearch.Items.Clear();
                Database.ConnectToDatabase();
                DataRow[] dr = Database.GetQueries("SELECT id,first_name,last_name,email FROM clients WHERE first_name='" + name[0] + "' AND last_name='" + name[1] + "'");
                for (int i = 0; i < dr.Length; i++)
                {
                    lstbxSearch.Items.Add("ID: " + dr[i][0].ToString() + " - " + dr[i][1].ToString() + ", " + dr[i][2].ToString() + " - Email: " + dr[i][3].ToString());
                }
                Database.CloseDatabase();
            }

We check that the name can be split with a delimiter and returns a length of 2 (firstname,lastname) and then we clear the list box to insert new data. The different now is that we specify a where in our query to make sure we’re only getting a specific first and last name.

## Error Codes
For easier debugging, error codes have been added. This will give some clarity for the user and any developer who works on this project.
 
##### ID not found (Error Code: 1)

This error occurs when the database cannot find the specified ID. Either you specified an incorrect ID, or there is something wrong with the database. 

#### Number was not converted. Did you not type a number where you were supposed to? (Error Code: 2)

This error occurs when the system tries to convert a word or letter into a number, and fails during the process. This can be fixed by making sure your textboxes include the correct information in it. 

#### First Name, Last Name and Date of Birth must be filled (Error Code: 3)

For the program to insert data about a customer in a database, the minimum requirements must include the client’s First Name, Last Name & Data of Birth. Any other textbox can be left blank and edited for the future.

#### The textbox was not filled correctly (Error Code: 4)

When a textbox does is not filled correctly, an error will occur. You must follow the specific instructions for the program to work.

#### Could not convert the Date of Birth. Did you type the format correctly? (Error Code: 5)

If a user does not type the Date of Birth in the correct order or format (MM/DD/YYYY), an error will occur when converting the data. 

#### You cannot directly edit a client (Error Code: 6)

If a user directly edits a client in the Modify Client tab without searching and editing for a client, then this error occurs. You must search for a client before modifying their information.

