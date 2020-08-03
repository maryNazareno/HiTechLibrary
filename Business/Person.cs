using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechLibrary.Business
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {

        }

        public Person(string _fname, string _lname)
        {
            this.FirstName = _fname;
            this.LastName = _lname;
        }
    }
}
