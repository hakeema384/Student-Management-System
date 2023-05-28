
namespace XYZCampusSMS
{
    partial class LoginInfo
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
            this.txtSASetUname = new System.Windows.Forms.TextBox();
            this.btnLoginAdd = new System.Windows.Forms.Button();
            this.dgvLoginDetails = new MetroFramework.Controls.MetroGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSASetPword = new System.Windows.Forms.TextBox();
            this.btnLoginEdit = new System.Windows.Forms.Button();
            this.btnLoginDelete = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchUName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // txtSASetUname
            // 
            this.txtSASetUname.Location = new System.Drawing.Point(102, 112);
            this.txtSASetUname.Name = "txtSASetUname";
            this.txtSASetUname.Size = new System.Drawing.Size(162, 26);
            this.txtSASetUname.TabIndex = 1;
            // 
            // btnLoginAdd
            // 
            this.btnLoginAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnLoginAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdd.Location = new System.Drawing.Point(6, 9);
            this.btnLoginAdd.Name = "btnLoginAdd";
            this.btnLoginAdd.Size = new System.Drawing.Size(188, 53);
            this.btnLoginAdd.TabIndex = 2;
            this.btnLoginAdd.Text = "Add";
            this.btnLoginAdd.UseVisualStyleBackColor = false;
            this.btnLoginAdd.Click += new System.EventHandler(this.btnLoginAdd_Click);
            // 
            // dgvLoginDetails
            // 
            this.dgvLoginDetails.AllowUserToResizeRows = false;
            this.dgvLoginDetails.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvLoginDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLoginDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLoginDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoginDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoginDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoginDetails.EnableHeadersVisualStyles = false;
            this.dgvLoginDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvLoginDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLoginDetails.Location = new System.Drawing.Point(0, 241);
            this.dgvLoginDetails.Name = "dgvLoginDetails";
            this.dgvLoginDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoginDetails.RowHeadersWidth = 62;
            this.dgvLoginDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoginDetails.RowTemplate.Height = 28;
            this.dgvLoginDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoginDetails.Size = new System.Drawing.Size(622, 242);
            this.dgvLoginDetails.TabIndex = 3;
            this.dgvLoginDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoginDetails_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Login Information ";
            // 
            // txtSASetPword
            // 
            this.txtSASetPword.Location = new System.Drawing.Point(102, 153);
            this.txtSASetPword.Name = "txtSASetPword";
            this.txtSASetPword.Size = new System.Drawing.Size(166, 26);
            this.txtSASetPword.TabIndex = 6;
            // 
            // btnLoginEdit
            // 
            this.btnLoginEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLoginEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginEdit.Location = new System.Drawing.Point(6, 57);
            this.btnLoginEdit.Name = "btnLoginEdit";
            this.btnLoginEdit.Size = new System.Drawing.Size(188, 55);
            this.btnLoginEdit.TabIndex = 7;
            this.btnLoginEdit.Text = "Edit";
            this.btnLoginEdit.UseVisualStyleBackColor = false;
            this.btnLoginEdit.Click += new System.EventHandler(this.btnLoginEdit_Click);
            // 
            // btnLoginDelete
            // 
            this.btnLoginDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnLoginDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginDelete.Location = new System.Drawing.Point(6, 111);
            this.btnLoginDelete.Name = "btnLoginDelete";
            this.btnLoginDelete.Size = new System.Drawing.Size(188, 51);
            this.btnLoginDelete.TabIndex = 8;
            this.btnLoginDelete.Text = "Delete";
            this.btnLoginDelete.UseVisualStyleBackColor = false;
            this.btnLoginDelete.Click += new System.EventHandler(this.btnLoginDelete_Click);
            // 
            // Home
            // 
            this.Home.Image = global::XYZCampusSMS.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(0, 1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(43, 40);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 9;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoginAdd);
            this.groupBox1.Controls.Add(this.btnLoginEdit);
            this.groupBox1.Controls.Add(this.btnLoginDelete);
            this.groupBox1.Location = new System.Drawing.Point(428, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 162);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search username: ";
            // 
            // txtSearchUName
            // 
            this.txtSearchUName.Location = new System.Drawing.Point(159, 202);
            this.txtSearchUName.Name = "txtSearchUName";
            this.txtSearchUName.Size = new System.Drawing.Size(184, 26);
            this.txtSearchUName.TabIndex = 12;
            this.txtSearchUName.TextChanged += new System.EventHandler(this.UnameSearch);
            // 
            // LoginInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(619, 483);
            this.Controls.Add(this.txtSearchUName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.txtSASetPword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLoginDetails);
            this.Controls.Add(this.txtSASetUname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginInfo";
            this.Text = "LoginInfo";
            this.Load += new System.EventHandler(this.LoginInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSASetUname;
        private System.Windows.Forms.Button btnLoginAdd;
        private MetroFramework.Controls.MetroGrid dgvLoginDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSASetPword;
        private System.Windows.Forms.Button btnLoginEdit;
        private System.Windows.Forms.Button btnLoginDelete;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchUName;
    }
}