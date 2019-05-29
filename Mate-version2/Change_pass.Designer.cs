namespace Mate_version2
{
    partial class Change_pass
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
            this.label3 = new System.Windows.Forms.Label();
            this.new_Pass2 = new System.Windows.Forms.TextBox();
            this.change = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.old_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.new_Pass1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-57, 144);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(364, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nové heslo znovu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // new_Pass2
            // 
            this.new_Pass2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_Pass2.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_Pass2.Location = new System.Drawing.Point(313, 142);
            this.new_Pass2.Name = "new_Pass2";
            this.new_Pass2.Size = new System.Drawing.Size(318, 36);
            this.new_Pass2.TabIndex = 3;
            this.new_Pass2.UseSystemPasswordChar = true;
            this.new_Pass2.TextChanged += new System.EventHandler(this.zmena_pass2);
            // 
            // change
            // 
            this.change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change.Font = new System.Drawing.Font("Expo", 16F);
            this.change.ForeColor = System.Drawing.Color.White;
            this.change.Location = new System.Drawing.Point(48, 190);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(347, 51);
            this.change.TabIndex = 4;
            this.change.Text = "Změnit heslo";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Expo", 16F);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(401, 190);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(230, 51);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Zrušit";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // old_pass
            // 
            this.old_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.old_pass.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.old_pass.Location = new System.Drawing.Point(313, 58);
            this.old_pass.Name = "old_pass";
            this.old_pass.Size = new System.Drawing.Size(318, 36);
            this.old_pass.TabIndex = 1;
            this.old_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(295, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nové heslo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // new_Pass1
            // 
            this.new_Pass1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.new_Pass1.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.new_Pass1.Location = new System.Drawing.Point(313, 100);
            this.new_Pass1.Name = "new_Pass1";
            this.new_Pass1.Size = new System.Drawing.Size(318, 36);
            this.new_Pass1.TabIndex = 2;
            this.new_Pass1.UseSystemPasswordChar = true;
            this.new_Pass1.TextChanged += new System.EventHandler(this.zmena_pass);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(295, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Staré heslo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Password
            // 
            this.Password.ContainerControl = this;
            // 
            // Password1
            // 
            this.Password1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.changepass;
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
            this.Title.Size = new System.Drawing.Size(179, 33);
            this.Title.TabIndex = 454;
            this.Title.Text = "Změna hesla";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(653, 40);
            this.presunpanel.TabIndex = 456;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(282, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 29);
            this.label5.TabIndex = 457;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(281, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 458;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(290, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 459;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(281, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 29);
            this.label8.TabIndex = 460;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(289, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 29);
            this.label9.TabIndex = 461;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(277, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 29);
            this.label10.TabIndex = 462;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(279, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 29);
            this.label11.TabIndex = 463;
            this.label11.Text = "label11";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(277, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 29);
            this.label12.TabIndex = 464;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // Change_pass
            // 
            this.AcceptButton = this.change;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(643, 222);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_Pass2);
            this.Controls.Add(this.change);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.new_Pass1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Change_pass";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Změna hesla";
            ((System.ComponentModel.ISupportInitialize)(this.Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox new_Pass2;
        internal System.Windows.Forms.Button change;
        internal System.Windows.Forms.Button cancel;
        internal System.Windows.Forms.TextBox old_pass;
        internal System.Windows.Forms.TextBox new_Pass1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ErrorProvider Password;
        internal System.Windows.Forms.ErrorProvider Password1;
        internal System.Windows.Forms.PictureBox icoprog;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Label presunpanel;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
    }
}