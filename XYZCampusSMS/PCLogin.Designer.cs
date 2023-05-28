
namespace XYZCampusSMS
{
    partial class PCLogin
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
            this.txtPCUname = new System.Windows.Forms.TextBox();
            this.btnPCLogin = new System.Windows.Forms.Button();
            this.txtPCPword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // txtPCUname
            // 
            this.txtPCUname.Location = new System.Drawing.Point(413, 183);
            this.txtPCUname.Name = "txtPCUname";
            this.txtPCUname.Size = new System.Drawing.Size(176, 26);
            this.txtPCUname.TabIndex = 1;
            // 
            // btnPCLogin
            // 
            this.btnPCLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPCLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCLogin.Location = new System.Drawing.Point(413, 327);
            this.btnPCLogin.Name = "btnPCLogin";
            this.btnPCLogin.Size = new System.Drawing.Size(135, 48);
            this.btnPCLogin.TabIndex = 2;
            this.btnPCLogin.Text = "Login";
            this.btnPCLogin.UseVisualStyleBackColor = false;
            this.btnPCLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPCPword
            // 
            this.txtPCPword.Location = new System.Drawing.Point(413, 255);
            this.txtPCPword.Name = "txtPCPword";
            this.txtPCPword.Size = new System.Drawing.Size(176, 26);
            this.txtPCPword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Program co-ordinator ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XYZCampusSMS.Properties.Resources.institute;
            this.pictureBox1.Location = new System.Drawing.Point(21, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Image = global::XYZCampusSMS.Properties.Resources.unnamed1;
            this.Exit.Location = new System.Drawing.Point(731, 1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 33);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 15;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Back
            // 
            this.Back.Image = global::XYZCampusSMS.Properties.Resources.download__2_;
            this.Back.Location = new System.Drawing.Point(2, 1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(44, 33);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back.TabIndex = 16;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(777, 483);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPCPword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPCLogin);
            this.Controls.Add(this.txtPCUname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCLogin";
            this.Text = "PCLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPCUname;
        private System.Windows.Forms.Button btnPCLogin;
        private System.Windows.Forms.TextBox txtPCPword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Back;
    }
}