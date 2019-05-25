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
    public partial class CheckoutItemQuantity : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public CheckoutItemQuantity()
        {
            InitializeComponent();
        }

        private void CheckoutItemQuantity_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM EVENT";

                using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable eventTable = new DataTable();

                    dataAdapter.Fill(eventTable);
                    EventsDataGridView.DataSource = new BindingSource(eventTable, null);
                }
            }
        }

        #region Button Event Handlers
        private void CheckoutItemButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CheckoutQuantityUpDown.Value) > CheckoutItem.itemTotalQuantity)
            {
                MessageBox.Show("Error: Checkout quantity cannot be greater than total quantity available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string insertIntoUseHistory = "INSERT INTO ITEM_USE_HISTORY(Use_history_id, Item_num, Event_num, Item_quantity_used, Item_use_date) " +
                                                  "VALUES(@historyID, @itemID, @eventID, @quantityUsed, @useDate)";
                    string insertIntoCurrentUse = "INSERT INTO ITEM_CURRENTLY_IN_USE(Item_num, Event_num, Item_quantity_in_use, Item_date_of_checkout) " +
                                                  "VALUES(@itemID, @eventID, @quantityInUse, @dateCheckedOut)";
                    string updateInventoryQuantities = "UPDATE ITEM_INVENTORY SET Item_total_quantity_available = @updatedTotalQuantity, Item_total_quantity_in_use = @updatedInUseQuantity " +
                                                       "WHERE Item_number = @itemID";

                    using (SqlCommand command1 = new SqlCommand(insertIntoUseHistory, sqlConnection))
                    {
                        try
                        {
                            command1.Parameters.AddWithValue("@historyID", int.Parse(UseHistoryIDTextBox.Text));
                            command1.Parameters.AddWithValue("@itemID", CheckoutItem.itemID);
                            command1.Parameters.AddWithValue("@eventID", int.Parse(EventsDataGridView[0, EventsDataGridView.CurrentRow.Index].Value.ToString()));
                            command1.Parameters.AddWithValue("@quantityUsed", Convert.ToInt32(CheckoutQuantityUpDown.Value));
                            command1.Parameters.AddWithValue("@useDate", DateTime.Now.ToString());

                            sqlConnection.Open();
                            command1.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    using (SqlCommand command2 = new SqlCommand(insertIntoCurrentUse, sqlConnection))
                    {
                        try
                        {
                            command2.Parameters.AddWithValue("@itemID", CheckoutItem.itemID);
                            command2.Parameters.AddWithValue("@eventID", int.Parse(EventsDataGridView[0, EventsDataGridView.CurrentRow.Index].Value.ToString()));
                            command2.Parameters.AddWithValue("@quantityInUse", Convert.ToInt32(CheckoutQuantityUpDown.Value));
                            command2.Parameters.AddWithValue("@dateCheckedOut", DateTime.Now.ToString());

                            sqlConnection.Open();
                            command2.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    using (SqlCommand command3 = new SqlCommand(updateInventoryQuantities, sqlConnection))
                    {
                        try
                        {
                            command3.Parameters.AddWithValue("@updatedTotalQuantity", CheckoutItem.itemTotalQuantity - Convert.ToInt32(CheckoutQuantityUpDown.Value));
                            command3.Parameters.AddWithValue("@updatedInUseQuantity", CheckoutItem.itemQuantityInUse + Convert.ToInt32(CheckoutQuantityUpDown.Value));
                            command3.Parameters.AddWithValue("@itemID", CheckoutItem.itemID);

                            sqlConnection.Open();
                            command3.ExecuteNonQuery();
                            sqlConnection.Close();

                            CheckoutItem.itemTotalQuantity -= Convert.ToInt32(CheckoutQuantityUpDown.Value);
                            CheckoutItem.itemQuantityInUse += Convert.ToInt32(CheckoutQuantityUpDown.Value);

                            if (Convert.ToInt32(CheckoutQuantityUpDown.Value) != 1)
                            {
                                MessageBox.Show("Successfully checked out " + Convert.ToInt32(CheckoutQuantityUpDown.Value).ToString() + " units of \"" + CheckoutItem.itemName + "\" from Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Successfully checked out " + Convert.ToInt32(CheckoutQuantityUpDown.Value).ToString() + " unit of \"" + CheckoutItem.itemName + "\" from Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void GenerateRandomIntButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            UseHistoryIDTextBox.Text = r.Next(10000, 100000).ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void UseHistoryIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UseHistoryIDTextBox.Text))
            {
                CheckoutItemButton.Enabled = false;
            }
            else
            {
                CheckoutItemButton.Enabled = true;
            }
        }
    }
}
