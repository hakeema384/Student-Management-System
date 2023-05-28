
namespace XYZCampusSMS
{
    partial class SALogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSAUname = new System.Windows.Forms.TextBox();
            this.btnSALogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSAPword = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Administrator ";
            // 
            // txtSAUname
            // 
            this.txtSAUname.Location = new System.Drawing.Point(435, 174);
            this.txtSAUname.Name = "txtSAUname";
            this.txtSAUname.Size = new System.Drawing.Size(136, 26);
            this.txtSAUname.TabIndex = 1;
            // 
            // btnSALogin
            // 
            this.btnSALogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSALogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALogin.Location = new System.Drawing.Point(419, 313);
            this.btnSALogin.Name = "btnSALogin";
            this.btnSALogin.Size = new System.Drawing.Size(98, 49);
            this.btnSALogin.TabIndex = 2;
            this.btnSALogin.Text = "Login";
            this.btnSALogin.UseVisualStyleBackColor = false;
            this.btnSALogin.Click += new System.EventHandler(this.btnSALogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password: ";
            // 
            // txtSAPword
            // 
            this.txtSAPword.Location = new System.Drawing.Point(435, 235);
            this.txtSAPword.Name = "txtSAPword";
            this.txtSAPword.Size = new System.Drawing.Size(136, 26);
            this.txtSAPword.TabIndex = 5;
            // 
            // Exit
            // 
            this.Exit.Image = global::XYZCampusSMS.Properties.Resources.unnamed1;
            this.Exit.Location = new System.Drawing.Point(812, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 33);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 14;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Back
            // 
            this.Back.Image = global::XYZCampusSMS.Properties.Resources.download__2_;
            this.Back.Location = new System.Drawing.Point(1, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(44, 33);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 15;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::XYZCampusSMS.Properties.Resources.download__3_;
            this.pictureBox3.Location = new System.Drawing.Point(30, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 204);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // SALogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(855, 478);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.txtSAPword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSALogin);
            this.Controls.Add(this.txtSAUname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SALogin";
            this.Text = "SALogin";
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSAUname;
        private System.Windows.Forms.Button btnSALogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSAPword;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}