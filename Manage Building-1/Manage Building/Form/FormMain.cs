using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Building
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBuildings_Click(object sender, EventArgs e)
        {
            FormAddBuildings formAddBuildings = new FormAddBuildings();
            this.Hide();
            formAddBuildings.Show();
           
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            FormAddRooms formAddRooms = new FormAddRooms();
            this.Hide();
            formAddRooms.Show();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            FormAllocateSessions formAllocateSessions = new FormAllocateSessions();
            this.Hide();
            formAllocateSessions.Show();
        }

        private void btnManageSession_Click(object sender, EventArgs e)
        {
            FormManageSession formManageSession = new FormManageSession();
            this.Hide();
            formManageSession.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic();
            this.Hide();
            formStatistic.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGenerateTimeTable formStatistic = new FormGenerateTimeTable();
            this.Hide();
            formStatistic.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddLocation formStatistic = new FormAddLocation();
            this.Hide();
            formStatistic.Show();
        }
    }
}
