﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Manage_Building
{
    public partial class FormManageSession : Form
    {
        private ConnectorClass con = new ConnectorClass();

        public FormManageSession()
        {
            InitializeComponent();
            con.OpenConection();
            try
            {
               
                    SqlDataReader reader = con.DataReader("select room_id from room");
                    while (reader.Read())
                    {
                        //cmbRooms.Items.Add(reader.GetValue(0).ToString());

                    }
                    reader.Close();

                    SqlDataReader reader2 = con.DataReader("select Session_no from sesion");
                    while (reader2.Read())
                    {
                       //cmbSession.Items.Add(reader2.GetValue(0).ToString());

                    }


            }
            catch (Exception e)
            {
                MessageBox.Show("Error"+e.Message);
            }



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
    }
}
