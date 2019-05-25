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
    public partial class DecreaseItemQuantity : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public DecreaseItemQuantity()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void DecreaseButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string updateItemQuantityQuery = "UPDATE ITEM_INVENTORY SET Item_total_quantity_available = @updatedQuantity WHERE Item_number = @itemID";
                string addEntryToItemRemoved = "INSERT INTO ITEM_REMOVED(Item_no, Item_name, Item_quantity_removed, Item_date_removed) " +
                                               "VALUES(@itemId, @itemName, @itemQuantityRem, @dateRemoved)";

                using (SqlCommand command1 = new SqlCommand(updateItemQuantityQuery, sqlConnection))
                {
                    try
                    {
                        if (Convert.ToInt32(DecreaseNumericUpDown.Value) > SearchItems.itemTotalQuantity)
                        {
                            throw new Exception("Value to decrease quantity by cannot be greater than total quantity available.");
                        }
                        else
                        {
                            command1.Parameters.AddWithValue("@updatedQuantity", SearchItems.itemTotalQuantity - Convert.ToInt32(DecreaseNumericUpDown.Value));
                        }
                        command1.Parameters.AddWithValue("@itemID", SearchItems.itemID);

                        sqlConnection.Open();
                        command1.ExecuteNonQuery();
                        sqlConnection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }

                using (SqlCommand command2 = new SqlCommand(addEntryToItemRemoved, sqlConnection))
                {
                    try
                    {
                        command2.Parameters.AddWithValue("@itemID", SearchItems.itemID);
                        command2.Parameters.AddWithValue("@itemName", SearchItems.itemName);
                        if (Convert.ToInt32(DecreaseNumericUpDown.Value) > SearchItems.itemTotalQuantity)
                        {
                            throw new Exception("Value to decrease quantity by cannot be greater than total quantity available.");
                        }
                        else
                        {
                            command2.Parameters.AddWithValue("@itemQuantityRem", Convert.ToInt32(DecreaseNumericUpDown.Value));
                        }
                        command2.Parameters.AddWithValue("@dateRemoved", DateTime.Now.ToString());

                        sqlConnection.Open();
                        command2.ExecuteNonQuery();
                        sqlConnection.Close();

                        if (Convert.ToInt32(DecreaseNumericUpDown.Value) != 1)
                        {
                            MessageBox.Show("Successfully removed " + Convert.ToInt32(DecreaseNumericUpDown.Value).ToString() + " units of \"" + SearchItems.itemName + "\" from Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Successfully removed " + Convert.ToInt32(DecreaseNumericUpDown.Value).ToString() + " unit of \"" + SearchItems.itemName + "\" from Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        SearchItems.itemTotalQuantity -= Convert.ToInt32(DecreaseNumericUpDown.Value);
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
