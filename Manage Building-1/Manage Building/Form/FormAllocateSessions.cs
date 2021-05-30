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
    public partial class FormAllocateSessions : Form
    {
        private readonly SessionController sessionController;
        private readonly RoomController roomController;

        public FormAllocateSessions()
        {
            InitializeComponent();
            sessionController = new SessionController();
            roomController = new RoomController();
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            FormAllocateSessions formAllocateSessions = new FormAllocateSessions();
            this.Hide();
            formAllocateSessions.Show();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            this.Hide();
            formMain.Show();
        }

        private void FormAllocateSessions_Load(object sender, EventArgs e)
        {
            clearFields();
            LoadDataSet();
        }

        private void LoadDataSet()
        {
            List<Lecturer> lecturers = sessionController.getAllLecturers();
            cmbLecture.Items.Clear();
            cmbLecture.Items.AddRange(lecturers.Select(l => l.name).ToArray());

            List<Group> groups = sessionController.getAllGroups();
            cmbGroup.Items.Clear();
            cmbGroup.Items.AddRange(groups.Select(g => g.name).ToArray());

            List<Room> rooms = roomController.GetAllRooms();
            cmbRooms.Items.Clear();
            cmbRooms.Items.AddRange(rooms.Select(r => r.name).ToArray());

            List<Subject> subjects = sessionController.getAllSubjects();
            cmbSubject.Items.Clear();
            cmbSubject.Items.AddRange(subjects.Select(s => s.name).ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void submit_click(object sender , EventArgs e)
        {
            Console.WriteLine("submit");
        }

        private void clearFields()
        {
            //textBox1.Clear();
            //cmbGroup.SelectedIndex = 0;
            //cmbLecture.SelectedIndex = 0;
            //cmbSession.SelectedIndex = 0;
            //cmbSubject.SelectedIndex = 0;
            //cmbTag.SelectedIndex = 0;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
