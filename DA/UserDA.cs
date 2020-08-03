using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using HiTechLibrary.Business;

namespace HiTechLibrary.DA
{
   public static class UserDA
    {
        public static string filePath = Application.StartupPath + @"\UserData.txt";

        public static void SaveUser(User user)
        {
            using (StreamWriter sWriter = new StreamWriter(filePath, true))
            {
                sWriter.WriteLine(user.UserName.ToString() + " | " +
                                  user.Passwd.ToString());
                MessageBox.Show("User data has been succesfully added", "Error",
                                )
            }
        
        }
    }
}
