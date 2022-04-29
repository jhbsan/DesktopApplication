using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DesktopApplication
{
    public class Employee
    {
        public virtual int EmpID { get; set; }
        public virtual string EmpName { get; set; }
        public virtual DateTime DateofJoining { get; set; }
        public virtual string Department { get; set; }
        public virtual string EmailID { get; set; }
        public virtual decimal Salary { get; set; }

       
    }
}
