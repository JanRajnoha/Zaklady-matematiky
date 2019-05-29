namespace Mate_version2
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            this.Title = new System.Windows.Forms.Label();
            this.presunpanel = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.temata = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cela = new System.Windows.Forms.CheckBox();
            this.cancel = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.icoprog = new System.Windows.Forms.PictureBox();
            this.minmax = new System.Windows.Forms.Button();
            this.mini = new System.Windows.Forms.Button();
            this.konec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
            this.SuspendLayout();
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
            this.Title.Size = new System.Drawing.Size(147, 33);
            this.Title.TabIndex = 422;
            this.Title.Text = "Nápověda";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pozice);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.presun);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spadnuti);
            // 
            // presunpanel
            // 
            this.presunpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presunpanel.BackColor = System.Drawing.Color.Black;
            this.presunpanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.presunpanel.Location = new System.Drawing.Point(0, 0);
            this.presunpanel.Name = "presunpanel";
            this.presunpanel.Size = new System.Drawing.Size(934, 40);
            this.presunpanel.TabIndex = 424;
            this.presunpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pozice);
            this.presunpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.presun);
            this.presunpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spadnuti);
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txt.Font = new System.Drawing.Font("Expo", 14.25F);
            this.txt.ForeColor = System.Drawing.Color.White;
            this.txt.Location = new System.Drawing.Point(302, 57);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(609, 453);
            this.txt.TabIndex = 425;
            this.txt.Text = "Vyberte si jedno z témat nápovědy.";
            this.txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
            // 
            // temata
            // 
            this.temata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.temata.Font = new System.Drawing.Font("Expo", 14.25F);
            this.temata.ForeColor = System.Drawing.Color.White;
            this.temata.FormattingEnabled = true;
            this.temata.ItemHeight = 26;
            this.temata.Items.AddRange(new object[] {
            "Obecné",
            "Test",
            "Nastavení",
            "Uživatelé",
            "Ukládání",
            "Aktualizace"});
            this.temata.Location = new System.Drawing.Point(12, 57);
            this.temata.Name = "temata";
            this.temata.Size = new System.Drawing.Size(284, 342);
            this.temata.TabIndex = 426;
            this.temata.Click += new System.EventHandler(this.zmena);
            this.temata.SelectedIndexChanged += new System.EventHandler(this.napoveda);
            this.temata.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.search.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(12, 474);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(239, 36);
            this.search.TabIndex = 1;
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Expo", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 429;
            this.label1.Text = "Vyhledat v nápovědě";
            // 
            // cela
            // 
            this.cela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cela.AutoSize = true;
            this.cela.Font = new System.Drawing.Font("Expo", 14.25F);
            this.cela.ForeColor = System.Drawing.Color.White;
            this.cela.Location = new System.Drawing.Point(12, 436);
            this.cela.Name = "cela";
            this.cela.Size = new System.Drawing.Size(196, 30);
            this.cela.TabIndex = 430;
            this.cela.Text = "V celé nápovědě";
            this.cela.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancel.BackgroundImage = global::Mate_version2.Properties.Resources.storno;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Propaganda", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(257, 436);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(39, 36);
            this.cancel.TabIndex = 428;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.storno);
            this.cancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.search_btn.BackgroundImage = global::Mate_version2.Properties.Resources.search;
            this.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.search_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Propaganda", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(257, 474);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(39, 36);
            this.search_btn.TabIndex = 428;
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.button1_Click);
            this.search_btn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
            // 
            // icoprog
            // 
            this.icoprog.BackColor = System.Drawing.Color.Black;
            this.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.help;
            this.icoprog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icoprog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.icoprog.Location = new System.Drawing.Point(3, 3);
            this.icoprog.Name = "icoprog";
            this.icoprog.Size = new System.Drawing.Size(32, 32);
            this.icoprog.TabIndex = 423;
            this.icoprog.TabStop = false;
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
            this.minmax.Location = new System.Drawing.Point(831, 0);
            this.minmax.Name = "minmax";
            this.minmax.Size = new System.Drawing.Size(37, 37);
            this.minmax.TabIndex = 420;
            this.minmax.TabStop = false;
            this.minmax.UseVisualStyleBackColor = true;
            this.minmax.Click += new System.EventHandler(this.minmax_Click);
            this.minmax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
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
            this.mini.Location = new System.Drawing.Point(788, 0);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(37, 37);
            this.mini.TabIndex = 419;
            this.mini.TabStop = false;
            this.mini.UseVisualStyleBackColor = true;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            this.mini.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
            // 
            // konec
            // 
            this.konec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.konec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("konec.BackgroundImage")));
            this.konec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.konec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.konec.FlatAppearance.BorderSize = 0;
            this.konec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.konec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.konec.Location = new System.Drawing.Point(874, 0);
            this.konec.Name = "konec";
            this.konec.Size = new System.Drawing.Size(37, 37);
            this.konec.TabIndex = 421;
            this.konec.TabStop = false;
            this.konec.UseVisualStyleBackColor = true;
            this.konec.Click += new System.EventHandler(this.konecapi);
            this.konec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(923, 505);
            this.Controls.Add(this.cela);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.temata);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.icoprog);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.minmax);
            this.Controls.Add(this.mini);
            this.Controls.Add(this.konec);
            this.Controls.Add(this.presunpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(939, 543);
            this.Name = "help";
            this.Text = "Nápověda";
            this.Load += new System.EventHandler(this.help_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zkratky);
            ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox icoprog;
        internal System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button minmax;
        private System.Windows.Forms.Button mini;
        private System.Windows.Forms.Button konec;
        private System.Windows.Forms.Label presunpanel;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.ListBox temata;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cela;
        private System.Windows.Forms.Button cancel;
    }
}