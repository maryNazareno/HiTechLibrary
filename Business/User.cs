using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechLibrary.DA;

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

        public void SaveUser(User user)
        {
            UserDA.SaveUser(user);
        }

    }
}
