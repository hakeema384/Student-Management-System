using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace XYZCampusSMS
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private bool isValid()
        {
            if(txtStdUname.Text.TrimStart()==string.Empty)
            {
                MessageBox.Show("Enter valid username");
                return false;
            }
            else if(txtStdPword.Text.TrimStart()==string.Empty)
            {
                MessageBox.Show("Enter valid password");
                return false;
            }
            return true;
        }

        private void btnStdLogin_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hakee\OneDrive\Desktop\Sneakers\Documents\XYZ_SMS.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    string query = "select * from data where uname = '" + txtStdUname.Text + "'AND pword = '" + txtStdPword.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count == 1)
                    {
                        StudentViewPage w = new StudentViewPage();
                        this.Hide();
                        w.Show();
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
