using System;
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                studentImage.Image = new Bitmap(openFileDialog.FileName);
            }
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

            if (formState)
            {
                MessageBox.Show("Query Will Run");

            }
            else
            {
                MessageBox.Show("Query Will NOT Run");
            }
        }

        private bool formValidate()
        {
            bool formState = true;
            // Checking if form fields are in valid state
            if(HasNumber(firstName.Text)) {
                lblFirstName.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFirstName.ForeColor = Color.White;
            }
            
            if (HasNumber(lastName.Text))
            {
                lblLastName.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblLastName.ForeColor = Color.White;
            }

            if (HasLetter(studentCNIC.Text))
            {
                lblStudentCNIC.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblStudentCNIC.ForeColor = Color.White;
            }

            if (HasLetter(contactNumber.Text))
            {
                lblContactNumber.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblContactNumber.ForeColor = Color.White;
            }

            if (HasNumber(city.Text))
            {
                lblCity.ForeColor = Color.Red;
                formState = false;
            }
            else
            {   
                lblCity.ForeColor = Color.White;
            }


            if (HasNumber(fatherName.Text))
            {
                lblFatherName.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFatherName.ForeColor = Color.White;
            }

            if (HasNumber(motherName.Text))
            {
                lblMotherName.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblMotherName.ForeColor = Color.White;
            }

            if (HasLetter(income.Text))
            {
                lblincome.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblincome.ForeColor = Color.White;
            }

            if (HasNumber(fatherProfession.Text))
            {
                lblFatherProfession.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFatherProfession.ForeColor = Color.White;
            }

            if (HasNumber(motherProfession.Text))
            {
                lblMotherProfession.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblMotherProfession.ForeColor = Color.White;
            }

            if (HasLetter(fatherCNIC.Text))
            {
                lblFatherCNIC.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFatherCNIC.ForeColor = Color.White;
            }

            if (HasLetter(motherCNIC.Text))
            {
                lblMotherCNIC.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblMotherCNIC.ForeColor = Color.White;
            }

            if (HasLetter(fatherContact.Text))
            {
                lblFatherContact.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblFatherContact.ForeColor = Color.White;
            }

            if (HasLetter(motherContact.Text))
            {
                lblMotherContact.ForeColor = Color.Red;
                formState = false;
            }
            else
            {
                lblMotherContact.ForeColor = Color.White;
            }

            if (HasLetter(siblings.Text))
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

        private bool HasNumber(string yourString)
        {
            if (yourString == "")
                return true;
            else
                return yourString.Any(ch => !char.IsLetter(ch));
        }

        private bool HasLetter(string yourString)
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
