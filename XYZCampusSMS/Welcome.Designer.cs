
namespace XYZCampusSMS
{
    partial class Welcome
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnPC = new System.Windows.Forms.Button();
            this.btnSA = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(213, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to XYZ Student Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "\"Where Quality meets Education\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStudent);
            this.groupBox1.Controls.Add(this.btnPC);
            this.groupBox1.Controls.Add(this.btnSA);
            this.groupBox1.Location = new System.Drawing.Point(2, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 362);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "CAMPUS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::XYZCampusSMS.Properties.Resources.welcome;
            this.pictureBox3.Location = new System.Drawing.Point(213, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(660, 330);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::XYZCampusSMS.Properties.Resources.xyz;
            this.pictureBox2.Location = new System.Drawing.Point(2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Honeydew;
            this.btnStudent.BackgroundImage = global::XYZCampusSMS.Properties.Resources.images__3_;
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.Black;
            this.btnStudent.Location = new System.Drawing.Point(6, 0);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(199, 105);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPC
            // 
            this.btnPC.BackgroundImage = global::XYZCampusSMS.Properties.Resources.images;
            this.btnPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPC.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPC.ForeColor = System.Drawing.Color.Black;
            this.btnPC.Location = new System.Drawing.Point(6, 102);
            this.btnPC.Name = "btnPC";
            this.btnPC.Size = new System.Drawing.Size(199, 134);
            this.btnPC.TabIndex = 2;
            this.btnPC.Text = "Program co-ordinator ";
            this.btnPC.UseVisualStyleBackColor = true;
            this.btnPC.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSA
            // 
            this.btnSA.BackgroundImage = global::XYZCampusSMS.Properties.Resources.student_sitting_desk_colored_line_icon_simple_dark_light_blue_element_illustration_deskconcept_outlin_outline_symbol_design_128886407;
            this.btnSA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSA.Font = new System.Drawing.Font("Elephant", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSA.ForeColor = System.Drawing.Color.Black;
            this.btnSA.Location = new System.Drawing.Point(6, 236);
            this.btnSA.Name = "btnSA";
            this.btnSA.Size = new System.Drawing.Size(199, 120);
            this.btnSA.TabIndex = 3;
            this.btnSA.Text = "System Admin ";
            this.btnSA.UseVisualStyleBackColor = true;
            this.btnSA.Click += new System.EventHandler(this.button3_Click);
            // 
            // Exit
            // 
            this.Exit.Image = global::XYZCampusSMS.Properties.Resources.unnamed;
            this.Exit.Location = new System.Drawing.Point(832, -2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(44, 38);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 4;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(875, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Welcome";
            this.Padding = new System.Windows.Forms.Padding(24, 51, 24, 17);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnPC;
        private System.Windows.Forms.Button btnSA;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}

