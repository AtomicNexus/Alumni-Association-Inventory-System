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
    public partial class ViewCheckouts : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";
        private int itemNum;
        private int eventNum;
        private int itemTotalQuantityAvailable;
        private int itemTotalQuantityInUse;
        private string itemName;
        private int itemQuantityReturned;

        public ViewCheckouts()
        {
            InitializeComponent();
        }

        #region Checked Out Items Table View Updaters
        public void UpdateCheckouts()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT Item_number, Event_number, Item_total_quantity_available, Item_total_quantity_in_use, Item_name, Event_name, Item_quantity_in_use, Item_date_of_checkout " +
                               "FROM ITEM_INVENTORY JOIN ITEM_CURRENTLY_IN_USE ON Item_number = Item_num " +
                                                   "JOIN EVENT ON Event_num = Event_number";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    sqlConnection.Close();

                    CheckedOutItemsDataGridView.DataSource = dataTable;
                    CheckedOutItemsDataGridView.Columns[0].Visible = false;  // Item_number
                    CheckedOutItemsDataGridView.Columns[1].Visible = false;  // Event_number
                    CheckedOutItemsDataGridView.Columns[2].Visible = false;  // Item_total_quantity_available before update
                    CheckedOutItemsDataGridView.Columns[3].Visible = false;  // Item_total_quantity_in_use before update

                    if (CheckedOutItemsDataGridView.Rows.Count == 0)
                    {
                        ReturnItemButton.Enabled = false;
                    }
                    else
                    {
                        ReturnItemButton.Enabled = true;

                    }
                }
            }
        }

        public void UpdateWithSearchTerms()
        {
            if (string.IsNullOrWhiteSpace(SearchByItemTextBox.Text) && string.IsNullOrWhiteSpace(SearchByEventTextBox.Text))
            {
                UpdateCheckouts();
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Item_number, Event_number, Item_total_quantity_available, Item_total_quantity_in_use, Item_name, Event_name, Item_quantity_in_use, Item_date_of_checkout " +
                                   "FROM ITEM_INVENTORY JOIN ITEM_CURRENTLY_IN_USE ON Item_number = Item_num " +
                                                       "JOIN EVENT ON Event_num = Event_number " +
                                   "WHERE (Item_name LIKE @itemName) AND (Event_name LIKE @eventName)";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@itemName", "%" + SearchByItemTextBox.Text + "%");
                        command.Parameters.AddWithValue("@eventName", "%" + SearchByEventTextBox.Text + "%");

                        sqlConnection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        sqlConnection.Close();

                        CheckedOutItemsDataGridView.DataSource = dataTable;
                        CheckedOutItemsDataGridView.Columns[0].Visible = false;  // Item_number
                        CheckedOutItemsDataGridView.Columns[1].Visible = false;  // Event_number
                        CheckedOutItemsDataGridView.Columns[2].Visible = false;  // Item_total_quantity_available before update
                        CheckedOutItemsDataGridView.Columns[3].Visible = false;  // Item_total_quantity_in_use before update
                    }
                }
            }
        }
        #endregion

        private void ViewCheckouts_Load(object sender, EventArgs e)
        {
            UpdateCheckouts();
        }

        #region Button Event Handlers
        private void ReturnItemButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to return the item \"" + CheckedOutItemsDataGridView[4, CheckedOutItemsDataGridView.CurrentRow.Index].Value.ToString() + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                itemNum = int.Parse(CheckedOutItemsDataGridView[0, CheckedOutItemsDataGridView.CurrentRow.Index].Value.ToString());
                eventNum = int.Parse(CheckedOutItemsDataGridView[1, CheckedOutItemsDataGridView.CurrentRow.Index].Value.ToString());
                itemTotalQuantityAvailable = int.Parse(CheckedOutItemsDataGridView[2, CheckedOutItemsDataGridView.CurrentRow.Index].Value.ToString());
                itemTotalQuantityInUse = int.Parse(CheckedOutItemsDataGridView[3, CheckedOutItemsDataGridView.CurrentRow.Index].Value.ToString());
                itemName = CheckedOutItemsDataGridView[4, CheckedOutItemsDataGridView.CurrentRow.Index].Value.ToString();
                itemQuantityReturned = int.Parse(CheckedOutItemsDataGridView[6, CheckedOutItemsDataGridView.CurrentRow.Index].Value.ToString());

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string updateInventoryQuantities = "UPDATE ITEM_INVENTORY SET Item_total_quantity_available = @updatedTotalQuantity, Item_total_quantity_in_use = @updatedInUseQuantity " +
                                                       "WHERE Item_number = @itemID";
                    string deleteCheckout = "DELETE FROM ITEM_CURRENTLY_IN_USE WHERE (Item_num = @itemID) AND (Event_num = @eventID)";

                    using (SqlCommand command1 = new SqlCommand(updateInventoryQuantities, sqlConnection))
                    {
                        try
                        {
                            command1.Parameters.AddWithValue("@updatedTotalQuantity", itemTotalQuantityAvailable + itemQuantityReturned);
                            command1.Parameters.AddWithValue("@updatedInUseQuantity", itemTotalQuantityInUse - itemQuantityReturned);
                            command1.Parameters.AddWithValue("@itemID", itemNum);

                            sqlConnection.Open();
                            command1.ExecuteNonQuery();
                            sqlConnection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    using (SqlCommand command2 = new SqlCommand(deleteCheckout, sqlConnection))
                    {
                        try
                        {
                            command2.Parameters.AddWithValue("@itemID", itemNum);
                            command2.Parameters.AddWithValue("@eventID", eventNum);

                            sqlConnection.Open();
                            command2.ExecuteNonQuery();
                            sqlConnection.Close();

                            if (itemQuantityReturned != 1)
                            {
                                MessageBox.Show("Successfully returned " + itemQuantityReturned.ToString() + " units of \"" + itemName + "\" to Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Successfully returned " + itemQuantityReturned.ToString() + " unit of \"" + itemName + "\" to Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            UpdateCheckouts();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void SearchByItemTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateWithSearchTerms();
        }

        private void SearchByEventTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateWithSearchTerms();
        }
    }
}
