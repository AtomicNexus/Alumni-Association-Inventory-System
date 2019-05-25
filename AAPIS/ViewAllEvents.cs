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
    public partial class ViewAllEvents : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public ViewAllEvents()
        {
            InitializeComponent();
        }

        private void ViewAllEvents_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT Event_name FROM EVENT";

                using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable eventTable = new DataTable();

                    dataAdapter.Fill(eventTable);
                    EventsGridView.DataSource = new BindingSource(eventTable, null);
                }       
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
