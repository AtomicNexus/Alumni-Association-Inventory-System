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
    public partial class CheckoutOrReturn : Form
    {
        public CheckoutOrReturn()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void CheckoutItemButton_Click(object sender, EventArgs e)
        {
            CheckoutItem checkout = new CheckoutItem();

            checkout.ShowDialog();
        }

        private void ViewItemCheckoutButton_Click(object sender, EventArgs e)
        {
            ViewCheckouts viewCheckouts = new ViewCheckouts();

            viewCheckouts.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
