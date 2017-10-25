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
        Dashboard d = new Dashboard();

        public LoginFrm()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Login.ValidateLogin(txtEmail.Text, txtPassword.Text))
                {
                    //login correto
                    d.Show();
                    this.Hide();
                    
                }
                else
                {
                MessageBox.Show("Login Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (chkRemember.Checked == true)
                {
                    Properties.Settings.Default.Email = txtEmail.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Remember = true;
                }
                else
                {
                    Properties.Settings.Default.Email = null;
                    Properties.Settings.Default.Password = null;
                    Properties.Settings.Default.Remember = false;
                }

                Properties.Settings.Default.Save();

            }
            catch (Exception crap)
            {
                MessageBox.Show(crap.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            txtEmail.Text = Properties.Settings.Default.Email;
            chkRemember.Checked = Properties.Settings.Default.Remember;
        }
    }
}
