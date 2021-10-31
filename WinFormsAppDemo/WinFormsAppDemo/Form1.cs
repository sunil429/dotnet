using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //UserName - admin and password - 123
            // txtUserName.Text ---- username 
            // txtPassword.Text ----- password

            //lblMsg.Text = "Valid user";
            if(txtUserName.Text == "admin" & txtUserPassword.Text =="123")
            {
                lblMsg.Text = "Valid User";
            }

            else
            {
                lblMsg.Text = "Invalid UserName or Password";
            }
        }
    }
}
