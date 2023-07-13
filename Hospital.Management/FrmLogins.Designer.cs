namespace Hospital.Management
{
    partial class FrmLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.BtnPatientLogin = new System.Windows.Forms.Button();
            this.BtnDoctorLogin = new System.Windows.Forms.Button();
            this.BtnSecretaryLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPatientLogin
            // 
            this.BtnPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatientLogin.BackgroundImage")));
            this.BtnPatientLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatientLogin.Location = new System.Drawing.Point(51, 202);
            this.BtnPatientLogin.Name = "BtnPatientLogin";
            this.BtnPatientLogin.Size = new System.Drawing.Size(212, 158);
            this.BtnPatientLogin.TabIndex = 0;
            this.BtnPatientLogin.UseVisualStyleBackColor = true;
            this.BtnPatientLogin.Click += new System.EventHandler(this.BtnPatientLogin_Click);
            // 
            // BtnDoctorLogin
            // 
            this.BtnDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoctorLogin.BackgroundImage")));
            this.BtnDoctorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctorLogin.Location = new System.Drawing.Point(302, 202);
            this.BtnDoctorLogin.Name = "BtnDoctorLogin";
            this.BtnDoctorLogin.Size = new System.Drawing.Size(212, 158);
            this.BtnDoctorLogin.TabIndex = 1;
            this.BtnDoctorLogin.UseVisualStyleBackColor = true;
            this.BtnDoctorLogin.Click += new System.EventHandler(this.BtnDoctorLogin_Click);
            // 
            // BtnSecretaryLogin
            // 
            this.BtnSecretaryLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSecretaryLogin.BackgroundImage")));
            this.BtnSecretaryLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecretaryLogin.Location = new System.Drawing.Point(553, 202);
            this.BtnSecretaryLogin.Name = "BtnSecretaryLogin";
            this.BtnSecretaryLogin.Size = new System.Drawing.Size(212, 158);
            this.BtnSecretaryLogin.TabIndex = 2;
            this.BtnSecretaryLogin.UseVisualStyleBackColor = true;
            this.BtnSecretaryLogin.Click += new System.EventHandler(this.BtnSecretaryLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(486, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lightning Hospital";
            // 
            // FrmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(823, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSecretaryLogin);
            this.Controls.Add(this.BtnDoctorLogin);
            this.Controls.Add(this.BtnPatientLogin);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmLogins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lightning Hospital Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPatientLogin;
        private System.Windows.Forms.Button BtnDoctorLogin;
        private System.Windows.Forms.Button BtnSecretaryLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

