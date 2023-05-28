
namespace XYZCampusSMS
{
    partial class PCDashboard
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
            this.modules = new System.Windows.Forms.Label();
            this.lecturers = new System.Windows.Forms.Label();
            this.registerStd = new System.Windows.Forms.Label();
            this.students = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // modules
            // 
            this.modules.AutoSize = true;
            this.modules.Font = new System.Drawing.Font("Trajan Pro 3", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modules.Location = new System.Drawing.Point(357, 210);
            this.modules.Name = "modules";
            this.modules.Size = new System.Drawing.Size(192, 49);
            this.modules.TabIndex = 1;
            this.modules.Text = "Modules";
            this.modules.Click += new System.EventHandler(this.label2_Click);
            // 
            // lecturers
            // 
            this.lecturers.AutoSize = true;
            this.lecturers.Font = new System.Drawing.Font("Trajan Pro 3", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturers.Location = new System.Drawing.Point(347, 310);
            this.lecturers.Name = "lecturers";
            this.lecturers.Size = new System.Drawing.Size(221, 49);
            this.lecturers.TabIndex = 2;
            this.lecturers.Text = "Lecturers";
            this.lecturers.Click += new System.EventHandler(this.label3_Click);
            // 
            // registerStd
            // 
            this.registerStd.AutoSize = true;
            this.registerStd.Font = new System.Drawing.Font("Trajan Pro 3", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerStd.Location = new System.Drawing.Point(263, 413);
            this.registerStd.Name = "registerStd";
            this.registerStd.Size = new System.Drawing.Size(387, 49);
            this.registerStd.TabIndex = 3;
            this.registerStd.Text = "Register students ";
            this.registerStd.Click += new System.EventHandler(this.label4_Click);
            // 
            // students
            // 
            this.students.AutoSize = true;
            this.students.Font = new System.Drawing.Font("Trajan Pro 3", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.students.Location = new System.Drawing.Point(357, 109);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(202, 49);
            this.students.TabIndex = 5;
            this.students.Text = "Students";
            this.students.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Home
            // 
            this.Home.Image = global::XYZCampusSMS.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(2, 1);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(48, 40);
            this.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Home.TabIndex = 6;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(315, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 65);
            this.label5.TabIndex = 7;
            this.label5.Text = "DASHBOARD";
            // 
            // PCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(907, 544);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.students);
            this.Controls.Add(this.registerStd);
            this.Controls.Add(this.lecturers);
            this.Controls.Add(this.modules);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PCDashboard";
            this.Text = "PCDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label modules;
        private System.Windows.Forms.Label registerStd;
        private System.Windows.Forms.Label lecturers;
        private System.Windows.Forms.Label students;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.Label label5;
    }
}