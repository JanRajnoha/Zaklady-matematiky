namespace Mate_version2
{
    partial class hodnoceni
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
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.bad = new System.Windows.Forms.RadioButton();
            this.middle = new System.Windows.Forms.RadioButton();
            this.good = new System.Windows.Forms.RadioButton();
            this.Evaluate = new System.Windows.Forms.TextBox();
            this.EMail = new System.Windows.Forms.TextBox();
            this.Sender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.asd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
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
            this.Title.Size = new System.Drawing.Size(389, 33);
            this.Title.TabIndex = 457;
            this.Title.Text = "Odeslat hodnocení programu";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(485, 40);
            this.presunpanel.TabIndex = 459;
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.opinion;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 458;
            this.icoprog.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Expo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(283, 450);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(188, 47);
            this.cancel.TabIndex = 470;
            this.cancel.Text = "Storno";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // send
            // 
            this.send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.send.Enabled = false;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Expo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(12, 450);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(265, 47);
            this.send.TabIndex = 469;
            this.send.Text = "Poslat";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // bad
            // 
            this.bad.AutoSize = true;
            this.bad.Font = new System.Drawing.Font("Expo", 15.75F);
            this.bad.ForeColor = System.Drawing.Color.White;
            this.bad.Location = new System.Drawing.Point(310, 186);
            this.bad.Name = "bad";
            this.bad.Size = new System.Drawing.Size(161, 33);
            this.bad.TabIndex = 467;
            this.bad.Text = "Nespokojen";
            this.bad.UseVisualStyleBackColor = true;
            this.bad.CheckedChanged += new System.EventHandler(this.bad_CheckedChanged);
            // 
            // middle
            // 
            this.middle.AutoSize = true;
            this.middle.Font = new System.Drawing.Font("Expo", 15.75F);
            this.middle.ForeColor = System.Drawing.Color.White;
            this.middle.Location = new System.Drawing.Point(157, 186);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(147, 33);
            this.middle.TabIndex = 466;
            this.middle.Text = "Něco mezi";
            this.middle.UseVisualStyleBackColor = true;
            this.middle.CheckedChanged += new System.EventHandler(this.bad_CheckedChanged);
            // 
            // good
            // 
            this.good.AutoSize = true;
            this.good.Checked = true;
            this.good.Font = new System.Drawing.Font("Expo", 15.75F);
            this.good.ForeColor = System.Drawing.Color.White;
            this.good.Location = new System.Drawing.Point(17, 186);
            this.good.Name = "good";
            this.good.Size = new System.Drawing.Size(134, 33);
            this.good.TabIndex = 465;
            this.good.TabStop = true;
            this.good.Text = "Spokojen";
            this.good.UseVisualStyleBackColor = true;
            this.good.CheckedChanged += new System.EventHandler(this.bad_CheckedChanged);
            // 
            // Evaluate
            // 
            this.Evaluate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Evaluate.Font = new System.Drawing.Font("Expo", 15.75F);
            this.Evaluate.Location = new System.Drawing.Point(17, 254);
            this.Evaluate.Multiline = true;
            this.Evaluate.Name = "Evaluate";
            this.Evaluate.Size = new System.Drawing.Size(454, 181);
            this.Evaluate.TabIndex = 468;
            // 
            // EMail
            // 
            this.EMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EMail.Font = new System.Drawing.Font("Expo", 15.75F);
            this.EMail.Location = new System.Drawing.Point(17, 144);
            this.EMail.Name = "EMail";
            this.EMail.Size = new System.Drawing.Size(454, 36);
            this.EMail.TabIndex = 464;
            this.EMail.Text = "@";
            this.EMail.TextChanged += new System.EventHandler(this.check_mail);
            // 
            // Sender
            // 
            this.Sender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sender.Font = new System.Drawing.Font("Expo", 15.75F);
            this.Sender.Location = new System.Drawing.Point(101, 61);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(370, 36);
            this.Sender.TabIndex = 463;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Expo", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 29);
            this.label2.TabIndex = 460;
            this.label2.Text = "Hodnocení programu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Expo", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 29);
            this.label1.TabIndex = 461;
            this.label1.Text = "E_mail (povinný údaj)";
            // 
            // asd
            // 
            this.asd.AutoSize = true;
            this.asd.Font = new System.Drawing.Font("Expo", 15.75F);
            this.asd.ForeColor = System.Drawing.Color.White;
            this.asd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.asd.Location = new System.Drawing.Point(12, 63);
            this.asd.Name = "asd";
            this.asd.Size = new System.Drawing.Size(83, 29);
            this.asd.TabIndex = 462;
            this.asd.Text = "Jméno";
            // 
            // hodnoceni
            // 
            this.AcceptButton = this.send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(485, 474);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.send);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.good);
            this.Controls.Add(this.Evaluate);
            this.Controls.Add(this.EMail);
            this.Controls.Add(this.Sender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asd);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "hodnoceni";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hodnoceni";
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cancel;
        internal System.Windows.Forms.Button send;
        internal System.Windows.Forms.RadioButton bad;
        internal System.Windows.Forms.RadioButton middle;
        internal System.Windows.Forms.RadioButton good;
        internal System.Windows.Forms.TextBox Evaluate;
        internal System.Windows.Forms.TextBox EMail;
        internal System.Windows.Forms.TextBox Sender;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label asd;
        internal System.Windows.Forms.PictureBox icoprog;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Label presunpanel;

    }
}