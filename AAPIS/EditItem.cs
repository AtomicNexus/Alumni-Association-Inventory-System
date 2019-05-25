using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAPIS
{
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void EditQuantityButton_Click(object sender, EventArgs e)
        {
            EditItemQuantity editQuantity = new EditItemQuantity();

            editQuantity.ShowDialog();
        }

        private void EditOtherInfoButton_Click(object sender, EventArgs e)
        {
            EditOtherItemInfo editOther = new EditOtherItemInfo();

            editOther.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
