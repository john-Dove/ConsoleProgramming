using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGroup1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String firstName = tbFirstname.Text;
            String lastName = tbLastName.Text;


            //submit to database, process , call an Api to verify
            //MessageBox.Show("You are" + firstName + " " + lastName);
            MessageBox.Show($"You are {firstName} {lastName}");  //interpolation


        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbFirstname.Text = string.Empty;
            tbLastName.Text = string.Empty;
        }
    }
}
