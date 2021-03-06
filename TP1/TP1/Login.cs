using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Loginform()
        {

            string username = tbtUsername.Text;
            string password = tbtPassword.Text;

            if (password == "pbo123")
            {
                this.Hide();
                Form menu = new MenuForm();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Password salah!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loginform();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbtUsername.Text = "";
            tbtPassword.Text = "";
        }

        private void tbtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Loginform();
            }
        }
    }
}
