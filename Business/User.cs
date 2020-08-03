using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechLibrary.Business
{
  public class User
    {
        public string UserName { get; set; }
        public string Passwd { get; set; }

        public User()
        {

        }
        public User( string _username, string _passwd)
        {
            this.UserName = _username;
            this.Passwd = _passwd;
        }


    }
}
