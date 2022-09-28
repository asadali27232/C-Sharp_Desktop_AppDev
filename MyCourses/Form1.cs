using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyCourses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Address of Server and Database
            string address = "Data Source=DESKTOP-CG5S6II\\SQLEXPRESS;Initial Catalog=data_base;Integrated Security=True";

            // Establish Conecntion
            SqlConnection con = new SqlConnection(address);

            // Open Conenction
            con.Open();

            // Prepare Query
            string query = "insert into tbl_course values ("+tbCourseID.Text+", '"+tbCourseTitle.Text+"', "+tbCourseCrHr.Text+", '"+tbCourseCode.Text+"')";
            
            // Excute Query
            SqlCommand sqlCommand = new SqlCommand(query, con);
            sqlCommand.ExecuteNonQuery();

            // Close Conection
            con.Close();

            MessageBox.Show("Course Added to Database Successfully");

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // Address of the Server and Datbase
            string address = "Data Source=DESKTOP-CG5S6II\\SQLEXPRESS;Initial Catalog=data_base;Integrated Security=True";

            // Establish Connection
            SqlConnection connection = new SqlConnection(address);

            // Open Connection
            connection.Open();

            // Prepare Query
            String query = "insert into tbl_student values ("+tbStudentID.Text+", '"+tbStudentName.Text+"', '"+tbSession.Text+"','"+tbSection.Text+"')";

            // Execute Quey
            SqlCommand cmd = new SqlCommand (query, connection);
            cmd.ExecuteNonQuery();

            // Close Connection
            connection.Close();

            MessageBox.Show("Student added to Database Successfully");
        }
    }
}
