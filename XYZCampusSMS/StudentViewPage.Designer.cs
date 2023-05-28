
namespace XYZCampusSMS
{
    partial class StudentViewPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvView1 = new MetroFramework.Controls.MetroGrid();
            this.btnViewStdID = new System.Windows.Forms.Button();
            this.btnViewStdSchd = new System.Windows.Forms.Button();
            this.btnViewMod = new System.Windows.Forms.Button();
            this.btnViewLec = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Board";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvView1
            // 
            this.dgvView1.AllowUserToResizeRows = false;
            this.dgvView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvView1.EnableHeadersVisualStyles = false;
            this.dgvView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvView1.Location = new System.Drawing.Point(-4, 154);
            this.dgvView1.Name = "dgvView1";
            this.dgvView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvView1.RowHeadersWidth = 62;
            this.dgvView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvView1.RowTemplate.Height = 28;
            this.dgvView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView1.Size = new System.Drawing.Size(655, 313);
            this.dgvView1.TabIndex = 1;
            // 
            // btnViewStdID
            // 
            this.btnViewStdID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnViewStdID.Location = new System.Drawing.Point(-4, 78);
            this.btnViewStdID.Name = "btnViewStdID";
            this.btnViewStdID.Size = new System.Drawing.Size(190, 50);
            this.btnViewStdID.TabIndex = 2;
            this.btnViewStdID.Text = "Student ID";
            this.btnViewStdID.UseVisualStyleBackColor = false;
            this.btnViewStdID.Click += new System.EventHandler(this.btnViewStdID_Click);
            // 
            // btnViewStdSchd
            // 
            this.btnViewStdSchd.BackColor = System.Drawing.Color.Ivory;
            this.btnViewStdSchd.Location = new System.Drawing.Point(178, 78);
            this.btnViewStdSchd.Name = "btnViewStdSchd";
            this.btnViewStdSchd.Size = new System.Drawing.Size(181, 50);
            this.btnViewStdSchd.TabIndex = 4;
            this.btnViewStdSchd.Text = "Schedule";
            this.btnViewStdSchd.UseVisualStyleBackColor = false;
            this.btnViewStdSchd.Click += new System.EventHandler(this.btnViewStdSchd_Click);
            // 
            // btnViewMod
            // 
            this.btnViewMod.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnViewMod.Location = new System.Drawing.Point(353, 78);
            this.btnViewMod.Name = "btnViewMod";
            this.btnViewMod.Size = new System.Drawing.Size(158, 50);
            this.btnViewMod.TabIndex = 5;
            this.btnViewMod.Text = "Modules";
            this.btnViewMod.UseVisualStyleBackColor = false;
            this.btnViewMod.Click += new System.EventHandler(this.btnViewMod_Click);
            // 
            // btnViewLec
            // 
            this.btnViewLec.BackColor = System.Drawing.Color.CadetBlue;
            this.btnViewLec.Location = new System.Drawing.Point(502, 78);
            this.btnViewLec.Name = "btnViewLec";
            this.btnViewLec.Size = new System.Drawing.Size(149, 50);
            this.btnViewLec.TabIndex = 6;
            this.btnViewLec.Text = "Lecturer Details ";
            this.btnViewLec.UseVisualStyleBackColor = false;
            this.btnViewLec.Click += new System.EventHandler(this.btnViewLec_Click);
            // 
            // Home
            // 
            this.Home.Image = global::XYZCampusSMS.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(-4, -4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(46, 39);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 20;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // StudentViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(653, 466);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.btnViewLec);
            this.Controls.Add(this.btnViewMod);
            this.Controls.Add(this.btnViewStdSchd);
            this.Controls.Add(this.btnViewStdID);
            this.Controls.Add(this.dgvView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentViewPage";
            this.Text = "StudentViewPage";
            this.Load += new System.EventHandler(this.StudentViewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroGrid dgvView1;
        private System.Windows.Forms.Button btnViewStdID;
        private System.Windows.Forms.Button btnViewStdSchd;
        private System.Windows.Forms.Button btnViewMod;
        private System.Windows.Forms.Button btnViewLec;
        private System.Windows.Forms.PictureBox Home;
    }
}