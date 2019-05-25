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
    public partial class DeleteEvent : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public DeleteEvent()
        {
            InitializeComponent();
        }

        private void DeleteEvent_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT Event_name FROM EVENT";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        EventsComboBox.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                    sqlConnection.Close();
                }
            }

            if (EventsComboBox.Items.Count != 0)
            {
                EventsComboBox.SelectedIndex = 0;
            }
            else
            {
                DeleteButton.Enabled = false;
            }
        }

        #region Button Event Handlers
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM EVENT WHERE Event_name = @eventName";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the event \"" + EventsComboBox.Text + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@eventName", EventsComboBox.Text);

                            sqlConnection.Open();
                            command.ExecuteNonQuery();
                            sqlConnection.Close();

                            MessageBox.Show("Successfully deleted \"" + EventsComboBox.Text + "\" from Events!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EventsComboBox.Items.Remove(EventsComboBox.Text);
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("conflicted with the REFERENCE constraint"))
                            {
                                string errorMessage = "One or more entries in either the Item Use History or the Checkouts table conflicts with this deletion. Please delete the conflicting entries and try again.";

                                MessageBox.Show(errorMessage, "Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Could not delete \"" + EventsComboBox.Text + "\" from Events. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
