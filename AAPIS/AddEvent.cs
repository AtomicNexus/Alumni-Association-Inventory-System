using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAPIS
{
    public partial class AddEvent : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";
        private List<string> currentEventNames = new List<string>();

        public void EnableOrDisableAddButton()
        {
            if (string.IsNullOrWhiteSpace(EventIDTextBox.Text) || string.IsNullOrWhiteSpace(EventNameTextBox.Text) || currentEventNames.Contains(EventNameTextBox.Text))
            {
                AddButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
            }
        }

        public AddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            AddButton.Enabled = false;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT Event_name FROM EVENT";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        currentEventNames.Add(reader[0].ToString());
                    }
                    reader.Close();
                    sqlConnection.Close();
                }
            }
        }

        #region Button Event Handlers
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string sqlQuery = "INSERT INTO EVENT(Event_number, Event_name) VALUES(@eventId, @eventName)";

                using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@eventID", int.Parse(EventIDTextBox.Text));
                        if (String.IsNullOrEmpty(EventNameTextBox.Text))
                        {
                            command.Parameters.AddWithValue("@eventName", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@eventName", EventNameTextBox.Text);
                        }
                        
                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();

                        MessageBox.Show("Successfully added \"" + EventNameTextBox.Text + "\" to Events!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not add \"" + EventNameTextBox.Text + "\" to Events. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void RandomIntButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            EventIDTextBox.Text = random.Next(100, 1000).ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Add Button Enablers/Disablers
        private void EventIDTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableOrDisableAddButton();
        }

        private void EventNameTextBox_TextChanged(object sender, EventArgs e)
        {
            EnableOrDisableAddButton();
        }
        #endregion
    }
}
