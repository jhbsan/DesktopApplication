using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalSystem
{
    public class Student
    {
        //Note: in NHibernate class, all the members must be declared virtual with
        /// <summary>
        /// access specifiers.
        /// </summary>
        public virtual int ID { get; set; }
        public virtual string   LastName { get; set; }
        public virtual string FirstName { get; set; }
}
}
