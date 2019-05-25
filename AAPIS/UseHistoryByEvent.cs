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
    public partial class UseHistoryByEvent : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public UseHistoryByEvent()
        {
            InitializeComponent();
        }

        private void UseHistoryByEvent_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string loadEventTable = "SELECT * FROM EVENT";
                string loadUseHistoryTable = "SELECT Item_name, Event_name, Item_quantity_used, Item_use_date " +
                                             "FROM ITEM_INVENTORY JOIN ITEM_USE_HISTORY ON Item_number = Item_num " +
                                                                 "JOIN EVENT ON Event_num = Event_number";

                using (SqlCommand command1 = new SqlCommand(loadEventTable, sqlConnection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command1);
                    DataTable eventTable = new DataTable();

                    dataAdapter.Fill(eventTable);
                    EventDataGridView.DataSource = new BindingSource(eventTable, null);
                }

                using (SqlCommand command2 = new SqlCommand(loadUseHistoryTable, sqlConnection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command2);
                    DataTable eventTable = new DataTable();

                    dataAdapter.Fill(eventTable);
                    ItemUseHistoryDataGridView.DataSource = new BindingSource(eventTable, null);
                }
            }
        }

        private void EventDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string loadUseHistoryTable = "SELECT Item_name, Event_name, Item_quantity_used, Item_use_date " +
                                             "FROM ITEM_INVENTORY JOIN ITEM_USE_HISTORY ON Item_number = Item_num " +
                                                                 "JOIN EVENT ON Event_num = Event_number " +
                                             "WHERE Event_number = @eventID";

                if (EventDataGridView.CurrentRow != null)
                {
                    using (SqlCommand command = new SqlCommand(loadUseHistoryTable, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@eventID", int.Parse(EventDataGridView[0, EventDataGridView.CurrentRow.Index].Value.ToString()));

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable eventTable = new DataTable();

                        dataAdapter.Fill(eventTable);
                        ItemUseHistoryDataGridView.DataSource = new BindingSource(eventTable, null);
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
