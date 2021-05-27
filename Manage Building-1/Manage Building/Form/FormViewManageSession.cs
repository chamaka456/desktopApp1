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


    public partial class FormViewManageSession : Form
    {
        private ConnectorClass con = new ConnectorClass();

        public FormViewManageSession()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void loadToList()
        {
            con.OpenConection();
            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from mangesesion");
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormManageSession formAddBuildings = new FormManageSession();
            this.Hide();
            formAddBuildings.Show();
        }

        private void FormViewManageSession_Load(object sender, EventArgs e)
        {
            loadToList();
        }
    }
}
