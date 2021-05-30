using Manage_Building.controller;
using Manage_Building.model;
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


        private readonly RoomController roomController;


        public FormManageRooms()
        {
            InitializeComponent();
            roomController = new RoomController();
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

        private void loadToList()
        {
            List<Room> rooms = roomController.GetAllRooms();
            dataGridView1.DataSource = rooms;
        }

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            loadToList();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("cell is clicked");
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[0].Value.ToString();
            cmbCapacity.SelectedItem = row.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ClearSelection(object sender, EventArgs e)
        {

        }

        private void DeleteSelection(object sender, EventArgs e)
        {
            int updateCount = roomController.DeleteRoom(int.Parse(textBox1.Text));

            if (updateCount > 0)
            {
                MessageBox.Show("Room succesfully deleted");
                loadToList();
                clearFields();
            }

            else
                MessageBox.Show("Room delete failed");

        }

        private void UpdateSelection(object sender, EventArgs e)
        {
            Room room = new Room()
            {
                Id = int.Parse(textBox1.Text),
                name = textBox2.Text,
                Capacity = int.Parse(cmbCapacity.SelectedItem.ToString())
            };
            if (radioButton1.Checked)
            {
                room.type = 1;
            }

            if (radioButton2.Checked)
            {
                room.type = 2;
            }
            int updateCount = roomController.UpdateRoom(room);

            if (updateCount > 0)
                MessageBox.Show("Room succesfully updated");
            else
                MessageBox.Show("Room update failed");
        }
    }
}
