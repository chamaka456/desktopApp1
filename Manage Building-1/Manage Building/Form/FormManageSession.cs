using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Manage_Building.controller;
using Manage_Building.model;

namespace Manage_Building
{
    public partial class FormManageSession : Form
    {
       // private ConnectorClass con = new ConnectorClass();

        private readonly SessionController sessionController;


        public FormManageSession()
        {
            InitializeComponent();
            sessionController = new SessionController();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void FormManageSession_Load(object sender, EventArgs e)
        {
            LoadInitialData();
        }

        private void LoadInitialData()
        {
            List<Session> session = sessionController.getAllSessions();
            dataGridView1.DataSource = session;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bool result = con.executequery("insert into mangesesion (Session_no,Room_id,Reson)values('" + cmbSession.Text + "','" + cmbRooms.Text + "','" + textBox1.Text + "')");
            //if (result)
            //{
            //    MessageBox.Show("Record Updated successfilly");
            //}
            //else
            //{
            //    MessageBox.Show(" Error");
            //}
            clearFields();
        }

        private void clearFields()
        {
            //cmbRooms.SelectedIndex = 0;
            //cmbSession.SelectedIndex = 0;
            //textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bool result = con.executequery("delete from mangesesion where room_id =" + cmbRooms.Text);
            //if (result)
            //{
            //    MessageBox.Show("Record deleted successfilly");
            //}
            //else
            //{
            //    MessageBox.Show(" Error");
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("cell is clicked");
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            sestext.Text = row.Cells[0].Value.ToString();
            romtxt.SelectedItem = row.Cells[6].Value.ToString();
            lectxt.SelectedItem = row.Cells[4].Value.ToString();
            tagtxt.SelectedItem = row.Cells[3].Value.ToString();
            gptxt.SelectedItem = row.Cells[5].Value.ToString();
            durtxt.Text = row.Cells[2].Value.ToString();
            counttxt.Text = row.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormViewManageSession formMain = new FormViewManageSession();
            this.Hide();
            formMain.Show();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            Session session = new Session()
            {
                Id = int.Parse(sestext.Text),
                roomId = int.Parse(romtxt.Text),
                lectureId = int.Parse(lectxt.SelectedItem.ToString()),
                tag = tagtxt.SelectedItem.ToString(),
                groupId = int.Parse(gptxt.SelectedItem.ToString()),
                count = int.Parse(counttxt.Text),
                duaration = int.Parse(durtxt.Text)
            };
            int updateCount = sessionController.UpdateSession(session);

            if (updateCount > 0)
                MessageBox.Show("Session succesfully updated");
            else
                MessageBox.Show("Session update failed");
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int updateCount = sessionController.DeleteSession(int.Parse(sestext.Text));

            if (updateCount > 0)
            {
                MessageBox.Show("Session succesfully deleted");
                LoadInitialData();
                clearFields();
            }

            else
                MessageBox.Show("Session delete failed");
        }
    }
}
