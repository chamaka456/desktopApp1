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

        List<Lecturer> Lecturers;
        List<Subject> Subjects;
        List<Group> Groups;
        List<Room> Rooms;

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
            Lecturers = sessionController.getAllLecturers();
            cmbLecture.Items.Clear();
            cmbLecture.Items.AddRange(Lecturers.Select(l => l.name).ToArray());

            Groups = sessionController.getAllGroups();
            cmbGroup.Items.Clear();
            cmbGroup.Items.AddRange(Groups.Select(g => g.name).ToArray());

            Rooms = roomController.GetAllRooms();
            cmbRooms.Items.Clear();
            cmbRooms.Items.AddRange(Rooms.Select(r => r.name).ToArray());

            Subjects = sessionController.getAllSubjects();
            cmbSubject.Items.Clear();
            cmbSubject.Items.AddRange(Subjects.Select(s => s.name).ToArray());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void submit_click(object sender , EventArgs e)
        {
            Console.WriteLine("submit");
            try
            {
                Session session = new Session()
                {
                    count = int.Parse(txtCount.Text),
                    duaration = int.Parse(txtduration.Text),
                    tag = cmbTag.SelectedItem.ToString()
                };

                Subject selSubject = Subjects.First(s => s.name == cmbSubject.SelectedItem.ToString());
                if (selSubject != null)
                    session.subjectId = selSubject.code;

                Group selGroup = Groups.First(g => g.name == cmbGroup.SelectedItem.ToString());
                if (selGroup != null)
                    session.groupId = selGroup.Id;

                Room selRoom = Rooms.First(r => r.name == cmbRooms.SelectedItem.ToString());
                if (selRoom != null)
                    session.roomId = selRoom.Id;

                Lecturer selLecture = Lecturers.First(l => l.name == cmbLecture.SelectedItem.ToString());
                if (selLecture != null)
                    session.lectureId = selLecture.Id;

                int sessionId = sessionController.AddSession(session);

                if (sessionId > 0)
                {
                    lblSessionId.Text = sessionId.ToString();
                    MessageBox.Show("Session added succesfully");
                }
                else
                {
                    MessageBox.Show("Error occured in adding the session");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                MessageBox.Show("Error Allocating Sessions");
            }
            


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
