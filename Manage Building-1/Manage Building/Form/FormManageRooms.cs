using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manage_Building
{
    public partial class FormManageRooms : Form
    {
        private string roomtypech;
        private ConnectorClass con = new ConnectorClass();


        public FormManageRooms()
        {
            InitializeComponent();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void picBack_Click(object sender, EventArgs e)
        {

            FormAddRooms formAddRooms = new FormAddRooms();
            this.Hide();
            formAddRooms.Show();
        }

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            con.OpenConection();
           
            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from room");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();

        }

        private void clearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            cmbCapacity.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                roomtypech = "Labortary";

            }
            else
            {
                roomtypech = "Lecture Hall";
            }

            con.OpenConection();
            bool result = con.executequery("update room set room_name='" + textBox1.Text + "',capcity='" + cmbCapacity.Text + "',room_type='" + roomtypech + "' where room_id='" + textBox2.Text + "'");
            if (result)
            {
                MessageBox.Show("Record Delete successfilly");
            }
            else
            {
                MessageBox.Show("Record Insert Error");
            }
            clearFields();


            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from room");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            bool result = con.executequery("DELETE FROM room where room_id = '" + textBox2.Text + "'");
            if (result)
            {
                MessageBox.Show("Record Deleted successfilly");
            }
            else
            {
                MessageBox.Show(" Error");
            }
            clearFields();
            this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from room");

        }
    }
}
