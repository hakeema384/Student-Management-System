
namespace XYZCampusSMS
{
    partial class Lecturer
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
            this.txtLecID = new System.Windows.Forms.TextBox();
            this.btnAddLec = new System.Windows.Forms.Button();
            this.dgvLecDetails = new MetroFramework.Controls.MetroGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLecName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLecAddress = new System.Windows.Forms.TextBox();
            this.btnEditLec = new System.Windows.Forms.Button();
            this.btnDeleteLec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchStdID = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer ID: ";
            // 
            // txtLecID
            // 
            this.txtLecID.Location = new System.Drawing.Point(103, 76);
            this.txtLecID.Name = "txtLecID";
            this.txtLecID.Size = new System.Drawing.Size(89, 26);
            this.txtLecID.TabIndex = 1;
            // 
            // btnAddLec
            // 
            this.btnAddLec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddLec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLec.Location = new System.Drawing.Point(0, 36);
            this.btnAddLec.Name = "btnAddLec";
            this.btnAddLec.Size = new System.Drawing.Size(192, 47);
            this.btnAddLec.TabIndex = 2;
            this.btnAddLec.Text = "Add";
            this.btnAddLec.UseVisualStyleBackColor = false;
            this.btnAddLec.Click += new System.EventHandler(this.btnAddLec_Click);
            // 
            // dgvLecDetails
            // 
            this.dgvLecDetails.AllowUserToResizeRows = false;
            this.dgvLecDetails.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvLecDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLecDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLecDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLecDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLecDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLecDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLecDetails.EnableHeadersVisualStyles = false;
            this.dgvLecDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLecDetails.GridColor = System.Drawing.Color.White;
            this.dgvLecDetails.Location = new System.Drawing.Point(-1, 251);
            this.dgvLecDetails.Name = "dgvLecDetails";
            this.dgvLecDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLecDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLecDetails.RowHeadersWidth = 62;
            this.dgvLecDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLecDetails.RowTemplate.Height = 28;
            this.dgvLecDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLecDetails.Size = new System.Drawing.Size(676, 235);
            this.dgvLecDetails.TabIndex = 3;
            this.dgvLecDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecDetails_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lecturers ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name: ";
            // 
            // txtLecName
            // 
            this.txtLecName.Location = new System.Drawing.Point(81, 120);
            this.txtLecName.Name = "txtLecName";
            this.txtLecName.Size = new System.Drawing.Size(133, 26);
            this.txtLecName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address: ";
            // 
            // txtLecAddress
            // 
            this.txtLecAddress.Location = new System.Drawing.Point(90, 168);
            this.txtLecAddress.Name = "txtLecAddress";
            this.txtLecAddress.Size = new System.Drawing.Size(269, 26);
            this.txtLecAddress.TabIndex = 8;
            // 
            // btnEditLec
            // 
            this.btnEditLec.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditLec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLec.Location = new System.Drawing.Point(0, 83);
            this.btnEditLec.Name = "btnEditLec";
            this.btnEditLec.Size = new System.Drawing.Size(192, 48);
            this.btnEditLec.TabIndex = 9;
            this.btnEditLec.Text = "Edit";
            this.btnEditLec.UseVisualStyleBackColor = false;
            this.btnEditLec.Click += new System.EventHandler(this.btnEditLec_Click);
            // 
            // btnDeleteLec
            // 
            this.btnDeleteLec.BackColor = System.Drawing.Color.Olive;
            this.btnDeleteLec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLec.Location = new System.Drawing.Point(0, 131);
            this.btnDeleteLec.Name = "btnDeleteLec";
            this.btnDeleteLec.Size = new System.Drawing.Size(192, 47);
            this.btnDeleteLec.TabIndex = 10;
            this.btnDeleteLec.Text = "Delete";
            this.btnDeleteLec.UseVisualStyleBackColor = false;
            this.btnDeleteLec.Click += new System.EventHandler(this.btnDeleteLec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddLec);
            this.groupBox1.Controls.Add(this.btnEditLec);
            this.groupBox1.Controls.Add(this.btnDeleteLec);
            this.groupBox1.Location = new System.Drawing.Point(483, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search ID:";
            // 
            // txtSearchStdID
            // 
            this.txtSearchStdID.Location = new System.Drawing.Point(108, 216);
            this.txtSearchStdID.Name = "txtSearchStdID";
            this.txtSearchStdID.Size = new System.Drawing.Size(163, 26);
            this.txtSearchStdID.TabIndex = 14;
            this.txtSearchStdID.TextChanged += new System.EventHandler(this.idSearchStd);
            // 
            // Home
            // 
            this.Home.Image = global::XYZCampusSMS.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(629, -2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(46, 39);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 19;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Back
            // 
            this.Back.Image = global::XYZCampusSMS.Properties.Resources.download__2_;
            this.Back.Location = new System.Drawing.Point(-1, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(38, 37);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 20;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(676, 487);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.txtSearchStdID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLecAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLecName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLecDetails);
            this.Controls.Add(this.txtLecID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lecturer";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.Lecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLecID;
        private System.Windows.Forms.Button btnAddLec;
        private MetroFramework.Controls.MetroGrid dgvLecDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLecName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLecAddress;
        private System.Windows.Forms.Button btnEditLec;
        private System.Windows.Forms.Button btnDeleteLec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchStdID;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.PictureBox Back;
    }
}