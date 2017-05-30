/* 
 * Customer.cs
 * Deals with anything related to creating, modifying, validating data, or finding a client in the databse
 * 
 */

using FinalProject;
using System;
using System.Windows.Forms;

namespace ClientManagement
{
    class Client
    {

        int id;
        string fname, lname, address, occupation, email, dob;
        DateTime dob_obj;

        public Client()
        {

        }

        public Client(int id)
        {
            if(Database.DoesIDExist(id))
            {
                this.id = id;
                this.fname = Database.GetQuery("SELECT first_name FROM clients WHERE id=\"" + id + "\"");
                this.lname = Database.GetQuery("SELECT last_name FROM clients WHERE id=\"" + id + "\"");
                this.dob = Database.GetQuery("SELECT dob FROM clients WHERE id=\"" + id + "\"");
                this.address = Database.GetQuery("SELECT address FROM clients WHERE id=\"" + id + "\"");
                this.occupation = Database.GetQuery("SELECT occupation FROM clients WHERE id=\"" + id + "\"");
                this.email = Database.GetQuery("SELECT email FROM clients WHERE id=\"" + id + "\"");
                this.dob_obj = (DateTime)ConvertTextToTime(dob);
            }
        }

        public Client(string fname, string lname, string dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.dob_obj = (DateTime)ConvertTextToTime(dob);
        }

        public Client(string fname, string lname, string dob, string address, string occupation, string email)
        {
            this.fname = fname;
            this.lname = lname;
            this.dob = dob;
            this.address = address;
            this.occupation = occupation;
            this.email = email;
            this.dob_obj = (DateTime)ConvertTextToTime(dob);
        }

        public String FirstName
        {
            get { return fname; }
            set { fname = value; }
        }

        public String LastName
        {
            get { return lname; }
            set { lname = value; }
        }

        public String DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }
        }

        public String Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        // Query: UPDATE [table name] SET [column name] = [value] where id = [id]
        // Updates a specific column on the clients table, while making sure it's updating a spepcific id 
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

        public void DeleteClient()
        {
            if (Database.DoesIDExist(id))
            {
                Database.SendQuery("DELETE FROM clients WHERE id=\"" + id + "\"");
            }
        }


        public void SaveClientToDatabase()
        {
            // Query: INSERT INTO [table name] ([column #1], [column #2], ... [column n-th]) VALUES ([value #1], [value #2] ... [value n-th])
            // Inserts values into the specified columns
            Database.SendQuery(@"INSERT INTO clients (first_name,last_name,dob,address,occupation,email) VALUES ('" +
                fname + "', '" + lname + "','" + dob + "','" + address + "','" + occupation +
               "','" + email + "')");
        }

        // For our purposes, anytime we want to convert the date of birth text to DateTime object (for easier modifying), we call this function
        // This must be casted as a DateTime when in use, to allow us to return null in case anything goes wrong
        public static object ConvertTextToTime(string text)
        {
            int month=0, day=0, year=0;
            try
            {
                // The format is MM/DD/YYY, we parse by / to get each unit individually
                string[] array = text.Split('/');
                if (Form1.CanConvertStringToInt(array[0]) && Form1.CanConvertStringToInt(array[1]) && Form1.CanConvertStringToInt(array[2]))
                {
                    month = int.Parse(array[0]);
                    day = int.Parse(array[1]);
                    year = int.Parse(array[2]);
                }else
                {
                    return null;
                }
            }catch(Exception e) { 

                // if ANY exception occurs (be it the int not parsing correctly, or an IndexOutOfBoundException), display an error for the user and return null
                MessageBox.Show("Could not convert the Date of Birth. Did you type the format correctly? (Error Code: 5)", "Client - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            return new DateTime(year, month, day);
        }

    }

    
}
