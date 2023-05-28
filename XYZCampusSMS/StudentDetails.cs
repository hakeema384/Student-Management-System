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
    
    public partial class StudentDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hakee\OneDrive\Desktop\Sneakers\Documents\XYZ_SMS.mdf;Integrated Security=True;Connect Timeout=30");
        
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            txtStdID.Text = "";
            txtStdName.Text = "";
            txtStdDOB.Text = "";
            txtStdBatch.Text = "";
        }

        private void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Students";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DgvStdDetails.DataSource = dt;
            con.Close();

        }

        private void btnStdAdd_Click(object sender, EventArgs e)
        {
            if (txtStdID.Text == "" || txtStdName.Text == "" || txtStdDOB.Text == "" || txtStdBatch.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Students values ('" + txtStdID.Text + "','" + txtStdName.Text + "','" + txtStdDOB.Text + "','" + txtStdBatch.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                MessageBox.Show("Record added successfully");
                Reset();
            }
        }

        private void btnStdDelete_Click(object sender, EventArgs e)
        {
            if (txtStdID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Students where id='" + txtStdID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted successfully");
                Reset();
            }
        }

        private void btnStdEdit_Click(object sender, EventArgs e)
        {
            if (txtStdID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Students set name = @name, dob = @dob, batch = @batch where id = @id", con);
                cmd.Parameters.AddWithValue("@id", txtStdID.Text);
                cmd.Parameters.AddWithValue("@name", txtStdName.Text);
                cmd.Parameters.AddWithValue("@dob", txtStdDOB.Text);
                cmd.Parameters.AddWithValue("@batch", txtStdBatch.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully");
                con.Close();
                display_data();
                Reset();
            }
        }

        private void DgvStdDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStdID.Text = DgvStdDetails.SelectedRows[0].Cells[0].Value.ToString();
            txtStdName.Text = DgvStdDetails.SelectedRows[0].Cells[1].Value.ToString();
            txtStdDOB.Text = DgvStdDetails.SelectedRows[0].Cells[2].Value.ToString();
            txtStdBatch.Text = DgvStdDetails.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void btnStdBack_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void searchID(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from Students where Id like '%" + txtSearchID.Text + "%'", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            DgvStdDetails.DataSource = dt;
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PCDashboard wc = new PCDashboard();
            wc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
