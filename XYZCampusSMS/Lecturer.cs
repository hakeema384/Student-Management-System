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
    public partial class Lecturer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hakee\OneDrive\Desktop\Sneakers\Documents\XYZ_SMS.mdf;Integrated Security=True;Connect Timeout=30");

        public Lecturer()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtLecID.Text = "";
            txtLecName.Text = "";
            txtLecAddress.Text = "";
        }

        private void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Lecturers";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvLecDetails.DataSource = dt;
            con.Close();

        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            if (txtLecID.Text == "" || txtLecName.Text == "" || txtLecAddress.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Lecturers values ('" + txtLecID.Text + "','" + txtLecName.Text + "','" + txtLecAddress.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                MessageBox.Show("Record added successfully");
                Reset();
            }
        }

        private void Lecturer_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void dgvLecDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLecID.Text = dgvLecDetails.SelectedRows[0].Cells[0].Value.ToString();
            txtLecName.Text = dgvLecDetails.SelectedRows[0].Cells[1].Value.ToString();
            txtLecAddress.Text = dgvLecDetails.SelectedRows[0].Cells[2].Value.ToString();
            
        }

        private void btnEditLec_Click(object sender, EventArgs e)
        {
            if (txtLecID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Lecturers set lecName = @name, lecAddress= @add where lecID = @LID", con);
                cmd.Parameters.AddWithValue("@LID", txtLecID.Text);
                cmd.Parameters.AddWithValue("@name", txtLecName.Text);
                cmd.Parameters.AddWithValue("@add", txtLecAddress.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully");
                con.Close();
                display_data();
                Reset();
            }
        }

        private void btnDeleteLec_Click(object sender, EventArgs e)
        {
            if (txtLecID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Lecturers where lecID='" + txtLecID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted successfully");
                Reset();
                display_data();
            }
        }

        private void btnLecBack_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void idSearchStd(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from Lecturers where lecID like '%" + txtSearchStdID.Text + "%'", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvLecDetails.DataSource = dt;
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PCDashboard ps = new PCDashboard();
            ps.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
