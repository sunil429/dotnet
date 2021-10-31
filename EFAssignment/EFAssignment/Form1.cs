using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFAssignment.Models;


namespace EFAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            trainingContext db = new trainingContext();
            string UserName = "admin";
            string Password = "123";
            Userdatum user = db.Userdata.SingleOrDefault(u => u.Username == UserName && u.Password == Password);
            if (textUserName.Text == "admin" && textUserPassWord.Text == "123")
            {
                lblMsg.Text = "Valid User";
            }
            else
            {
                lblMsg.Text = "Invalid User";
            }

        }
    }
}
