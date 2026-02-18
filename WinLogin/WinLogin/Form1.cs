using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_CLick_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "janem" && txtPassword.Text == "23207038")
            {
                frmMain main = new frmMain();
                main.ShowDialog();
            }
            else
            {
                lblError.Text = "Invalid username and password.";
            }
        }
    }
}
