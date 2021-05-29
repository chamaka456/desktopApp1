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
    public partial class FormAddRooms : Form
    {
        private String roomtypech;
        private String roomId;
        private ConnectorClass con = new ConnectorClass();

        private readonly RoomController roomController;
        private readonly BuildingController buildingController;

        private List<Building> buildings;

        public FormAddRooms()
        {
            InitializeComponent();
            roomController = new RoomController();
            buildingController = new BuildingController();
        }

        private void btnViewAllRooms_Click(object sender, EventArgs e)
        {
            FormManageRooms formManageRooms = new FormManageRooms();
            this.Hide();
            formManageRooms.Show();
        }

        private void FormAddRooms_Load(object sender, EventArgs e)
        {
            cmbCapacity.SelectedIndex = 0;
            buildings = buildingController.GetAllBuildings();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(buildings.Select(b => b.name).ToArray());
        }



   /*    private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(textBox2.Text != "")
                {
                    con.OpenConection();
                    SqlDataReader reader = con.DataReader("select building_id from building where buildng_name=@building_name", textBox2.Text);
                    while (reader.Read())
                    {
                        roomId = reader.GetValue(0).ToString();
                        
                    }

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Error");
            }
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room()
            {
                name = roomname.Text,
                Capacity = int.Parse(cmbCapacity.Text)

            };       

            if (radioButton1.Checked)
            {
                room.type = 1;
            }

            if (radioButton2.Checked)
            {
                room.type = 2;
            }

            Building selectedBuilding = buildings.First(b => b.name == comboBox1.SelectedItem.ToString());
            if(selectedBuilding != null)
            {
                room.BuildingId = selectedBuilding.Id;
            }

            int roomId = roomController.AddNewRoom(room);
            if (roomId > 0)
            {
                labelroomid.Text = roomId.ToString();
                MessageBox.Show("Building added succesfully");
            }
            else
            {
                MessageBox.Show("Error occured in adding the building");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.OpenConection();
            bool result = con.executequery("delete from room where room_name =" + roomname.Text);

            if (result)
            {
                MessageBox.Show("Room deleted successfilly");
            }
            else
            {
                MessageBox.Show(" Error");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
