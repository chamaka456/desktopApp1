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
    public partial class FormManageBuildings : Form
    {
        //private ConnectorClass con = new ConnectorClass();
        private readonly BuildingController buildingController;

        
        public FormManageBuildings()
        {
            InitializeComponent();
            buildingController = new BuildingController();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormAddBuildings formAddBuildings = new FormAddBuildings();
            this.Hide();
            formAddBuildings.Show();

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void FormManageBuildings_Load(object sender, EventArgs e)
        {
            loadToList();
        }

        private void loadToList()
        {
            //con.OpenConection();
            //this.dataGridView1.DataSource = con.ShowDataInGridView("Select * from building"); 
            List<Building> buildings =  buildingController.GetAllBuildings();
            dataGridView1.DataSource = buildings;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("cell is clicked");
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            cmbNumberofRooms.SelectedItem = row.Cells[2].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            txtId.Clear();
            txtName.Clear();
            cmbNumberofRooms.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void UpdateSelection(object sender, EventArgs e)
        {
            Building building = new Building()
            {
                Id = int.Parse(txtId.Text),
                name = txtName.Text,
                RoomsCount = int.Parse(cmbNumberofRooms.SelectedItem.ToString())
            };
            int updateCount = buildingController.UpdateBuilding(building);

            if (updateCount > 0)
                MessageBox.Show("Building succesfully updated");
            else
                MessageBox.Show("Building update failed");
        }

        private void DeleteSelection(object sender, EventArgs e)
        {

            int updateCount = buildingController.DeleteBuilding(int.Parse(txtId.Text));

            if (updateCount > 0)
            {
                MessageBox.Show("Building succesfully deleted");
                loadToList();
                clearFields();
            }
                
            else
                MessageBox.Show("Building delete failed");
        }
    }
}
