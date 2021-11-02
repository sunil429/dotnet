using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
  public  class Employee
    {

        #region Fields & Properties
        string empName;
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region constructor
        public Employee()
        {
            empName = "sunil";
            address = "mumbai";

        }
        public Employee(string name , string add)
        {
            this.EmpName = name;
            this.Address = add;
        }

        #endregion
        #region method
        public override string ToString()
        {
            return string.Format($"Employee Name : {EmpName} Address :{Address}");
        }

        #endregion
    }
}
