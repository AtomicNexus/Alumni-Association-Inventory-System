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
    public partial class AddItem : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            AddButton.Enabled = false;
        }

        #region Button Event Handlers
        private void RandomIntButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            ItemIDTextBox.Text = random.Next(1000, 10000).ToString();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenImageFileDialog.Filter = "JPEG Image|*.jpg;*.jpeg|PNG Image|*.png";
            OpenImageFileDialog.InitialDirectory = "c:\\";
            OpenImageFileDialog.Title = "Select Image";

            if (OpenImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                ItemPicFileNameTextBox.Text = OpenImageFileDialog.SafeFileName;
                ItemPicFilePathTextBox.Text = OpenImageFileDialog.FileName;
            }
        }   

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string sqlQuery = "INSERT INTO ITEM_INVENTORY(Item_number, Item_name, Item_total_quantity_available, Item_total_quantity_in_use, Item_picture, Item_note) " +
                                  "VALUES(@itemId, @itemName, @itemTotalQuantity, @itemQuantityInUse, @itemPic, @itemNote)";

                using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@itemID", int.Parse(ItemIDTextBox.Text));

                        if (String.IsNullOrEmpty(ItemNameTextBox.Text))
                        {
                            command.Parameters.AddWithValue("@itemName", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@itemName", ItemNameTextBox.Text);
                        }

                        command.Parameters.AddWithValue("@itemTotalQuantity", Convert.ToInt32(ItemQuantityUpDown.Value));
                        command.Parameters.AddWithValue("@itemQuantityInUse", 0);

                        if (String.IsNullOrEmpty(ItemPicFilePathTextBox.Text))
                        {
                            SqlParameter itemPicParam = new SqlParameter("@itemPic", SqlDbType.Image);
                            itemPicParam.Value = DBNull.Value;

                            command.Parameters.Add(itemPicParam);
                        }
                        else
                        {
                            Image image = Image.FromFile(ItemPicFilePathTextBox.Text);
                            MemoryStream ms = new MemoryStream();
                            image.Save(ms, image.RawFormat);

                            SqlParameter itemPicParam = new SqlParameter("@itemPic", SqlDbType.Image);
                            itemPicParam.Value = ms.ToArray();
                            command.Parameters.Add(itemPicParam);
                        }

                        if (String.IsNullOrEmpty(ItemNoteTextBox.Text))
                        {
                            command.Parameters.AddWithValue("@itemNote", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@itemNote", ItemNoteTextBox.Text);
                        }

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();

                        MessageBox.Show("Successfully added \"" + ItemNameTextBox.Text + "\" to Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not add \"" + ItemNameTextBox.Text + "\" to Inventory. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Add Button Enablers/Disablers
        private void ItemIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemIDTextBox.Text) || string.IsNullOrWhiteSpace(ItemNameTextBox.Text))
            {
                AddButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
            }
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemNameTextBox.Text) || string.IsNullOrWhiteSpace(ItemIDTextBox.Text))
            {
                AddButton.Enabled = false;
            }
            else
            {
                AddButton.Enabled = true;
            }
        }
        #endregion

        private void OpenImageFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            ItemPictureBox.ImageLocation = OpenImageFileDialog.FileName;
        }

        /*private void ItemNoteTextBox_MouseClick(object sender, EventArgs e)
        {
            if(ItemNoteTextBox.Text == "-- Enter an optional item note here --")
            {
                ItemNoteTextBox.Clear();
            }
        }*/
    }
}
