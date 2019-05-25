using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAPIS
{
    public partial class SearchItems : Form
    {
        public static int itemID;
        public static string itemName;
        public static int itemTotalQuantity;
        public static object itemPic;
        public static string itemNote;

        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public SearchItems()
        {
            InitializeComponent();
        }

        public void UpdateItems()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ITEM_INVENTORY";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    sqlConnection.Close();

                    SearchItemsDataGridView.DataSource = dataTable;
                    SearchItemsDataGridView.Columns[4].Visible = false;

                    if (SearchItemsDataGridView.Rows.Count == 0)
                    {
                        DeleteItemButton.Enabled = false;
                        EditItemButton.Enabled = false;
                        ItemPictureBox.Image = null;
                    }
                    else if ((SearchItemsDataGridView.Rows.Count != 0) && (SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value == DBNull.Value))
                    {
                        DeleteItemButton.Enabled = true;
                        EditItemButton.Enabled = true;
                        ItemPictureBox.Image = null;
                    }
                    else
                    {
                        var image = SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value;
                        MemoryStream ms = new MemoryStream((byte[])image);

                        ItemPictureBox.Image = Image.FromStream(ms);
                        DeleteItemButton.Enabled = true;
                        EditItemButton.Enabled = true;
                    }
                }
            }
        }

        private void SearchItems_Load(object sender, EventArgs e)
        {
            UpdateItems();
        }

        #region Button Event Handlers
        private void EditItemButton_Click(object sender, EventArgs e)
        {
            EditItem edit = new EditItem();

            try
            {
                itemID = int.Parse(SearchItemsDataGridView[0, SearchItemsDataGridView.CurrentRow.Index].Value.ToString());
                itemName = SearchItemsDataGridView[1, SearchItemsDataGridView.CurrentRow.Index].Value.ToString();
                itemTotalQuantity = int.Parse(SearchItemsDataGridView[2, SearchItemsDataGridView.CurrentRow.Index].Value.ToString());
                itemPic = SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value;
                itemNote = SearchItemsDataGridView[5, SearchItemsDataGridView.CurrentRow.Index].Value.ToString();

                edit.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateItems();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(SearchItemsDataGridView[0, SearchItemsDataGridView.CurrentRow.Index].Value.ToString());
                itemName = SearchItemsDataGridView[1, SearchItemsDataGridView.CurrentRow.Index].Value.ToString();

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ITEM_INVENTORY WHERE Item_number = @itemID";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        DialogResult result = MessageBox.Show("Are you sure you want to delete the item \"" + itemName + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                command.Parameters.AddWithValue("@itemID", id);

                                sqlConnection.Open();
                                command.ExecuteNonQuery();
                                sqlConnection.Close();

                                MessageBox.Show("Successfully deleted \"" + itemName + "\" from Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                UpdateItems();
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
                                    MessageBox.Show("Could not delete \"" + itemName + "\" from Inventory. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                UpdateItems();
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ITEM_INVENTORY WHERE Item_name LIKE @itemName";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@itemName", "%" + SearchTextBox.Text + "%");

                        sqlConnection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        sqlConnection.Close();

                        SearchItemsDataGridView.DataSource = dataTable;
                        SearchItemsDataGridView.Columns[4].Visible = false;

                        if (SearchItemsDataGridView.Rows.Count == 0)
                        {
                            DeleteItemButton.Enabled = false;
                            EditItemButton.Enabled = false;
                            ItemPictureBox.Image = null;
                        }
                        else if ((SearchItemsDataGridView.Rows.Count != 0) && (SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value == DBNull.Value))
                        {
                            DeleteItemButton.Enabled = true;
                            EditItemButton.Enabled = true;
                            ItemPictureBox.Image = null;
                        }
                        else
                        {
                            var image = SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value;
                            MemoryStream ms = new MemoryStream((byte[])image);

                            ItemPictureBox.Image = Image.FromStream(ms);
                            DeleteItemButton.Enabled = true;
                            EditItemButton.Enabled = true;
                        }
                    }
                }
            }
        }

        private void SearchItemsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (SearchItemsDataGridView.CurrentRow != null)
                {
                    var image = SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value;

                    if (image == DBNull.Value)
                    {
                        ItemPictureBox.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream((byte[])image);
                        ItemPictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
