
namespace XYZCampusSMS
{
    partial class RegisterStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegStdID = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegModID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRegisterDetails = new MetroFramework.Controls.MetroGrid();
            this.btnRegStdDelete = new System.Windows.Forms.Button();
            this.btnRegStdEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchRegister = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID: ";
            // 
            // txtRegStdID
            // 
            this.txtRegStdID.Location = new System.Drawing.Point(158, 97);
            this.txtRegStdID.Name = "txtRegStdID";
            this.txtRegStdID.Size = new System.Drawing.Size(100, 26);
            this.txtRegStdID.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(6, 16);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(176, 47);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Module ID: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtRegModID
            // 
            this.txtRegModID.Location = new System.Drawing.Point(158, 142);
            this.txtRegModID.Name = "txtRegModID";
            this.txtRegModID.Size = new System.Drawing.Size(100, 26);
            this.txtRegModID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Registering students to modules";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvRegisterDetails
            // 
            this.dgvRegisterDetails.AllowUserToResizeRows = false;
            this.dgvRegisterDetails.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvRegisterDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegisterDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRegisterDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegisterDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegisterDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegisterDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRegisterDetails.EnableHeadersVisualStyles = false;
            this.dgvRegisterDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRegisterDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRegisterDetails.Location = new System.Drawing.Point(-2, 231);
            this.dgvRegisterDetails.Name = "dgvRegisterDetails";
            this.dgvRegisterDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegisterDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRegisterDetails.RowHeadersWidth = 62;
            this.dgvRegisterDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRegisterDetails.RowTemplate.Height = 28;
            this.dgvRegisterDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisterDetails.Size = new System.Drawing.Size(646, 219);
            this.dgvRegisterDetails.TabIndex = 6;
            // 
            // btnRegStdDelete
            // 
            this.btnRegStdDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRegStdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegStdDelete.Location = new System.Drawing.Point(6, 107);
            this.btnRegStdDelete.Name = "btnRegStdDelete";
            this.btnRegStdDelete.Size = new System.Drawing.Size(176, 52);
            this.btnRegStdDelete.TabIndex = 7;
            this.btnRegStdDelete.Text = "Delete";
            this.btnRegStdDelete.UseVisualStyleBackColor = false;
            this.btnRegStdDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegStdEdit
            // 
            this.btnRegStdEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRegStdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegStdEdit.Location = new System.Drawing.Point(6, 61);
            this.btnRegStdEdit.Name = "btnRegStdEdit";
            this.btnRegStdEdit.Size = new System.Drawing.Size(176, 50);
            this.btnRegStdEdit.TabIndex = 8;
            this.btnRegStdEdit.Text = "Edit";
            this.btnRegStdEdit.UseVisualStyleBackColor = false;
            this.btnRegStdEdit.Click += new System.EventHandler(this.btnRegStdEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.btnRegStdEdit);
            this.groupBox1.Controls.Add(this.btnRegStdDelete);
            this.groupBox1.Location = new System.Drawing.Point(462, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 165);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search Student ID: ";
            // 
            // txtSearchRegister
            // 
            this.txtSearchRegister.Location = new System.Drawing.Point(213, 180);
            this.txtSearchRegister.Name = "txtSearchRegister";
            this.txtSearchRegister.Size = new System.Drawing.Size(109, 26);
            this.txtSearchRegister.TabIndex = 12;
            this.txtSearchRegister.TextChanged += new System.EventHandler(this.RegisterSearch);
            // 
            // home
            // 
            this.home.Image = global::XYZCampusSMS.Properties.Resources.home;
            this.home.Location = new System.Drawing.Point(603, -4);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(46, 39);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home.TabIndex = 19;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // back
            // 
            this.back.Image = global::XYZCampusSMS.Properties.Resources.download__2_;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(37, 33);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back.TabIndex = 9;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RegisterStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.home);
            this.Controls.Add(this.txtSearchRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dgvRegisterDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegModID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegStdID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterStudents";
            this.Text = "RegisterStudents";
            this.Load += new System.EventHandler(this.RegisterStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegStdID;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegModID;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroGrid dgvRegisterDetails;
        private System.Windows.Forms.Button btnRegStdDelete;
        private System.Windows.Forms.Button btnRegStdEdit;
        private System.Windows.Forms.PictureBox back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchRegister;
        private System.Windows.Forms.PictureBox home;
    }
}