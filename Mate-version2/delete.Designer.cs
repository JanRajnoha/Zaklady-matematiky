namespace Mate_version2
{
    partial class delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete));
            this.delete_btn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.User_log = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.User_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(12, 142);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(181, 50);
            this.delete_btn.TabIndex = 9;
            this.delete_btn.Text = "Smazat";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(199, 142);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(143, 50);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Storno";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // User_log
            // 
            this.User_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_log.Enabled = false;
            this.User_log.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.User_log.ForeColor = System.Drawing.Color.Black;
            this.User_log.Location = new System.Drawing.Point(115, 46);
            this.User_log.Name = "User_log";
            this.User_log.Size = new System.Drawing.Size(227, 36);
            this.User_log.TabIndex = 6;
            this.User_log.TextChanged += new System.EventHandler(this.zmena);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Heslo";
            // 
            // User_pass
            // 
            this.User_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.User_pass.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.User_pass.ForeColor = System.Drawing.Color.Black;
            this.User_pass.Location = new System.Drawing.Point(115, 88);
            this.User_pass.Name = "User_pass";
            this.User_pass.Size = new System.Drawing.Size(227, 36);
            this.User_pass.TabIndex = 8;
            this.User_pass.UseSystemPasswordChar = true;
            this.User_pass.TextChanged += new System.EventHandler(this.zmena);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jméno";
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.minus;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 458;
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
            this.Title.Size = new System.Drawing.Size(138, 33);
            this.Title.TabIndex = 457;
            this.Title.Text = "Odstranit";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(355, 40);
            this.presunpanel.TabIndex = 459;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 460;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 461;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 462;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 463;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 464;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 465;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 466;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 467;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // delete
            // 
            this.AcceptButton = this.delete_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(350, 178);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.User_log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.User_pass);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "delete";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button delete_btn;
        internal System.Windows.Forms.Button cancel;
        internal System.Windows.Forms.TextBox User_log;
        internal System.Windows.Forms.TextBox User_pass;
        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label presunpanel;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
    }
}