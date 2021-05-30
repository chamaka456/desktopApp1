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

        public FormAllocateSessions()
        {
            InitializeComponent();
            sessionController = new SessionController();
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


        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            //con.OpenConection();
            //bool result = con.executequery("insert into sesion(Lecture_No,Subject_No,Tag,Session_No,Group_No,Room_Id)values(" + cmbLecture.Text + "," + cmbSubject.Text + "," + cmbTag.Text + "," + cmbSession.Text + "," + cmbGroup.Text + "," + textBox1.Text + ")");
            //if (result)
            //{
            //    MessageBox.Show("Record Inserted successfilly");
            //}
            //else
            //{
            //    MessageBox.Show("Record Insert Error");
            //}
            //clearFields();
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
