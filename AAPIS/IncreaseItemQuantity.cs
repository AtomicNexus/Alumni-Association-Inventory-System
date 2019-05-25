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
    public partial class IncreaseItemQuantity : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public IncreaseItemQuantity()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void IncreaseButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string sqlQuery = "UPDATE ITEM_INVENTORY SET Item_total_quantity_available = @updatedQuantity WHERE Item_number = @itemID";

                using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@updatedQuantity", SearchItems.itemTotalQuantity + Convert.ToInt32(IncreaseNumericUpDown.Value));
                        command.Parameters.AddWithValue("@itemID", SearchItems.itemID);

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();

                        if (Convert.ToInt32(IncreaseNumericUpDown.Value) != 1)
                        {
                            MessageBox.Show("Successfully added " + Convert.ToInt32(IncreaseNumericUpDown.Value).ToString() + " units of \"" + SearchItems.itemName + "\" to Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Successfully added " + Convert.ToInt32(IncreaseNumericUpDown.Value).ToString() + " unit of \"" + SearchItems.itemName + "\" to Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        SearchItems.itemTotalQuantity += Convert.ToInt32(IncreaseNumericUpDown.Value);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
