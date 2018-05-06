namespace Proyecto_2.src.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TitleLBL = new System.Windows.Forms.Label();
            this.LogoLBL = new System.Windows.Forms.PictureBox();
            this.UsernameTXTB = new System.Windows.Forms.TextBox();
            this.PasswordTXTB = new System.Windows.Forms.TextBox();
            this.IPTXTB = new System.Windows.Forms.TextBox();
            this.UsernameLBL = new System.Windows.Forms.Label();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.IPLBL = new System.Windows.Forms.Label();
            this.LogBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.RegisterBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoLBL)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("hooge 05_55", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.TitleLBL.Location = new System.Drawing.Point(31, 42);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(261, 25);
            this.TitleLBL.TabIndex = 0;
            this.TitleLBL.Text = "Welcome to Odyssey!";
            this.TitleLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogoLBL
            // 
            this.LogoLBL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoLBL.BackgroundImage")));
            this.LogoLBL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogoLBL.Location = new System.Drawing.Point(82, 80);
            this.LogoLBL.Name = "LogoLBL";
            this.LogoLBL.Size = new System.Drawing.Size(154, 128);
            this.LogoLBL.TabIndex = 1;
            this.LogoLBL.TabStop = false;
            // 
            // UsernameTXTB
            // 
            this.UsernameTXTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsernameTXTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTXTB.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.UsernameTXTB.ForeColor = System.Drawing.Color.White;
            this.UsernameTXTB.Location = new System.Drawing.Point(154, 263);
            this.UsernameTXTB.Name = "UsernameTXTB";
            this.UsernameTXTB.Size = new System.Drawing.Size(106, 17);
            this.UsernameTXTB.TabIndex = 2;
            this.UsernameTXTB.TextChanged += new System.EventHandler(this.UsernameTXTB_TextChanged);
            // 
            // PasswordTXTB
            // 
            this.PasswordTXTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasswordTXTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTXTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTXTB.ForeColor = System.Drawing.Color.White;
            this.PasswordTXTB.Location = new System.Drawing.Point(154, 307);
            this.PasswordTXTB.Name = "PasswordTXTB";
            this.PasswordTXTB.Size = new System.Drawing.Size(106, 16);
            this.PasswordTXTB.TabIndex = 3;
            this.PasswordTXTB.UseSystemPasswordChar = true;
            // 
            // IPTXTB
            // 
            this.IPTXTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IPTXTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPTXTB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTXTB.ForeColor = System.Drawing.Color.White;
            this.IPTXTB.Location = new System.Drawing.Point(154, 355);
            this.IPTXTB.Name = "IPTXTB";
            this.IPTXTB.Size = new System.Drawing.Size(106, 16);
            this.IPTXTB.TabIndex = 4;
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.AutoSize = true;
            this.UsernameLBL.Font = new System.Drawing.Font("hooge 05_55", 12F);
            this.UsernameLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.UsernameLBL.Location = new System.Drawing.Point(32, 261);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(95, 20);
            this.UsernameLBL.TabIndex = 5;
            this.UsernameLBL.Text = "Username:";
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Font = new System.Drawing.Font("hooge 05_55", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.PasswordLBL.Location = new System.Drawing.Point(32, 305);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(95, 20);
            this.PasswordLBL.TabIndex = 6;
            this.PasswordLBL.Text = "Password:";
            // 
            // IPLBL
            // 
            this.IPLBL.AutoSize = true;
            this.IPLBL.Font = new System.Drawing.Font("hooge 05_55", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.IPLBL.Location = new System.Drawing.Point(100, 353);
            this.IPLBL.Name = "IPLBL";
            this.IPLBL.Size = new System.Drawing.Size(27, 20);
            this.IPLBL.TabIndex = 7;
            this.IPLBL.Text = "IP:";
            // 
            // LogBTN
            // 
            this.LogBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.LogBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogBTN.Font = new System.Drawing.Font("hooge 05_55", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.LogBTN.Location = new System.Drawing.Point(82, 398);
            this.LogBTN.Name = "LogBTN";
            this.LogBTN.Size = new System.Drawing.Size(157, 33);
            this.LogBTN.TabIndex = 8;
            this.LogBTN.Text = "LOG IN!";
            this.LogBTN.UseVisualStyleBackColor = false;
            this.LogBTN.Click += new System.EventHandler(this.LogBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("hooge 05_55", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.MinimizeBTN);
            this.panel1.Controls.Add(this.CloseBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 21);
            this.panel1.TabIndex = 10;
            // 
            // MinimizeBTN
            // 
            this.MinimizeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinimizeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBTN.FlatAppearance.BorderSize = 0;
            this.MinimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBTN.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBTN.ForeColor = System.Drawing.Color.Black;
            this.MinimizeBTN.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeBTN.Image")));
            this.MinimizeBTN.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeBTN.Location = new System.Drawing.Point(262, 0);
            this.MinimizeBTN.Name = "MinimizeBTN";
            this.MinimizeBTN.Size = new System.Drawing.Size(30, 24);
            this.MinimizeBTN.TabIndex = 6;
            this.MinimizeBTN.UseVisualStyleBackColor = false;
            this.MinimizeBTN.Click += new System.EventHandler(this.MinimizeBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBTN.FlatAppearance.BorderSize = 0;
            this.CloseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBTN.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBTN.ForeColor = System.Drawing.Color.Black;
            this.CloseBTN.Location = new System.Drawing.Point(291, -3);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(30, 24);
            this.CloseBTN.TabIndex = 5;
            this.CloseBTN.Text = "X";
            this.CloseBTN.UseVisualStyleBackColor = false;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // RegisterBTN
            // 
            this.RegisterBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.RegisterBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBTN.Font = new System.Drawing.Font("hooge 05_55", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.RegisterBTN.Location = new System.Drawing.Point(27, 453);
            this.RegisterBTN.Name = "RegisterBTN";
            this.RegisterBTN.Size = new System.Drawing.Size(265, 33);
            this.RegisterBTN.TabIndex = 11;
            this.RegisterBTN.Text = "Not yet an user? Join Now!";
            this.RegisterBTN.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(321, 498);
            this.Controls.Add(this.RegisterBTN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogBTN);
            this.Controls.Add(this.IPLBL);
            this.Controls.Add(this.PasswordLBL);
            this.Controls.Add(this.UsernameLBL);
            this.Controls.Add(this.IPTXTB);
            this.Controls.Add(this.PasswordTXTB);
            this.Controls.Add(this.UsernameTXTB);
            this.Controls.Add(this.LogoLBL);
            this.Controls.Add(this.TitleLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoLBL)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLBL;
        private System.Windows.Forms.PictureBox LogoLBL;
        private System.Windows.Forms.TextBox UsernameTXTB;
        private System.Windows.Forms.TextBox PasswordTXTB;
        private System.Windows.Forms.TextBox IPTXTB;
        private System.Windows.Forms.Label UsernameLBL;
        private System.Windows.Forms.Label PasswordLBL;
        private System.Windows.Forms.Label IPLBL;
        private System.Windows.Forms.Button LogBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button MinimizeBTN;
        private System.Windows.Forms.Button RegisterBTN;
    }
}