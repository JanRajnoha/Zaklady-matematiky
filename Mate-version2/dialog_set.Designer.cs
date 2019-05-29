namespace Mate_version2
{
    partial class dialog_set
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
            this.presunpanel = new System.Windows.Forms.Label();
            this.use = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.typ = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.set = new System.Windows.Forms.NumericUpDown();
            this.kolekce = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).BeginInit();
            this.SuspendLayout();
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(728, 40);
            this.presunpanel.TabIndex = 465;
            // 
            // use
            // 
            this.use.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.use.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.use.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.use.Font = new System.Drawing.Font("Expo", 16F);
            this.use.ForeColor = System.Drawing.Color.White;
            this.use.Location = new System.Drawing.Point(12, 146);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(221, 55);
            this.use.TabIndex = 461;
            this.use.Text = "Použít";
            this.use.UseVisualStyleBackColor = true;
            this.use.Click += new System.EventHandler(this.use_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Expo", 16F);
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(239, 146);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(191, 55);
            this.cancel.TabIndex = 462;
            this.cancel.Text = "Zrušit";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // typ
            // 
            this.typ.AutoSize = true;
            this.typ.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typ.ForeColor = System.Drawing.Color.White;
            this.typ.Location = new System.Drawing.Point(113, 64);
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(57, 29);
            this.typ.TabIndex = 463;
            this.typ.Text = "Typ";
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
            this.Title.Size = new System.Drawing.Size(161, 33);
            this.Title.TabIndex = 466;
            this.Title.Text = "Nastavení: ";
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.set;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 464;
            this.icoprog.TabStop = false;
            // 
            // set
            // 
            this.set.Font = new System.Drawing.Font("Expo", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.set.Location = new System.Drawing.Point(130, 96);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(221, 33);
            this.set.TabIndex = 467;
            // 
            // kolekce
            // 
            this.kolekce.Font = new System.Drawing.Font("Expo", 11.5F, System.Drawing.FontStyle.Bold);
            this.kolekce.FormattingEnabled = true;
            this.kolekce.ItemHeight = 21;
            this.kolekce.Location = new System.Drawing.Point(130, 96);
            this.kolekce.Name = "kolekce";
            this.kolekce.Size = new System.Drawing.Size(220, 172);
            this.kolekce.TabIndex = 469;
            this.kolekce.Visible = false;
            this.kolekce.DoubleClick += new System.EventHandler(this.kolekce_DoubleClick);
            // 
            // dialog_set
            // 
            this.AcceptButton = this.use;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(430, 213);
            this.Controls.Add(this.kolekce);
            this.Controls.Add(this.set);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.presunpanel);
            this.Controls.Add(this.use);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.typ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "dialog_set";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "dialog_set";
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button use;
        internal System.Windows.Forms.Button cancel;
        internal System.Windows.Forms.PictureBox icoprog;
        internal System.Windows.Forms.Label presunpanel;
        internal System.Windows.Forms.Label typ;
        internal System.Windows.Forms.Label Title;
        internal System.Windows.Forms.NumericUpDown set;
        internal System.Windows.Forms.ListBox kolekce;
    }
}