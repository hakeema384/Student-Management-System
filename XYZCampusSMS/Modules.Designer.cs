
namespace XYZCampusSMS
{
    partial class Modules
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
            this.txtModID = new System.Windows.Forms.TextBox();
            this.btnModAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLecHours = new System.Windows.Forms.TextBox();
            this.btnModEdit = new System.Windows.Forms.Button();
            this.btnModDelete = new System.Windows.Forms.Button();
            this.dgvModDetails = new MetroFramework.Controls.MetroGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.txtModLecID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modules";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtModID
            // 
            this.txtModID.Location = new System.Drawing.Point(108, 102);
            this.txtModID.Name = "txtModID";
            this.txtModID.Size = new System.Drawing.Size(88, 26);
            this.txtModID.TabIndex = 1;
            // 
            // btnModAdd
            // 
            this.btnModAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModAdd.Location = new System.Drawing.Point(0, 0);
            this.btnModAdd.Name = "btnModAdd";
            this.btnModAdd.Size = new System.Drawing.Size(200, 51);
            this.btnModAdd.TabIndex = 2;
            this.btnModAdd.Text = "Add";
            this.btnModAdd.UseVisualStyleBackColor = false;
            this.btnModAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Module ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Module Name: ";
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(133, 147);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(169, 26);
            this.txtModName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lecture Hours:";
            // 
            // txtLecHours
            // 
            this.txtLecHours.Location = new System.Drawing.Point(133, 184);
            this.txtLecHours.Name = "txtLecHours";
            this.txtLecHours.Size = new System.Drawing.Size(75, 26);
            this.txtLecHours.TabIndex = 7;
            // 
            // btnModEdit
            // 
            this.btnModEdit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnModEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModEdit.Location = new System.Drawing.Point(0, 51);
            this.btnModEdit.Name = "btnModEdit";
            this.btnModEdit.Size = new System.Drawing.Size(200, 56);
            this.btnModEdit.TabIndex = 8;
            this.btnModEdit.Text = "Edit";
            this.btnModEdit.UseVisualStyleBackColor = false;
            this.btnModEdit.Click += new System.EventHandler(this.btnModEdit_Click);
            // 
            // btnModDelete
            // 
            this.btnModDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnModDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModDelete.Location = new System.Drawing.Point(0, 107);
            this.btnModDelete.Name = "btnModDelete";
            this.btnModDelete.Size = new System.Drawing.Size(200, 66);
            this.btnModDelete.TabIndex = 9;
            this.btnModDelete.Text = "Delete";
            this.btnModDelete.UseVisualStyleBackColor = false;
            this.btnModDelete.Click += new System.EventHandler(this.btnModDelete_Click);
            // 
            // dgvModDetails
            // 
            this.dgvModDetails.AllowUserToResizeRows = false;
            this.dgvModDetails.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvModDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModDetails.EnableHeadersVisualStyles = false;
            this.dgvModDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvModDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvModDetails.Location = new System.Drawing.Point(-3, 314);
            this.dgvModDetails.Name = "dgvModDetails";
            this.dgvModDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModDetails.RowHeadersWidth = 62;
            this.dgvModDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvModDetails.RowTemplate.Height = 28;
            this.dgvModDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModDetails.Size = new System.Drawing.Size(731, 276);
            this.dgvModDetails.TabIndex = 11;
            this.dgvModDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModDetails_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lecturer ID: ";
            // 
            // txtModLecID
            // 
            this.txtModLecID.Location = new System.Drawing.Point(133, 230);
            this.txtModLecID.Name = "txtModLecID";
            this.txtModLecID.Size = new System.Drawing.Size(75, 26);
            this.txtModLecID.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModAdd);
            this.groupBox1.Controls.Add(this.btnModEdit);
            this.groupBox1.Controls.Add(this.btnModDelete);
            this.groupBox1.Location = new System.Drawing.Point(528, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 173);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search ID: ";
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(133, 270);
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(181, 26);
            this.txtIDSearch.TabIndex = 16;
            this.txtIDSearch.TextChanged += new System.EventHandler(this.idSearch);
            // 
            // Home
            // 
            this.Home.Image = global::XYZCampusSMS.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(682, -4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(46, 39);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 18;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Back
            // 
            this.Back.Image = global::XYZCampusSMS.Properties.Resources.download__2_;
            this.Back.Location = new System.Drawing.Point(-3, -4);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(46, 39);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 17;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(726, 591);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.txtIDSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtModLecID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvModDetails);
            this.Controls.Add(this.txtLecHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtModID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modules";
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.Modules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModID;
        private System.Windows.Forms.Button btnModAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLecHours;
        private System.Windows.Forms.Button btnModEdit;
        private System.Windows.Forms.Button btnModDelete;
        private MetroFramework.Controls.MetroGrid dgvModDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtModLecID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.PictureBox Home;
    }
}