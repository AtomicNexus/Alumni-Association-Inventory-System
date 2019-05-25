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
    public partial class EditOtherItemInfo : Form
    {
        private const string connectionString = @"Data Source=JOEANTHONY\FDBSQL;Initial Catalog=AAPInventoryDB;User ID=sa;Password=08181997";

        public EditOtherItemInfo()
        {
            InitializeComponent();
        }

        private void EditOtherItemInfo_Load(object sender, EventArgs e)
        {
            ItemIDTextBox.Text = SearchItems.itemID.ToString();
            ItemNameTextBox.Text = SearchItems.itemName;
            if (SearchItems.itemPic == DBNull.Value)
            {
                ItemPictureBox.Image = null;
                DeleteItemPicButton.Enabled = false;
            }
            else
            {
                MemoryStream ms = new MemoryStream((byte[])SearchItems.itemPic);
                ItemPictureBox.Image = Image.FromStream(ms);
            }
            ItemNoteTextBox.Text = SearchItems.itemNote;
        }

        private void OpenImageFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            ItemPictureBox.ImageLocation = OpenImageFileDialog.FileName;
        }

        #region Button Event Handlers
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

        private void DeleteItemPicButton_Click(object sender, EventArgs e)
        {
            ItemPictureBox.Image = null;
            DeleteItemPicButton.Enabled = false;
            ItemPicFileNameTextBox.Clear();
            ItemPicFilePathTextBox.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string sqlQuery = "UPDATE ITEM_INVENTORY SET Item_name = @updatedName, Item_picture = @updatedPic, Item_note = @updatedNote WHERE Item_number = @itemID";

                using (SqlCommand command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    try
                    {
                        if (String.IsNullOrEmpty(ItemNameTextBox.Text))
                        {
                            command.Parameters.AddWithValue("@updatedName", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@updatedName", ItemNameTextBox.Text);
                        }

                        if (String.IsNullOrEmpty(ItemPicFilePathTextBox.Text) && (ItemPictureBox.Image == null))
                        {
                            SqlParameter itemPicParam = new SqlParameter("@updatedPic", SqlDbType.Image);
                            itemPicParam.Value = DBNull.Value;

                            command.Parameters.Add(itemPicParam);
                        }
                        else if ((!String.IsNullOrEmpty(ItemPicFilePathTextBox.Text)) && (!(ItemPictureBox.Image == null)))
                        {
                            Image image = Image.FromFile(ItemPicFilePathTextBox.Text);
                            MemoryStream ms = new MemoryStream();
                            image.Save(ms, image.RawFormat);

                            SqlParameter itemPicParam = new SqlParameter("@updatedPic", SqlDbType.Image);
                            itemPicParam.Value = ms.ToArray();
                            command.Parameters.Add(itemPicParam);
                        }
                        else
                        {
                            SqlParameter itemPicParam = new SqlParameter("@updatedPic", SqlDbType.Image);

                            itemPicParam.Value = SearchItems.itemPic;
                            command.Parameters.Add(itemPicParam);
                        }

                        if (String.IsNullOrEmpty(ItemNoteTextBox.Text))
                        {
                            command.Parameters.AddWithValue("@updatedNote", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@updatedNote", ItemNoteTextBox.Text);
                        }
                        command.Parameters.AddWithValue("@itemID", SearchItems.itemID);

                        sqlConnection.Open();
                        command.ExecuteNonQuery();
                        sqlConnection.Close();

                        SearchItems.itemName = ItemNameTextBox.Text;
                        if (String.IsNullOrEmpty(ItemPicFilePathTextBox.Text) && (ItemPictureBox.Image == null))
                        {
                            SearchItems.itemPic = DBNull.Value; ;
                        }
                        else if ((!String.IsNullOrEmpty(ItemPicFilePathTextBox.Text)) && (!(ItemPictureBox.Image == null)))
                        {
                            Image image = Image.FromFile(ItemPicFilePathTextBox.Text);
                            MemoryStream ms = new MemoryStream();
                            image.Save(ms, image.RawFormat);

                            SearchItems.itemPic = ms.ToArray();
                        }
                        else
                        {
                            // Do nothing.
                        }
                        SearchItems.itemNote = ItemNoteTextBox.Text;

                        MessageBox.Show("Successfully modified \"" + ItemNameTextBox.Text + "\" information in Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not modify \"" + ItemNameTextBox.Text + "\" information in Inventory. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItemNameTextBox.Text))
            {
                EditButton.Enabled = false;
            }
            else
            {
                EditButton.Enabled = true;
            }
        }
    }
}
