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
            streetAddres.Text = "";
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
            guardianName.Text = "";
            guardianContact.Text = "";
            
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

            }
        }

        private bool formValidate()
        {
            bool formState = false;
            // Checking if form fields are in valid state
            if(HasNumber(firstName.Text)) {
                firstName.BorderColorIdle = Color.Red;
                formState = false;
            }
            else
            {
                formState = true;
            }

            if (HasLetter(contactNumber.Text))
            {
                contactNumber.BorderColorIdle = Color.Red;
                formState = false;
            }
            else
            {
                formState = true;
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

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
