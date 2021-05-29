﻿using Manage_Building.controller;
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

        private void FormManageRooms_Load(object sender, EventArgs e)
        {
            List<Room> rooms = roomController.GetAllRooms();
            dataGridView1.DataSource = rooms;
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

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ClearSelection(object sender, EventArgs e)
        {

        }

        private void UpdateSelection(object sender, EventArgs e)
        {

        }

        private void DeleteSelection(object sender, EventArgs e)
        {

        }
    }
}
