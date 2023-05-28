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
    public partial class Modules : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hakee\OneDrive\Desktop\Sneakers\Documents\XYZ_SMS.mdf;Integrated Security=True;Connect Timeout=30");
        public Modules()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtModID.Text = "";
            txtModName.Text = "";
            txtLecHours.Text = "";
            txtModLecID.Text = "";
        }

        private void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Modules";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvModDetails.DataSource = dt;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtModID.Text == "" || txtModName.Text == "" || txtLecHours.Text == "" || txtModLecID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Modules values ('" + txtModID.Text + "','" + txtModName.Text + "','" + txtLecHours.Text + "','"+txtModLecID.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                display_data();
                MessageBox.Show("Record added successfully");
                Reset();
            }
        }

        private void dgvModDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtModID.Text = dgvModDetails.SelectedRows[0].Cells[0].Value.ToString();
            txtModName.Text = dgvModDetails.SelectedRows[0].Cells[1].Value.ToString();
            txtLecHours.Text = dgvModDetails.SelectedRows[0].Cells[2].Value.ToString();
            txtModLecID.Text = dgvModDetails.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Modules_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void btnModDelete_Click(object sender, EventArgs e)
        {

            if (txtModID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Modules where moduleID='" + txtModID.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record deleted successfully");
                display_data();
                Reset();
                
            }
        }

        private void btnModEdit_Click(object sender, EventArgs e)
        {
            if (txtModID.Text == "" || txtModName.Text == "" || txtLecHours.Text == "" || txtModLecID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Modules set moduleName = @mName, lecHours = @lecHours, lecID = @LID where moduleID = @mID", con);
                cmd.Parameters.AddWithValue("@mID", txtModID.Text);
                cmd.Parameters.AddWithValue("@mName", txtModName.Text);
                cmd.Parameters.AddWithValue("@lecHours", txtLecHours.Text);
                cmd.Parameters.AddWithValue("@LID", txtModLecID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully");
                con.Close();
                display_data();
                Reset();
            }
        }

        private void btnModBack_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void idSearch(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from Modules where moduleID like '%" + txtIDSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            dgvModDetails.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PCDashboard pd = new PCDashboard();
            pd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome w = new Welcome();
            w.Show();
        }
    }
}
