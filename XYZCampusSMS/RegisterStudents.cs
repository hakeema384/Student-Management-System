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
    public partial class RegisterStudents : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hakee\OneDrive\Desktop\Sneakers\Documents\XYZ_SMS.mdf;Integrated Security=True;Connect Timeout=30");
        public RegisterStudents()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            txtRegStdID.Text = "";
            txtRegModID.Text = "";
        }

        private void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from RegisterStd";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvRegisterDetails.DataSource = dt;
            con.Close();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtRegStdID.Text == "" || txtRegModID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into RegisterStd values ('" + txtRegStdID.Text + "','" + txtRegModID.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                MessageBox.Show("Record added successfully");
                Reset();
            }
        }

        private void RegisterStudents_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRegStdID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from RegisterStd where Id='" + txtRegStdID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted successfully");
                display_data();
                Reset();

            }
        }

        private void btnRegStdEdit_Click(object sender, EventArgs e)
        {
            if (txtRegStdID.Text == "" || txtRegModID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update RegisterStd set Id = @id where moduleID = @modID", con);
                cmd.Parameters.AddWithValue("@Id", txtRegStdID.Text);
                cmd.Parameters.AddWithValue("@modID", txtRegModID.Text);
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
            PCDashboard ps = new PCDashboard();
            ps.Show();
        }

        private void RegisterSearch(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from RegisterStd where Id like '%" + txtSearchRegister.Text + "%'", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvRegisterDetails.DataSource = dt;
            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();

        }
    }
}
