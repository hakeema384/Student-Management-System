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
    public partial class PCDashboard : Form
    {
        public PCDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentDetails s = new StudentDetails();
            s.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modules md = new Modules();
            md.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lecturer lc = new Lecturer();
            lc.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterStudents rg = new RegisterStudents();
            rg.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
