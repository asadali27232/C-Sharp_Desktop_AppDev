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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class StudentDetail : Form
    {
        public StudentDetail(string detailId)
        {
            InitializeComponent();
            lblID.Text = detailId;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {

        }

        private void StudentDetail_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source=DESKTOP-CG5S6II\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    using (SqlCommand cmd = new SqlCommand($"SELECT * FROM db_project.dbo.udf_get_student_detail({lblID.Text})", con))
                    {
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read()) { 
                            lblName.Text = reader.GetValue(0).ToString();
                            lblCNIC.Text = reader.GetValue(1).ToString();
                            lblDoB.Text = reader.GetValue(2).ToString();
                            lblGnder.Text = reader.GetValue(3).ToString();
                            lblContact.Text = reader.GetValue(4).ToString();
                            lblEmail.Text  = reader.GetValue(5).ToString();
                            lblAddress.Text = reader.GetValue(6).ToString();
                            lblFatherName.Text = reader.GetValue(7).ToString();
                            lblFatherCNIC.Text = reader.GetValue(8).ToString();
                            lblFatherContact.Text = reader.GetValue(9).ToString();
                            lblFatherProfession.Text = reader.GetValue(10).ToString();
                            lblMotherName.Text = reader.GetValue(11).ToString();
                            lblMotherCNIC.Text = reader.GetValue(12).ToString();
                            lblMotherContact.Text = reader.GetValue(13).ToString();
                            lblMotherProfession.Text = reader.GetValue(14).ToString();
                            lblIncome.Text = reader.GetValue(15).ToString();
                            lblSiblings.Text = reader.GetValue(16).ToString();
                            lblAdminDate.Text = reader.GetValue(17).ToString();
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                Error box = new Error(ex.Message);
                box.Show();
            }

            

        }
    }
}
