namespace Mate_version2
{
    partial class Wait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wait));
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.load_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.time;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 461;
            this.icoprog.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Font = new System.Drawing.Font("Expo", 18F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(43, 1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(145, 33);
            this.Title.TabIndex = 460;
            this.Title.Text = "Trpělivost";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(1, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(507, 40);
            this.presunpanel.TabIndex = 462;
            // 
            // load_pic
            // 
            this.load_pic.Location = new System.Drawing.Point(12, 47);
            this.load_pic.Name = "load_pic";
            this.load_pic.Size = new System.Drawing.Size(160, 160);
            this.load_pic.TabIndex = 463;
            this.load_pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 160);
            this.label1.TabIndex = 464;
            this.label1.Text = "Prosím počkejte, program provádí složitější akci";
            // 
            // Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(491, 219);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load_pic);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wait";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wait";
            this.Load += new System.EventHandler(this.Wait_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.load_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label presunpanel;
        private System.Windows.Forms.PictureBox load_pic;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Label label1;
    }
}