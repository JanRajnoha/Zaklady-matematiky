namespace Mate_version2
{
    partial class hotovo
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
            this.Storno = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
            // 
            // Storno
            // 
            this.Storno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Storno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Storno.Font = new System.Drawing.Font("Expo", 16F);
            this.Storno.ForeColor = System.Drawing.Color.White;
            this.Storno.Location = new System.Drawing.Point(266, 108);
            this.Storno.Name = "Storno";
            this.Storno.Size = new System.Drawing.Size(188, 43);
            this.Storno.TabIndex = 452;
            this.Storno.Text = "Ne";
            this.Storno.UseVisualStyleBackColor = true;
            this.Storno.Visible = false;
            // 
            // accept
            // 
            this.accept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Font = new System.Drawing.Font("Expo", 16F);
            this.accept.ForeColor = System.Drawing.Color.White;
            this.accept.Location = new System.Drawing.Point(134, 108);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(188, 43);
            this.accept.TabIndex = 453;
            this.accept.Text = "OK";
            this.accept.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Expo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.status.ForeColor = System.Drawing.Color.White;
            this.status.Location = new System.Drawing.Point(12, 40);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(442, 65);
            this.status.TabIndex = 451;
            this.status.Text = "Program byl úspěšně stáhnut. Nyní se provede aktualizace.";
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
            this.Title.Size = new System.Drawing.Size(103, 33);
            this.Title.TabIndex = 448;
            this.Title.Text = "Hotovo";
            // 
            // presunpanel
            // 
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(480, 40);
            this.presunpanel.TabIndex = 450;
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.ok;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 449;
            this.icoprog.TabStop = false;
            // 
            // hotovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(474, 140);
            this.Controls.Add(this.Storno);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.status);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "hotovo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "hotovo";
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Storno;
        internal System.Windows.Forms.Button accept;
        internal System.Windows.Forms.Label status;
        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label presunpanel;
    }
}