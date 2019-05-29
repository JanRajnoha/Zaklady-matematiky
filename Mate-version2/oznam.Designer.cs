namespace Mate_version2
{
    partial class oznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oznam));
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.accept = new System.Windows.Forms.Button();
            this.nadpis = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
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
            this.Title.Text = "Oznámení";
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
            // accept
            // 
            this.accept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Font = new System.Drawing.Font("Expo", 16F);
            this.accept.ForeColor = System.Drawing.Color.White;
            this.accept.Location = new System.Drawing.Point(143, 278);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(188, 43);
            this.accept.TabIndex = 454;
            this.accept.Text = "OK";
            this.accept.UseVisualStyleBackColor = true;
            // 
            // nadpis
            // 
            this.nadpis.AutoSize = true;
            this.nadpis.Font = new System.Drawing.Font("Expo", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nadpis.ForeColor = System.Drawing.Color.White;
            this.nadpis.Location = new System.Drawing.Point(12, 54);
            this.nadpis.Name = "nadpis";
            this.nadpis.Size = new System.Drawing.Size(121, 36);
            this.nadpis.TabIndex = 455;
            this.nadpis.Text = "Nadpis";
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(12, 90);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(451, 185);
            this.text.TabIndex = 455;
            this.text.Text = "text";
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icoprog.BackgroundImage")));
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 452;
            this.icoprog.TabStop = false;
            // 
            // oznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(475, 333);
            this.Controls.Add(this.text);
            this.Controls.Add(this.nadpis);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "oznam";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "oznam";
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label presunpanel;
        internal System.Windows.Forms.Button accept;
        internal System.Windows.Forms.Label nadpis;
        internal System.Windows.Forms.Label text;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.PictureBox icoprog;
    }
}