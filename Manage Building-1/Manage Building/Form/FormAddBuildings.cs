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
    public partial class FormAddBuildings : Form
    {

        //private ConnectorClass con = new ConnectorClass();
        private readonly BuildingController buildingController;

        public FormAddBuildings()
        {
            InitializeComponent();
            buildingController = new BuildingController();
        }

        private void btnManageBuildings_Click(object sender, EventArgs e)
        {
            FormManageBuildings formManageBuildings = new FormManageBuildings();
            this.Hide();
            formManageBuildings.Show();

          
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void FormAddBuildings_Load(object sender, EventArgs e)
        {
            cmbNumberofRooms.SelectedIndex = 0;
        }

        private void addNewBuilding(object sender , EventArgs e)
        {
            Building building = new Building()
            {
                name = d.Text,
                RoomsCount = int.Parse(cmbNumberofRooms.Text)
            };
            int buldingId = buildingController.AddNewBuilding(building);
            if(buldingId > 0)
            {
                labelId.Text = buldingId.ToString();
                MessageBox.Show("Building added succesfully");
            }
            else
            {
                MessageBox.Show("Error occured in adding the building");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con.OpenConection();
            //bool result = con.executequery("delete from building where building_id = " + textBox2.Text);
            if (true)
            {
                MessageBox.Show("Record Delete successfilly");
            }
            else
            {
                MessageBox.Show("Record Insert Error");
            }
            clearFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            d.Clear();
            //textBox2.Clear();
            cmbNumberofRooms.SelectedIndex = 0;
        }

        private void cmbNumberofRooms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
