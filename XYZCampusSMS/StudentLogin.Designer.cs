
namespace XYZCampusSMS
{
    partial class StudentLogin
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
            this.txtStdPword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStdLogin = new System.Windows.Forms.Button();
            this.txtStdUname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStdPword
            // 
            this.txtStdPword.Location = new System.Drawing.Point(399, 233);
            this.txtStdPword.Name = "txtStdPword";
            this.txtStdPword.Size = new System.Drawing.Size(136, 26);
            this.txtStdPword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username: ";
            // 
            // btnStdLogin
            // 
            this.btnStdLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdLogin.Location = new System.Drawing.Point(359, 305);
            this.btnStdLogin.Name = "btnStdLogin";
            this.btnStdLogin.Size = new System.Drawing.Size(122, 57);
            this.btnStdLogin.TabIndex = 8;
            this.btnStdLogin.Text = "Login";
            this.btnStdLogin.UseVisualStyleBackColor = false;
            this.btnStdLogin.Click += new System.EventHandler(this.btnStdLogin_Click);
            // 
            // txtStdUname
            // 
            this.txtStdUname.Location = new System.Drawing.Point(399, 169);
            this.txtStdUname.Name = "txtStdUname";
            this.txtStdUname.Size = new System.Drawing.Size(136, 26);
            this.txtStdUname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::XYZCampusSMS.Properties.Resources.images__2_;
            this.pictureBox3.Location = new System.Drawing.Point(57, 117);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 169);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Image = global::XYZCampusSMS.Properties.Resources.unnamed1;
            this.Exit.Location = new System.Drawing.Point(754, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 33);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 13;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Back
            // 
            this.Back.Image = global::XYZCampusSMS.Properties.Resources.download__2_;
            this.Back.Location = new System.Drawing.Point(1, 1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(44, 33);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 12;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.txtStdPword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStdLogin);
            this.Controls.Add(this.txtStdUname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentLogin";
            this.Text = "StudentLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStdPword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStdLogin;
        private System.Windows.Forms.TextBox txtStdUname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}