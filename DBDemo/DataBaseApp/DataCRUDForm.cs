using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace DataBaseApp
{
    public partial class DataCRUDForm : Form
    {

        EmpDataStore datastore = new EmpDataStore(@"server=(localdb)\MSSQLLocalDB;database=training;Integrated Security=True");
        public DataCRUDForm()
        {
            InitializeComponent();
        }

        private void DataCRUDForm_Load(object sender, EventArgs e)
        {
            dgData.DataSource = datastore.GetEmps();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                Emp newEmp = new Emp();
                newEmp.EmpNo = int.Parse(txtEmpno.Text);
                newEmp.EmpName = txtEmpName.Text;
                newEmp.HireDate = Convert.ToDateTime(txtHireDate.Text);
                newEmp.Salary = decimal.Parse(txtSalary.Text);

                int count = datastore.AddEmp(newEmp);

                if (count == 1)
                {
                    MessageBox.Show("Record inserted");
                    dgData.DataSource = datastore.GetEmps();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpno.Clear();
            txtEmpName.Clear();
            txtHireDate.Clear();
            txtSalary.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmpno.Text == string.Empty)
            {
                return;
            }
            try
            {
                int empno = int.Parse(txtEmpno.Text);
                Emp emp = datastore.GetEmpByNo(empno);

                if (emp != null)
                {
                    txtEmpName.Text = emp.EmpName;
                    txtHireDate.Text = emp.HireDate.ToString();
                    txtSalary.Text = emp.Salary.ToString();
                }
                else
                {
                    MessageBox.Show($"Employee by no{empno} not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
} 
