using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSZDashboard.DatabaseEntries;
using TSZDashboard;

namespace TSZDashboard.Forms
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Login.ValidateLogin(txtEmail.Text, txtPassword.Text))
                {
                    //login incorreto
                }

                if (Login.ValidateLogin(txtEmail.Text, txtPassword.Text))
                {
                    //login correto
                }

            }
            catch (Exception crap)
            {
             
            }
        }


    }
}
