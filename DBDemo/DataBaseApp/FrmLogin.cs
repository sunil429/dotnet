using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace DataBaseApp
{
    public partial class FrmLogin : Form
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;database=training;Integrated Security=True");
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from userdata where username = @name and password= @pwd";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("name", txtUserName.Text);
            command.Parameters.AddWithValue("pwd", txtPassWord.Text);
            //open connection
            connection.Open();
            int count = (int)command.ExecuteScalar();
            connection.Close();

            if (count == 1)
            {
                lblMsg.Text = "valid Username";
                lblMsg.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblMsg.Text = "Invalid UserName or password";
                lblMsg.ForeColor = Color.Red;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
