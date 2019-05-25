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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void AboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.ShowDialog();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory i = new Inventory();

            i.ShowDialog();
        }

        private void EventsButton_Click(object sender, EventArgs e)
        {
            Events ev = new Events();

            ev.ShowDialog();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();

            reports.ShowDialog();
        }

        private void CheckoutReturnButton_Click(object sender, EventArgs e)
        {
            CheckoutOrReturn check = new CheckoutOrReturn();

            check.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
