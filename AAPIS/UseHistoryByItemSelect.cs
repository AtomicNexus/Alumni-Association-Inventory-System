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
    public partial class UseHistoryByItemSelect : Form
    {
        public static int itemID;

        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public UseHistoryByItemSelect()
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

                    if (SearchItemsDataGridView.Rows.Count == 0 || (SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value == DBNull.Value))
                    {
                        ItemPictureBox.Image = null;
                    }
                    else
                    {
                        var image = SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value;
                        MemoryStream ms = new MemoryStream((byte[])image);

                        ItemPictureBox.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void UseHistoryByItemSelect_Load(object sender, EventArgs e)
        {
            UpdateItems();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchItemsDataGridView_CellMouseDoubleClick(object sender, EventArgs e)
        {
            UseHistoryByItem byItem = new UseHistoryByItem();

            try
            {
                itemID = int.Parse(SearchItemsDataGridView[0, SearchItemsDataGridView.CurrentRow.Index].Value.ToString());

                byItem.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

                        if (SearchItemsDataGridView.Rows.Count == 0 || (SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value == DBNull.Value))
                        {
                            ItemPictureBox.Image = null;
                        }
                        else
                        {
                            var image = SearchItemsDataGridView[4, SearchItemsDataGridView.CurrentRow.Index].Value;
                            MemoryStream ms = new MemoryStream((byte[])image);

                            ItemPictureBox.Image = Image.FromStream(ms);
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
