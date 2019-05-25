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
    public partial class EditItemQuantity : Form
    {
        public EditItemQuantity()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void IncreaseQuantityButton_Click(object sender, EventArgs e)
        {
            IncreaseItemQuantity incQuantity = new IncreaseItemQuantity();

            incQuantity.ShowDialog();
        }

        private void DecreaseQuantityButton_Click(object sender, EventArgs e)
        {
            DecreaseItemQuantity decQuantity = new DecreaseItemQuantity();

            decQuantity.ShowDialog();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
