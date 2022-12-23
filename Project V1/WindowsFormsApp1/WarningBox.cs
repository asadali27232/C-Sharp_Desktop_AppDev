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
    public partial class WarningBox : Form
    {
        public WarningBox(string myMsg)
        {
            InitializeComponent();
            lblWrong.Text = myMsg;
        }

        private void btnClearAdminForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
