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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void studentImage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClearAdminForm_Click(object sender, EventArgs e)
        {
            firstName.Text = "";
            lastName.Text = "";
            studentCNIC.Text = "";
            dateOfBirth.Text = "";
            contactNumber.Text = "";
            email.Text = "";
            streetAddress.Text = "";
            town.Text = "";
            city.Text = "";
            fatherName.Text = "";
            fatherCNIC.Text = "";
            fatherContact.Text = "";
            fatherProfession.Text = "";
            motherName.Text = "";
            motherCNIC.Text = "";
            motherContact.Text = "";
            motherProfession.Text = "";
            income.Text = "";
            siblings.Text = "";
            
        }

        private void btnLeftExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelAddstudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFemale_Click(object sender, EventArgs e)
        {
            
        }

        private void lblMale_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Checking if form fields are in valid state
            bool formState = formValidate();
            string conStr = "Data Source=DESKTOP-CG5S6II\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            if (formState)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(conStr))
                    {
                        using (SqlCommand cmd = new SqlCommand("db_project.dbo.sp_register_student", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@first_name", firstName.Text);
                            cmd.Parameters.AddWithValue("@last_name", lastName.Text);
                            cmd.Parameters.AddWithValue("@cnic", studentCNIC.Text);
                            cmd.Parameters.AddWithValue("@date_of_birth", dateOfBirth.Text);
                            cmd.Parameters.AddWithValue("@gender", rdbMale.Checked? "Male":"Female");
                            cmd.Parameters.AddWithValue("@contact_number", contactNumber.Text);

                            cmd.Parameters.AddWithValue("@street_address", streetAddress.Text);
                            cmd.Parameters.AddWithValue("@town", town.Text);
                            cmd.Parameters.AddWithValue("@email", email.Text);
                            cmd.Parameters.AddWithValue("@city", city.Text);

                            cmd.Parameters.AddWithValue("@father_name", fatherName.Text);
                            cmd.Parameters.AddWithValue("@father_cnic", fatherCNIC.Text);
                            cmd.Parameters.AddWithValue("@father_contact", fatherContact.Text);
                            cmd.Parameters.AddWithValue("@father_profession", fatherProfession.Text);

                            cmd.Parameters.AddWithValue("@mother_name", motherName.Text);
                            cmd.Parameters.AddWithValue("@mother_cnic", motherCNIC.Text);
                            cmd.Parameters.AddWithValue("@mother_contact", motherContact.Text);
                            cmd.Parameters.AddWithValue("@mother_profession", motherProfession.Text);

                            cmd.Parameters.AddWithValue("@monthly_income", int.Parse(income.Text));
                            cmd.Parameters.AddWithValue("@siblings", int.Parse(siblings.Text));

                            cmd.Parameters.AddWithValue("@admin_date", DateTime.Now);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            SuccessBox box = new SuccessBox("Student Registered Successfully!");
                            box.Show();

                            btnClearAdminForm_Click(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Error errorBox = new Error(ex.Message);
                    errorBox.Show();
                }
            }
            else
            {
                WarningBox box = new WarningBox("Please fill up all the fields correctly.");
                box.Show();
            }
        }

        private bool formValidate()
        {
            bool formState = true;
            // Checking if form fields are in valid state
            if(NotString(firstName.Text)) {
                lblFirstName.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFirstName.ForeColor = Color.White;
            }
            
            if (NotString(lastName.Text))
            {
                lblLastName.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblLastName.ForeColor = Color.White;
            }

            if (NotNumber(studentCNIC.Text))
            {
                lblStudentCNIC.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblStudentCNIC.ForeColor = Color.White;
            }

            if (NotNumber(contactNumber.Text))
            {
                lblContactNumber.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblContactNumber.ForeColor = Color.White;
            }

            if (NotString(city.Text))
            {
                lblCity.ForeColor = Color.Red;
                formState = false;
            }
            else
            {   
                lblCity.ForeColor = Color.White;
            }


            if (NotString(fatherName.Text))
            {
                lblFatherName.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFatherName.ForeColor = Color.White;
            }

            if (NotString(motherName.Text))
            {
                lblMotherName.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblMotherName.ForeColor = Color.White;
            }

            if (NotNumber(income.Text))
            {
                lblincome.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblincome.ForeColor = Color.White;
            }

            if (NotString(fatherProfession.Text))
            {
                lblFatherProfession.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFatherProfession.ForeColor = Color.White;
            }

            if (NotString(motherProfession.Text))
            {
                lblMotherProfession.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblMotherProfession.ForeColor = Color.White;
            }

            if (NotNumber(fatherCNIC.Text))
            {
                lblFatherCNIC.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFatherCNIC.ForeColor = Color.White;
            }

            if (NotNumber(motherCNIC.Text))
            {
                lblMotherCNIC.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblMotherCNIC.ForeColor = Color.White;
            }

            if (NotNumber(fatherContact.Text))
            {
                lblFatherContact.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFatherContact.ForeColor = Color.White;
            }

            if (NotNumber(motherContact.Text))
            {
                lblMotherContact.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblMotherContact.ForeColor = Color.White;
            }

            if (NotNumber(siblings.Text))
            {
                lblSiblings.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblSiblings.ForeColor = Color.White;
            }

            if (IsEmpty(streetAddress.Text))
            {
                lblAddress.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblAddress.ForeColor = Color.White;
            }

            if (IsEmpty(town.Text))
            {
                lblTown.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblTown.ForeColor = Color.White;
            }

            if (IsNotEmail(email.Text))
            {
                lblEmail.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblEmail.ForeColor = Color.White;
            }

            return formState;
        }

        private bool NotString(string yourString)
        {
            if (yourString == "")
                return true;
            else
                return !yourString.All(ch => char.IsLetter(ch) || ch==' ');
        }

        private bool NotNumber(string yourString)
        {
            if (yourString == "")
                return true;
            else
                return yourString.Any(ch => !char.IsNumber(ch));
        }

        private bool IsEmpty(string yourString)
        {
            if (yourString == "")
                return true;
            else
                return false;
        }

        private bool IsNotEmail(string yourString)
        {
            if (yourString == "")
                return true;

            string[] arr1 = yourString.Split('@');
            string[] arr2 = null;
            if (arr1.Length == 2)
                arr2 = arr1[1].Split('.');

           if (arr1.Length != 2 || arr2.Length != 2)
                return true;
            else
                return false;
        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {
            
        }

        private void guardianContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
