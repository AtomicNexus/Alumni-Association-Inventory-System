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
    public partial class UseHistoryByItem : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public UseHistoryByItem()
        {
            InitializeComponent();
        }

        private void UseHistoryByItem_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string loadUseHistoryTable = "SELECT Item_name, Event_name, Item_quantity_used, Item_use_date " +
                                             "FROM ITEM_INVENTORY JOIN ITEM_USE_HISTORY ON Item_number = Item_num " +
                                                                 "JOIN EVENT ON Event_num = Event_number " +
                                             "WHERE Item_number = @itemID";

                using (SqlCommand command = new SqlCommand(loadUseHistoryTable, sqlConnection))
                {
                    command.Parameters.AddWithValue("@itemID", UseHistoryByItemSelect.itemID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable eventTable = new DataTable();

                    dataAdapter.Fill(eventTable);
                    UseHistoryByItemDataGridView.DataSource = new BindingSource(eventTable, null);
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
