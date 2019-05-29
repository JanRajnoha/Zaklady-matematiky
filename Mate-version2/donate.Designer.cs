namespace Mate_version2
{
    partial class donate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(donate));
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.accept = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.Label();
            this.zadotovat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.Title.Location = new System.Drawing.Point(42, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(144, 33);
            this.Title.TabIndex = 451;
            this.Title.Text = "Příspěvek";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(480, 40);
            this.presunpanel.TabIndex = 453;
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.donate;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 452;
            this.icoprog.TabStop = false;
            // 
            // accept
            // 
            this.accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Font = new System.Drawing.Font("Expo", 16F);
            this.accept.ForeColor = System.Drawing.Color.White;
            this.accept.Location = new System.Drawing.Point(277, 242);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(188, 43);
            this.accept.TabIndex = 454;
            this.accept.Text = "OK";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // link
            // 
            this.link.Font = new System.Drawing.Font("Expo", 14.25F);
            this.link.ForeColor = System.Drawing.Color.White;
            this.link.Location = new System.Drawing.Point(12, 55);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(453, 184);
            this.link.TabIndex = 455;
            this.link.Text = resources.GetString("link.Text");
            // 
            // zadotovat
            // 
            this.zadotovat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zadotovat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.zadotovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zadotovat.Font = new System.Drawing.Font("Expo", 16F);
            this.zadotovat.ForeColor = System.Drawing.Color.White;
            this.zadotovat.Location = new System.Drawing.Point(17, 242);
            this.zadotovat.Name = "zadotovat";
            this.zadotovat.Size = new System.Drawing.Size(188, 43);
            this.zadotovat.TabIndex = 454;
            this.zadotovat.Text = "Přispět";
            this.zadotovat.UseVisualStyleBackColor = true;
            this.zadotovat.Click += new System.EventHandler(this.dotovat);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 456;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // donate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(477, 297);
            this.Controls.Add(this.link);
            this.Controls.Add(this.zadotovat);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "donate";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "donate";
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label presunpanel;
        internal System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label link;
        internal System.Windows.Forms.Button zadotovat;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}