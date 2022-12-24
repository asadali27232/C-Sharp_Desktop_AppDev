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

namespace WindowsFormsApp1
{
    public partial class SAM : Form
    {
        public SAM()
        {
            InitializeComponent();
            pages.SetPage("Home");
            todayDateSideMenu.Value = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source=DESKTOP-CG5S6II\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM db_project.dbo.udf_get_students_grid()", con))
                    {
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);




                    }
                }
            }
            catch (Exception ex)
            {
                Error box = new Error(ex.Message);
                box.Show();
            }

            dgvStudents.DataSource = dt;

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
            lblCurrentTab.Text = "Home";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pages.SetPage("Dashboard");
            lblCurrentTab.Text = "Dashboard";
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            pages.SetPage("Students");
            lblCurrentTab.Text = "Students";
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            pages.SetPage("Attendance");
            lblCurrentTab.Text = "Attendance";
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            pages.SetPage("Classes");
            lblCurrentTab.Text = "Classes";
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
            lblCurrentTab.Text = "Home";
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            pages.SetPage("Home");
            lblCurrentTab.Text = "Home";
        }

        private void bunifuIconButton3_Click(object sender, EventArgs e)
        {
            pages.SetPage("Dashboard");
            lblCurrentTab.Text = "Dashboard";
        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {
            pages.SetPage("Dashboard");
            lblCurrentTab.Text = "Dashbaord";
        }

        private void bunifuIconButton2_Click_1(object sender, EventArgs e)
        {
            pages.SetPage("Students");
            lblCurrentTab.Text = "Students";
        }

        private void bunifuLabel1_Click_2(object sender, EventArgs e)
        {
            pages.SetPage("Students");
            lblCurrentTab.Text = "Students";
        }

        private void bunifuIconButton4_Click(object sender, EventArgs e)
        {
            pages.SetPage("Attendance");
            lblCurrentTab.Text = "Attendance";
        }

        private void bunifuLabel12_Click(object sender, EventArgs e)
        {
            pages.SetPage("Attendance");
            lblCurrentTab.Text = "Attendance";
        }

        private void bunifuIconButton5_Click(object sender, EventArgs e)
        {
            pages.SetPage("Classes");
            lblCurrentTab.Text = "Classes";
        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {
            pages.SetPage("Classes");
            lblCurrentTab.Text = "Classes";
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


        private void btnlogin_Click(object sender, EventArgs e)
        {
            string userID = "asad";
            string pass = "asad";

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
            }
            else
            {
                Error err = new Error("Wrong credentials! Please try again.");
                err.Show();
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
            pages.SetPage("Home");
            lblCurrentTab.Text = "Home";
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

        private void lblWrongPass_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_KeyDown(object sender, EventArgs e)
        {
        
        }

        private void todayDateSideMenu_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pages_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var id = dgvStudents.Rows[e.RowIndex].Cells[0].Value;
                StudentDetail studentDetail = new StudentDetail(id.ToString());
                studentDetail.Show();
            }
        }

        private void titleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleBar_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
