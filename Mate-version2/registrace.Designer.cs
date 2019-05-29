namespace Mate_version2
{
    partial class Registruj
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
            this.components = new System.ComponentModel.Container();
            this.register = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.User_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Pass2 = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.User)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Expo", 16F);
            this.register.ForeColor = System.Drawing.Color.White;
            this.register.Location = new System.Drawing.Point(12, 191);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(274, 55);
            this.register.TabIndex = 4;
            this.register.Text = "Registrovat se";
            this.register.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Expo", 16F);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(292, 191);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(253, 55);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Zrušit";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // User_Name
            // 
            this.User_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_Name.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.User_Name.Location = new System.Drawing.Point(254, 50);
            this.User_Name.Name = "User_Name";
            this.User_Name.Size = new System.Drawing.Size(291, 36);
            this.User_Name.TabIndex = 1;
            this.User_Name.TextChanged += new System.EventHandler(this.zmena_user);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 94);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Heslo";
            // 
            // Pass
            // 
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pass.Location = new System.Drawing.Point(254, 92);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(291, 36);
            this.Pass.TabIndex = 2;
            this.Pass.UseSystemPasswordChar = true;
            this.Pass.TextChanged += new System.EventHandler(this.zmena_pass);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 52);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jméno";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-159, 136);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(407, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zadejte heslo znovu";
            // 
            // Pass2
            // 
            this.Pass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass2.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pass2.Location = new System.Drawing.Point(254, 134);
            this.Pass2.Name = "Pass2";
            this.Pass2.Size = new System.Drawing.Size(291, 36);
            this.Pass2.TabIndex = 3;
            this.Pass2.UseSystemPasswordChar = true;
            this.Pass2.TextChanged += new System.EventHandler(this.zmena_pass2);
            // 
            // User
            // 
            this.User.ContainerControl = this;
            // 
            // Password
            // 
            this.Password.ContainerControl = this;
            // 
            // Password1
            // 
            this.Password1.ContainerControl = this;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Font = new System.Drawing.Font("Expo", 18F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(41, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(152, 33);
            this.Title.TabIndex = 457;
            this.Title.Text = "Registrace";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(582, 40);
            this.presunpanel.TabIndex = 459;
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.plus;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(2, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 458;
            this.icoprog.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(159, 102);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(254, 29);
            this.label4.TabIndex = 460;
            this.label4.Text = "Jméno";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(167, 110);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(254, 29);
            this.label5.TabIndex = 461;
            this.label5.Text = "Jméno";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(175, 118);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(254, 29);
            this.label6.TabIndex = 462;
            this.label6.Text = "Jméno";
            this.label6.Visible = false;
            // 
            // Registruj
            // 
            this.AcceptButton = this.register;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(572, 233);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pass2);
            this.Controls.Add(this.register);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.User_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Registruj";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrace";
            ((System.ComponentModel.ISupportInitialize)(this.User)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button register;
        internal System.Windows.Forms.Button cancel;
        internal System.Windows.Forms.TextBox User_Name;
        internal System.Windows.Forms.TextBox Pass;
        internal System.Windows.Forms.TextBox Pass2;
        private System.Windows.Forms.ErrorProvider User;
        private System.Windows.Forms.ErrorProvider Password;
        private System.Windows.Forms.ErrorProvider Password1;
        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label presunpanel;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
    }
}