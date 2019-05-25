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
    public partial class Events : Form
    {
        public Events()
        {
            InitializeComponent();
        }

        #region Button Event Handlers
        private void AddEventButton_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent();

            addEvent.ShowDialog();
        }

        private void RemoveEventButton_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent();

            deleteEvent.ShowDialog();
        }

        private void ViewEventsButton_Click(object sender, EventArgs e)
        {
            ViewAllEvents allEvents = new ViewAllEvents();

            allEvents.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
