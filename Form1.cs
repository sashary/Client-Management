using FinalProject;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClientManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // On form load / startup
        private void Form1_Load(object sender, EventArgs e)
        {
            // Open and close database whenever a query is being sent to avoid connection leak
            Database.ConnectToDatabase();
            Database.UpdateOverview(ref lnklblLatestClient, ref lblClientAmountNumber);
            Database.CloseDatabase();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Clipboard.SetText();
        }

        // Executued when a tab is changed
        private void OnTabIndexChange(object sender, EventArgs e)
        {
            // Cast TabControl on sender
            TabControl page = (TabControl)sender;
            // If user clicks on overview, update overview page
            if (page.SelectedTab == tabPageOverview)
            {
                Database.ConnectToDatabase();
                Database.UpdateOverview(ref lnklblLatestClient, ref lblClientAmountNumber);
                Database.CloseDatabase();
            }
            // If user clicks on Search tab, clear content then display all clients
            if (page.SelectedTab == tabPageSearch)
            {
                txtbxSearch.Text = "";
                txtbxSearchEdit.Text = "";
                lstbxSearch.Items.Clear();

                Database.ConnectToDatabase();
                DataRow[] dr = Database.GetQueries("SELECT id,first_name,last_name,email FROM clients");
                for (int i = 0; i < dr.Length; i++)
                {
                    lstbxSearch.Items.Add("ID: " + dr[i][0].ToString() + " - " + dr[i][1].ToString() + ", " + dr[i][2].ToString() + " - Email: " + dr[i][3]);
                }
                Database.CloseDatabase();
            }
            // Clear Edit Client Tab when user isn't in it
            if (page.SelectedTab != tabPageModifyClient)
            {
                txtbxEditClientAddress.Text = "";
                txtbxEditClientDOB.Text = "";
                txtbxEditClientEmail.Text = "";
                txtbxEditClientFName.Text = "";
                txtbxEditClientID.Text = "";
                txtbxEditClientLName.Text = "";
                cmBoxEditClientOccupation.Text = "";
            }
            // Clear Add Client Tab when user isn't in it
            if (page.SelectedTab != tabPageAddClient)
            {
                txtbxAddClientAddress.Text = "";
                txtbxAddClientDOB.Text = "";
                txtbxAddClientEmail.Text = "";
                txtbxAddClientFName.Text = "";
                txtbxAddClientLName.Text = "";
                cmBoxAddClientOccupation.Text = "";
            }
        }

        // Executed when a user clicks on the Save button in Modify Client
        private void btnEditClientSave_Click(object sender, EventArgs e)
        {
            // For any edits to go through, first name, last name and date of birth must be filled
            if (!(String.IsNullOrWhiteSpace(txtbxEditClientFName.Text) || String.IsNullOrWhiteSpace(txtbxEditClientLName.Text) || String.IsNullOrWhiteSpace(txtbxEditClientDOB.Text)))
            {
                Database.ConnectToDatabase();
                // Check if converting returns null - also allows to validate DOB is written correctly
                if (Client.ConvertTextToTime(txtbxEditClientDOB.Text) != null)
                {
                    if (!String.IsNullOrWhiteSpace(txtbxEditClientID.Text))
                    {
                        // If ID doesn't exist, we can assume something went wrong with retreiving data
                        if (Database.DoesIDExist(int.Parse(txtbxEditClientID.Text)))
                        {
                            Client client = new Client(int.Parse(txtbxEditClientID.Text));
                            client.FirstName = txtbxEditClientFName.Text;
                            client.LastName = txtbxEditClientLName.Text;
                            client.DOB = txtbxEditClientDOB.Text;
                            client.Address = txtbxEditClientAddress.Text;
                            client.Occupation = cmBoxEditClientOccupation.Text;
                            client.Email = txtbxEditClientEmail.Text;

                            client.EditClient();
                            MessageBox.Show("Client has been updated!", "Editing Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ID not found (Error Code: 1)", "Editing Client - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }else
                    {
                        MessageBox.Show("You cannot directly edit a client (Error Code: 6)", "Editing Client - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                Database.CloseDatabase();

            }
            else
            {
                MessageBox.Show("First Name, Last Name and Date of Birth must be filled (Error Code: 3)", "Editing Client - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Executed when a user clickss on the Add button in Add Client
        private void btnAddClientAdd_Click(object sender, EventArgs e)
        {
            // For clients to be created, first name, last name and date of birth must be filled
            if (!(String.IsNullOrWhiteSpace(txtbxAddClientFName.Text) || String.IsNullOrWhiteSpace(txtbxAddClientLName.Text) || String.IsNullOrWhiteSpace(txtbxAddClientDOB.Text)))
            {
                Database.ConnectToDatabase();

                // Check if converting returns null - also allows to validate DOB is written correctly
                if (Client.ConvertTextToTime(txtbxAddClientDOB.Text) != null)
                {
                    Client client = new Client(txtbxAddClientFName.Text, txtbxAddClientLName.Text, txtbxAddClientDOB.Text, txtbxAddClientAddress.Text, cmBoxAddClientOccupation.Text, txtbxAddClientEmail.Text);
                    client.SaveClientToDatabase();
                    tabControl.SelectedTab = tabPageOverview;
                    MessageBox.Show("Client has been added!", "Adding Client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                Database.CloseDatabase();
            }
            else
            {
                MessageBox.Show("First Name, Last Name and Date of Birth must be filled (Error Code: 3)", "Adding Client - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // When the Latest Client link has been clicked, send the user to the Modify Client tab and insert the information the database has on the user to the edit textboxes.
        private void lnklblLatestClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Query: SELECT [column name] FROM [table name] ORDER BY [id] DESC LIMIT [amount]
            // Selects the column name from a specific table, then orders the table by ID in a descending limit of 1 (to get the latest added user)
            Database.ConnectToDatabase();
            // if ID one doesn't exist, the program hasn't been used or the table has been cleared
            if (Database.TableContainsData())
            {
                txtbxEditClientID.Text = Database.GetQuery("SELECT id FROM clients ORDER BY id DESC LIMIT 1");
                txtbxEditClientFName.Text = Database.GetQuery("SELECT first_name FROM clients ORDER BY id DESC LIMIT 1");
                txtbxEditClientLName.Text = Database.GetQuery("SELECT last_name FROM clients ORDER BY id DESC LIMIT 1");
                txtbxEditClientDOB.Text = Database.GetQuery("SELECT dob FROM clients ORDER BY id DESC LIMIT 1");
                txtbxEditClientAddress.Text = Database.GetQuery("SELECT address FROM clients ORDER BY id DESC LIMIT 1");
                cmBoxEditClientOccupation.Text = Database.GetQuery("SELECT occupation FROM clients ORDER BY id DESC LIMIT 1");
                txtbxEditClientEmail.Text = Database.GetQuery("SELECT email FROM clients ORDER BY id DESC LIMIT 1");
                tabControl.SelectedTab = tabPageModifyClient;

            }
            Database.CloseDatabase();

        }

        private void btnEditClientDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this client?", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                if (CanConvertStringToInt(txtbxEditClientID.Text))
                {
                    Database.ConnectToDatabase();
                    Client client = new Client(int.Parse(txtbxEditClientID.Text));
                    client.DeleteClient();
                    tabControl.SelectedTab = tabPageOverview;
                    Database.CloseDatabase();
                }
            }
        }

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // If the ClearDatabase() returns true, send user back to overview and clear all data in overview
            if(Database.ClearDatabase())
            {
                lnklblLatestClient.Text = "None";
                tabControl.SelectedTab = tabPageOverview;

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program was made by Sashary Morel.\n\nYou can contact me at:\nEmail: sasharyjoanmorel@gmail.com \nGithub: github.com/sashary", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.Filter = "Text Document (*.txt)|*.txt";
            saveFileDialog.FileName = "ClientData";
            saveFileDialog.ShowDialog();
        }
        private void btnSearchDB_Click(object sender, EventArgs e)
        {
            // Check if the textbox has the format [string],[string], if not - send an error message
            String[] name = txtbxSearch.Text.Split(',');
            if (name.Length == 2) 
            {
                // Clear list and put the result of our search
                lstbxSearch.Items.Clear();
                Database.ConnectToDatabase();
                // DataRow represents a table that has a column and a row. This means that we're dealing with a two-dimensional array
                DataRow[] dr = Database.GetQueries("SELECT id,first_name,last_name,email FROM clients WHERE first_name='" + name[0] + "' AND last_name='" + name[1] + "'");
                for (int i = 0; i < dr.Length; i++)
                {
                    // Since we know specifically what we're requesting in order (0 = id, 1 = firstname, 2 = lastname, 3 = email, we can hardcode our row
                    lstbxSearch.Items.Add("ID: " + dr[i][0].ToString() + " - " + dr[i][1].ToString() + ", " + dr[i][2].ToString() + " - Email: " + dr[i][3].ToString());
                }
                Database.CloseDatabase();
            }
            else
            {
                MessageBox.Show("The textbox was not filled correctly (Error Code: 4)", "Search Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSearchEdit_Click(object sender, EventArgs e)
        {
            Database.ConnectToDatabase();
            if (CanConvertStringToInt(txtbxSearchEdit.Text))
            {
                if (Database.DoesIDExist(int.Parse(txtbxSearchEdit.Text)))
                {
                    txtbxEditClientID.Text = Database.GetQuery("SELECT id FROM clients WHERE id=" + txtbxSearchEdit.Text);
                    txtbxEditClientFName.Text = Database.GetQuery("SELECT first_name FROM clients WHERE id=" + txtbxSearchEdit.Text);
                    txtbxEditClientLName.Text = Database.GetQuery("SELECT last_name FROM clients WHERE id=" + txtbxSearchEdit.Text);
                    txtbxEditClientDOB.Text = Database.GetQuery("SELECT dob FROM clients WHERE id=" + txtbxSearchEdit.Text);
                    txtbxEditClientAddress.Text = Database.GetQuery("SELECT address FROM clients WHERE id=" + txtbxSearchEdit.Text);
                    cmBoxEditClientOccupation.Text = Database.GetQuery("SELECT occupation FROM clients WHERE id=" + txtbxSearchEdit.Text);
                    txtbxEditClientEmail.Text = Database.GetQuery("SELECT email FROM clients WHERE id=" + txtbxSearchEdit.Text);
                    tabControl.SelectedTab = tabPageModifyClient;
                }
                else
                {
                    MessageBox.Show("ID not found (Error Code: 1)", "Search Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Database.ConnectToDatabase();
        }

        // Issue with this, will still give bad result
        public static bool CanConvertStringToInt(string word)
        {
            int result;
            if (int.TryParse(word, out result))
            {
                return true;
            }

            MessageBox.Show("Number was not converted. Did you not type a number where you were supposed to? (Error Code: 2)", "Convertion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
    }

}
