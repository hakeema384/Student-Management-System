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
    public partial class LoginInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hakee\OneDrive\Desktop\Sneakers\Documents\XYZ_SMS.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginInfo()
        {
            InitializeComponent();
        }

        private void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from data";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvLoginDetails.DataSource = dt;
            con.Close();

        }

        private void Reset()
        {
            txtSASetUname.Text = "";
            txtSASetPword.Text = "";
        }

        private void btnLoginAdd_Click(object sender, EventArgs e)
        {
            if (txtSASetUname.Text == "" || txtSASetPword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into data values ('" + txtSASetUname.Text + "','" + txtSASetPword.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                MessageBox.Show("Record added successfully");
                Reset();
            }
        }

        private void btnLoginDelete_Click(object sender, EventArgs e)
        {
            if (txtSASetUname.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from data where uname='" + txtSASetUname.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted successfully");
                display_data();
                Reset();

            }
        }

        private void dgvLoginDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSASetUname.Text = dgvLoginDetails.SelectedRows[0].Cells[0].Value.ToString();
            txtSASetPword.Text = dgvLoginDetails.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnLoginEdit_Click(object sender, EventArgs e)
        {
            if (txtSASetUname.Text == "" || txtSASetPword.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update data set pword = @password where uname = @username", con);
                cmd.Parameters.AddWithValue("@username", txtSASetUname.Text);
                cmd.Parameters.AddWithValue("@password", txtSASetPword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully");
                con.Close();
                display_data();
                Reset();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UnameSearch(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from data where uname like '%" + txtSearchUName.Text + "%'", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvLoginDetails.DataSource = dt;
            con.Close();
        }

        private void LoginInfo_Load(object sender, EventArgs e)
        {
            display_data();
        }
        
    }
}
