namespace Mate_version2
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
            this.label1 = new System.Windows.Forms.Label();
            this.User_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.User_log = new System.Windows.Forms.TextBox();
            this.without_login = new System.Windows.Forms.Button();
            this.with_login = new System.Windows.Forms.Button();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jméno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // User_pass
            // 
            this.User_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_pass.Font = new System.Drawing.Font("Expo", 15.75F);
            this.User_pass.Location = new System.Drawing.Point(101, 91);
            this.User_pass.Name = "User_pass";
            this.User_pass.Size = new System.Drawing.Size(363, 36);
            this.User_pass.TabIndex = 2;
            this.User_pass.UseSystemPasswordChar = true;
            this.User_pass.TextChanged += new System.EventHandler(this.zmena);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Heslo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // User_log
            // 
            this.User_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_log.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.User_log.Location = new System.Drawing.Point(101, 49);
            this.User_log.Name = "User_log";
            this.User_log.Size = new System.Drawing.Size(363, 36);
            this.User_log.TabIndex = 1;
            this.User_log.TextChanged += new System.EventHandler(this.zmena);
            // 
            // without_login
            // 
            this.without_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.without_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.without_login.Font = new System.Drawing.Font("Expo", 16F);
            this.without_login.ForeColor = System.Drawing.Color.White;
            this.without_login.Location = new System.Drawing.Point(261, 144);
            this.without_login.Name = "without_login";
            this.without_login.Size = new System.Drawing.Size(203, 51);
            this.without_login.TabIndex = 4;
            this.without_login.Text = "Bez přihlášení";
            this.without_login.UseVisualStyleBackColor = true;
            // 
            // with_login
            // 
            this.with_login.Enabled = false;
            this.with_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.with_login.Font = new System.Drawing.Font("Expo", 16F);
            this.with_login.ForeColor = System.Drawing.Color.White;
            this.with_login.Location = new System.Drawing.Point(17, 144);
            this.with_login.Name = "with_login";
            this.with_login.Size = new System.Drawing.Size(238, 51);
            this.with_login.TabIndex = 3;
            this.with_login.Text = "Přihlásit";
            this.with_login.UseVisualStyleBackColor = true;
            this.with_login.Click += new System.EventHandler(this.with_login_Click);
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.singin;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 455;
            this.icoprog.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Font = new System.Drawing.Font("Expo", 18F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(42, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(87, 33);
            this.Title.TabIndex = 454;
            this.Title.Text = "Login";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(1, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(478, 40);
            this.presunpanel.TabIndex = 456;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 457;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 458;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 459;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 460;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 461;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 462;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // Login
            // 
            this.AcceptButton = this.with_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CancelButton = this.without_login;
            this.ClientSize = new System.Drawing.Size(476, 184);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.Controls.Add(this.User_log);
            this.Controls.Add(this.with_login);
            this.Controls.Add(this.without_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User_pass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox User_pass;
        internal System.Windows.Forms.TextBox User_log;
        internal System.Windows.Forms.Button without_login;
        internal System.Windows.Forms.Button with_login;
        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label presunpanel;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
    }
}