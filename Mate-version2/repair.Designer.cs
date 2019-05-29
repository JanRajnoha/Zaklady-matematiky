namespace Mate_version2
{
    partial class repair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repair));
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.minmax = new System.Windows.Forms.Button();
            this.mini = new System.Windows.Forms.Button();
            this.konec = new System.Windows.Forms.Button();
            this.prvky_kontr = new System.Windows.Forms.ProgressBar();
            this.prvky_down = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prvek = new System.Windows.Forms.Label();
            this.Procenta = new System.Windows.Forms.Label();
            this.panel_hlavni = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.panel_hlavni.SuspendLayout();
            this.SuspendLayout();
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.aktualizace;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(1, 3);
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
            this.Title.Location = new System.Drawing.Point(40, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(589, 33);
            this.Title.TabIndex = 457;
            this.Title.Text = "Spouštěcí program pro Základy matematiky";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pozice);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.presun);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spadnuti);
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(-2, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(784, 40);
            this.presunpanel.TabIndex = 459;
            this.presunpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pozice);
            this.presunpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.presun);
            this.presunpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spadnuti);
            // 
            // minmax
            // 
            this.minmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minmax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minmax.BackgroundImage")));
            this.minmax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minmax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minmax.FlatAppearance.BorderSize = 0;
            this.minmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minmax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.minmax.Location = new System.Drawing.Point(681, 0);
            this.minmax.Name = "minmax";
            this.minmax.Size = new System.Drawing.Size(37, 37);
            this.minmax.TabIndex = 461;
            this.minmax.TabStop = false;
            this.minmax.UseVisualStyleBackColor = true;
            this.minmax.Click += new System.EventHandler(this.minmax_Click);
            // 
            // mini
            // 
            this.mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mini.BackgroundImage")));
            this.mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini.FlatAppearance.BorderSize = 0;
            this.mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mini.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mini.Location = new System.Drawing.Point(638, 0);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(37, 37);
            this.mini.TabIndex = 460;
            this.mini.TabStop = false;
            this.mini.UseVisualStyleBackColor = true;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // konec
            // 
            this.konec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.konec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("konec.BackgroundImage")));
            this.konec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.konec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.konec.Enabled = false;
            this.konec.FlatAppearance.BorderSize = 0;
            this.konec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.konec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.konec.Location = new System.Drawing.Point(724, 0);
            this.konec.Name = "konec";
            this.konec.Size = new System.Drawing.Size(37, 37);
            this.konec.TabIndex = 462;
            this.konec.TabStop = false;
            this.konec.UseVisualStyleBackColor = true;
            this.konec.Click += new System.EventHandler(this.konecapi);
            // 
            // prvky_kontr
            // 
            this.prvky_kontr.Location = new System.Drawing.Point(22, 203);
            this.prvky_kontr.Name = "prvky_kontr";
            this.prvky_kontr.Size = new System.Drawing.Size(748, 10);
            this.prvky_kontr.TabIndex = 463;
            // 
            // prvky_down
            // 
            this.prvky_down.Location = new System.Drawing.Point(22, 261);
            this.prvky_down.Name = "prvky_down";
            this.prvky_down.Size = new System.Drawing.Size(748, 10);
            this.prvky_down.TabIndex = 463;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 464;
            this.label1.Text = "Průběh stahování:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 464;
            this.label2.Text = "Průběh kontroly";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(749, 88);
            this.label3.TabIndex = 464;
            this.label3.Text = "Program nyní zkontroluje všechny součásti programu. Pokud nenalezne součást, prog" +
    "ram ji sám stáhne. Tato akce může trvat několik minut.";
            // 
            // prvek
            // 
            this.prvek.AutoSize = true;
            this.prvek.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prvek.ForeColor = System.Drawing.Color.White;
            this.prvek.Location = new System.Drawing.Point(22, 118);
            this.prvek.Name = "prvek";
            this.prvek.Size = new System.Drawing.Size(85, 29);
            this.prvek.TabIndex = 464;
            this.prvek.Text = "Prvek:";
            // 
            // Procenta
            // 
            this.Procenta.AutoSize = true;
            this.Procenta.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Procenta.ForeColor = System.Drawing.Color.White;
            this.Procenta.Location = new System.Drawing.Point(243, 229);
            this.Procenta.Name = "Procenta";
            this.Procenta.Size = new System.Drawing.Size(0, 29);
            this.Procenta.TabIndex = 464;
            // 
            // panel_hlavni
            // 
            this.panel_hlavni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_hlavni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel_hlavni.Controls.Add(this.label3);
            this.panel_hlavni.Controls.Add(this.prvky_kontr);
            this.panel_hlavni.Controls.Add(this.prvek);
            this.panel_hlavni.Controls.Add(this.prvky_down);
            this.panel_hlavni.Controls.Add(this.Procenta);
            this.panel_hlavni.Controls.Add(this.label1);
            this.panel_hlavni.Controls.Add(this.label2);
            this.panel_hlavni.Location = new System.Drawing.Point(1, 39);
            this.panel_hlavni.Name = "panel_hlavni";
            this.panel_hlavni.Size = new System.Drawing.Size(814, 302);
            this.panel_hlavni.TabIndex = 465;
            // 
            // repair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(773, 303);
            this.Controls.Add(this.panel_hlavni);
            this.Controls.Add(this.minmax);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.konec);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.presunpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(793, 118);
            this.Name = "repair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opravný progarm";
            this.Shown += new System.EventHandler(this.kontrola);
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.panel_hlavni.ResumeLayout(false);
            this.panel_hlavni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label presunpanel;
        private System.Windows.Forms.Button minmax;
        private System.Windows.Forms.Button mini;
        private System.Windows.Forms.Button konec;
        private System.Windows.Forms.ProgressBar prvky_kontr;
        private System.Windows.Forms.ProgressBar prvky_down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prvek;
        private System.Windows.Forms.Label Procenta;
        private System.Windows.Forms.Panel panel_hlavni;
    }
}