namespace Mate_version2
{
    partial class dotaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dotaz));
            this.Yes = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.No = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Yes.BackColor = System.Drawing.Color.Transparent;
            this.Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Yes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Yes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Bold);
            this.Yes.ForeColor = System.Drawing.Color.Transparent;
            this.Yes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Yes.Location = new System.Drawing.Point(12, 174);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(244, 50);
            this.Yes.TabIndex = 432;
            this.Yes.Text = "Ano";
            this.Yes.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Black;
            this.Title.Font = new System.Drawing.Font("Expo", 18F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Title.Location = new System.Drawing.Point(55, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(180, 33);
            this.Title.TabIndex = 428;
            this.Title.Text = "Aktualizovat";
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.Color.Black;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(527, 40);
            this.presunpanel.TabIndex = 430;
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.Color.Black;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.shield3;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 429;
            this.icoprog.TabStop = false;
            // 
            // No
            // 
            this.No.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.No.BackColor = System.Drawing.Color.Transparent;
            this.No.Cursor = System.Windows.Forms.Cursors.Hand;
            this.No.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.No.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.No.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Bold);
            this.No.ForeColor = System.Drawing.Color.Transparent;
            this.No.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.No.Location = new System.Drawing.Point(270, 174);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(244, 50);
            this.No.TabIndex = 432;
            this.No.Text = "Ne";
            this.No.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Expo", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 107);
            this.label1.TabIndex = 433;
            this.label1.Text = "Program našel novější verzi programu. Přejete si program aktualizovat. Pokud ano," +
    " program nyní stáhne aktualizačná program.";
            // 
            // dotaz
            // 
            this.AcceptButton = this.Yes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CancelButton = this.No;
            this.ClientSize = new System.Drawing.Size(526, 236);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dotaz";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "dotaz";
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label presunpanel;
        internal System.Windows.Forms.Button Yes;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.Button No;
        internal System.Windows.Forms.Label label1;
    }
}