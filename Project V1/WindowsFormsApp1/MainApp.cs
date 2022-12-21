﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SAM : Form
    {
        public SAM()
        {
            InitializeComponent();
            pages.SetPage("Login");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sideMenuTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            pages.SetPage("Home");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pages.SetPage("Dashboard");
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            pages.SetPage("Students");
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pages.SetPage("Attendance");
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            pages.SetPage("Classes");
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            pages.SetPage("Home");
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            pages.SetPage("Home");
        }

        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            pages.SetPage("Dashboard");
        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {
            pages.SetPage("Dashboard");
        }

        private void bunifuIconButton2_Click_1(object sender, EventArgs e)
        {
            pages.SetPage("Students");
        }

        private void bunifuLabel1_Click_2(object sender, EventArgs e)
        {
            pages.SetPage("Students");
        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            pages.SetPage("Attendance");
        }

        private void bunifuLabel12_Click(object sender, EventArgs e)
        {
            pages.SetPage("Attendance");
        }

        private void bunifuIconButton5_Click(object sender, EventArgs e)
        {
            pages.SetPage("Classes");
        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {
            pages.SetPage("Attendance");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog(this);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            pages.SetPage("Dashboard");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            btnlogin_Click(sender, e);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userID = "asadali27232@gmail.com";
            string pass = "asadali007";

            if (tbUserID.Text == userID && tbPassword.Text == pass)
            {
                lblLoginHeading.Text = "Login Successful";
                lblCurrentTab.Text = "Welcome";
                lblLoginWelcome.Visible = true;

                btnHome.Enabled = true;
                btnDashboard.Enabled = true;
                btnStudents.Enabled = true;
                btnAttendance.Enabled = true;
                btnClasses.Enabled = true;

                btnLogout.Visible = true;
                btnLoginTab.Visible = false;

                btnlogin.Visible = false;
                btnLogoutRight.Visible = true;
                tbUserID.Text = "";
                tbPassword.Text = "";
                tbUserID.Visible = false;
                tbPassword.Visible = false;
            } else
            {
                MessageBox.Show("Wrong Credentials! Please try again");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblLoginHeading.Text = "Login";
            lblCurrentTab.Text = "Login";
            lblLoginWelcome.Visible = false;

            btnHome.Enabled = false;
            btnDashboard.Enabled = false;
            btnStudents.Enabled = false;
            btnAttendance.Enabled = false;
            btnClasses.Enabled = false;

            btnLogout.Visible = false;
            btnLoginTab.Visible = true;

            pages.SetPage("Login");
            btnlogin.Visible = true;
            btnLogoutRight.Visible = false;
            tbUserID.Visible = true;
            tbPassword.Visible = true;
        }

        private void btnLogoutRight_Click(object sender, EventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            btnlogin_Click(sender, e);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            btnLogout_Click(sender, e);
        }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnLeftExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}