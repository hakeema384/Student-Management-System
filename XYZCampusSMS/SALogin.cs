using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XYZCampusSMS
{
    public partial class SALogin : Form
    {
        public SALogin()
        {
            InitializeComponent();
        }

        private void btnSALogin_Click(object sender, EventArgs e)
        {

            if (txtSAUname.Text == "")
            {
                MessageBox.Show("Username Field is Empty");
            }
            else if (txtSAPword.Text == "")
            {
                MessageBox.Show("Password Field is Empty");
            }
            else if (txtSAUname.Text != "xyzmanagement")
            {
                MessageBox.Show("Login Failed, Check your username again.");
            }
            else if (txtSAPword.Text != "xyz123ww")
            {
                MessageBox.Show("Login Failed, Check your password again.");
            }
            else
            {
                this.Hide();
                LoginInfo pd = new LoginInfo();
                pd.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
