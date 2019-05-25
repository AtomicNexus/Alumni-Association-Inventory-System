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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void UseHistoryByEventButton_Click(object sender, EventArgs e)
        {
            UseHistoryByEvent byEvent = new UseHistoryByEvent();

            byEvent.ShowDialog();
        }

        private void UseHistoryByItemButton_Click(object sender, EventArgs e)
        {
            UseHistoryByItemSelect byItem = new UseHistoryByItemSelect();

            byItem.ShowDialog();
        }

        private void RemovalHistory_Click(object sender, EventArgs e)
        {
            RemovalHistory removalHistory = new RemovalHistory();

            removalHistory.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
