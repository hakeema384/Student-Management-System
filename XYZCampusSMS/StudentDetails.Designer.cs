
namespace XYZCampusSMS
{
    partial class StudentDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStdName = new System.Windows.Forms.TextBox();
            this.btnStdAdd = new MetroFramework.Controls.MetroButton();
            this.DgvStdDetails = new MetroFramework.Controls.MetroGrid();
            this.txtStdBatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStdDOB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStdID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStdEdit = new MetroFramework.Controls.MetroButton();
            this.btnStdDelete = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStdDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // txtStdName
            // 
            this.txtStdName.Location = new System.Drawing.Point(63, 129);
            this.txtStdName.Name = "txtStdName";
            this.txtStdName.Size = new System.Drawing.Size(315, 26);
            this.txtStdName.TabIndex = 1;
            // 
            // btnStdAdd
            // 
            this.btnStdAdd.BackColor = System.Drawing.Color.Olive;
            this.btnStdAdd.Location = new System.Drawing.Point(-2, 14);
            this.btnStdAdd.Name = "btnStdAdd";
            this.btnStdAdd.Size = new System.Drawing.Size(201, 50);
            this.btnStdAdd.TabIndex = 2;
            this.btnStdAdd.Text = "ADD";
            this.btnStdAdd.UseSelectable = true;
            this.btnStdAdd.Click += new System.EventHandler(this.btnStdAdd_Click);
            // 
            // DgvStdDetails
            // 
            this.DgvStdDetails.AllowUserToResizeRows = false;
            this.DgvStdDetails.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.DgvStdDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvStdDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvStdDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStdDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvStdDetails.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvStdDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvStdDetails.EnableHeadersVisualStyles = false;
            this.DgvStdDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvStdDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvStdDetails.Location = new System.Drawing.Point(-2, 321);
            this.DgvStdDetails.Name = "DgvStdDetails";
            this.DgvStdDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bookshelf Symbol 7", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvStdDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvStdDetails.RowHeadersWidth = 70;
            this.DgvStdDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvStdDetails.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvStdDetails.RowTemplate.Height = 28;
            this.DgvStdDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStdDetails.Size = new System.Drawing.Size(672, 259);
            this.DgvStdDetails.TabIndex = 3;
            this.DgvStdDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStdDetails_CellContentClick);
            // 
            // txtStdBatch
            // 
            this.txtStdBatch.Location = new System.Drawing.Point(77, 232);
            this.txtStdBatch.Name = "txtStdBatch";
            this.txtStdBatch.Size = new System.Drawing.Size(64, 26);
            this.txtStdBatch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Batch: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtStdDOB
            // 
            this.txtStdDOB.Location = new System.Drawing.Point(63, 181);
            this.txtStdDOB.Name = "txtStdDOB";
            this.txtStdDOB.Size = new System.Drawing.Size(315, 26);
            this.txtStdDOB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "DOB: ";
            // 
            // txtStdID
            // 
            this.txtStdID.Location = new System.Drawing.Point(110, 80);
            this.txtStdID.Name = "txtStdID";
            this.txtStdID.Size = new System.Drawing.Size(124, 26);
            this.txtStdID.TabIndex = 8;
            this.txtStdID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Student ID: ";
            // 
            // btnStdEdit
            // 
            this.btnStdEdit.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStdEdit.Location = new System.Drawing.Point(0, 65);
            this.btnStdEdit.Name = "btnStdEdit";
            this.btnStdEdit.Size = new System.Drawing.Size(199, 45);
            this.btnStdEdit.TabIndex = 11;
            this.btnStdEdit.Text = "EDIT";
            this.btnStdEdit.UseSelectable = true;
            this.btnStdEdit.Click += new System.EventHandler(this.btnStdEdit_Click);
            // 
            // btnStdDelete
            // 
            this.btnStdDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStdDelete.Location = new System.Drawing.Point(0, 112);
            this.btnStdDelete.Name = "btnStdDelete";
            this.btnStdDelete.Size = new System.Drawing.Size(199, 49);
            this.btnStdDelete.TabIndex = 12;
            this.btnStdDelete.Text = "DELETE";
            this.btnStdDelete.UseSelectable = true;
            this.btnStdDelete.Click += new System.EventHandler(this.btnStdDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStdAdd);
            this.groupBox1.Controls.Add(this.btnStdEdit);
            this.groupBox1.Controls.Add(this.btnStdDelete);
            this.groupBox1.Location = new System.Drawing.Point(471, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 161);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search ID: ";
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(110, 280);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(91, 26);
            this.txtSearchID.TabIndex = 16;
            this.txtSearchID.TextChanged += new System.EventHandler(this.searchID);
            // 
            // Back
            // 
            this.Back.Image = global::XYZCampusSMS.Properties.Resources.download__2_;
            this.Back.Location = new System.Drawing.Point(7, 6);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(38, 37);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 21;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Home
            // 
            this.Home.Image = global::XYZCampusSMS.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(624, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(46, 39);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 22;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(671, 581);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStdDOB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStdID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStdBatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvStdDetails);
            this.Controls.Add(this.txtStdName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentDetails";
            this.Text = " ";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStdDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStdName;
        private MetroFramework.Controls.MetroButton btnStdAdd;
        private MetroFramework.Controls.MetroGrid DgvStdDetails;
        private System.Windows.Forms.TextBox txtStdBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStdDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStdID;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroButton btnStdEdit;
        private MetroFramework.Controls.MetroButton btnStdDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.PictureBox Home;
    }
}