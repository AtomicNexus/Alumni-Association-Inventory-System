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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItem addItem = new AddItem();

            addItem.ShowDialog();
        }

        private void SearchItemsButton_Click(object sender, EventArgs e)
        {
            SearchItems search = new SearchItems();

            search.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
