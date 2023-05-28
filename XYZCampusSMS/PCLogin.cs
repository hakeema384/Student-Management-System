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
    public partial class PCLogin : Form
    {
        public PCLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPCUname.Text == "")
            {
                MessageBox.Show("Username Field is Empty");
            }
            else if (txtPCPword.Text == "")
            {
                MessageBox.Show("Password Field is Empty");
            }
            else if (txtPCUname.Text != "pcadminxyz")
            {
                MessageBox.Show("Login Failed, Check your username again.");
            }
            else if (txtPCPword.Text != "admin123")
            {
                MessageBox.Show("Login Failed, Check your password again.");
            }
            else
            {
                this.Hide();
                PCDashboard pd = new PCDashboard();
                pd.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
