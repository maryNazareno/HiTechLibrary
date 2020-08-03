using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechLibrary.Business;

namespace HiTechLibrary.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void mTxtUserName_Enter(object sender, EventArgs e)
        {
            if (mTxtUserName.Text == "UserName")
            {
                mTxtUserName.Text = "";
                mTxtUserName.ForeColor = Color.Black;
            }
        }

        private void mTxtUserName_Leave(object sender, EventArgs e)
        {
            if (mTxtUserName.Text == "")
            {
                mTxtUserName.Text = "Username";
                mTxtUserName.ForeColor = Color.Silver;
            }
        }

        private void mTxtPasswd_Enter(object sender, EventArgs e)
        {
            if (mTxtPasswd.Text == "Password")
            {
                mTxtPasswd.Text = "";
                mTxtPasswd.ForeColor = Color.Black;
            }
        }

        private void mBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mTxtPasswd_Leave(object sender, EventArgs e)
        {
            if (mTxtPasswd.Text == "")
            {
               mTxtPasswd.Text = "Password";
               mTxtPasswd.ForeColor = Color.Silver;
            }
        }
    }
}
