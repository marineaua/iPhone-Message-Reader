using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace iPhoneBackupMessageReader
{
    public partial class Form1 : Form
    {
        string messageConnectionString;
        string contactConnectionString;

        public Form1()
        {
            InitializeComponent();
            //31bb7ba8914766d4ba40d6dfb6113c8b614be442 for address
            contactConnectionString = @" Data Source = C:\Users\alexm_000\Desktop\iOS_BACKUP\31bb7ba8914766d4ba40d6dfb6113c8b614be442; Version = 3 ";
            messageConnectionString = @" Data Source = C:\Users\alexm_000\Desktop\iOS_BACKUP\3d0d7e5fb2ce288813306e4d4636395e047a3d28; Version = 3 ";
        }

        private void importData_Click(object sender, EventArgs e)
        {
            //// Create an instance of the open file dialog box.
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //// Set filter options and filter index.
            //openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 1;

            //// Process input if the user clicked OK.
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    // Open the selected file to read.
            //    System.IO.Stream fileStream = openFileDialog1.OpenFile();

            //    using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
            //    {
            //        // Read the first line from the file and write it the textbox.
            //        richTextBox1.Text = reader.ReadLine();
            //    }
            //    fileStream.Close();
            //}
        }

        private void btnConnectToDatabase_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(messageConnectionString))
            {
                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Connection created successfully...");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }

        private void btnCloseConnection_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(messageConnectionString);
            con.Close();
        }

        private void btnShowMessages_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(messageConnectionString);
            con.Open();
            string sql = "SELECT * FROM message WHERE handle_id = 1";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = command.ExecuteReader();
            //int i = 1;
            while (reader.Read())
            {
                textAreaMessages.Text += (reader["text"].ToString() + "\n");
                //Console.WriteLine(i + " : " +  reader["text"].ToString());
                //i++;
            }
            //Console.ReadLine();
            
            reader.Close();
            con.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFillContacts_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(contactConnectionString);
            con.Open();
            string sql = "SELECT * FROM ABPerson ORDER BY First";
            SQLiteCommand command = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                //ListViewItem newPerson;
                //string[] personArray = new string[2];
                //personArray[0] = reader["First"].ToString();
                //personArray[1] = reader["Last"].ToString();
                //newPerson = new ListViewItem(personArray);
                //listViewContacts.Items.Add(newPerson);
                listBoxContacts.Items.Add(reader["First"].ToString() + " " + reader["Last"].ToString());
            }

            reader.Close();
            con.Close();
        }
    }
}

