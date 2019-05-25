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
    public partial class RemovalHistory : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public RemovalHistory()
        {
            InitializeComponent();
        }

        public void UpdateRemovalHistory()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM ITEM_REMOVED";

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    sqlConnection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    sqlConnection.Close();

                    RemovalHistoryDataGridView.DataSource = dataTable;
                }
            }
        }

        private void RemovalHistory_Load(object sender, EventArgs e)
        {
            UpdateRemovalHistory();
        }

        private void SearchByItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchByItemNameTextBox.Text))
            {
                UpdateRemovalHistory();
            }
            else
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ITEM_REMOVED WHERE Item_name LIKE @itemName";

                    using (SqlCommand command = new SqlCommand(query, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@itemName", "%" + SearchByItemNameTextBox.Text + "%");

                        sqlConnection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        sqlConnection.Close();

                        RemovalHistoryDataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
