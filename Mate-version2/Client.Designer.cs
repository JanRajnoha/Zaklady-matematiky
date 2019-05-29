namespace Mate_version2
{
    using System;
    using System.Drawing;
    partial class client
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
        private void InitializeComponent(bool load)
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client));

            if (load == true)
            {
                this.Load_panel = new System.Windows.Forms.Panel();
                this.load1_lbl = new System.Windows.Forms.Label();
                this.load2_lbl = new System.Windows.Forms.Label();
                this.load3_lbl = new System.Windows.Forms.Label();
                this.load4_lbl = new System.Windows.Forms.Label();
                this.load_bar = new System.Windows.Forms.ProgressBar();
                this.load5_lbl = new System.Windows.Forms.Label();
                this.Load_panel.SuspendLayout();

                // 
                // Load_panel
                // 
                resources.ApplyResources(this.Load_panel, "Load_panel");
                this.Load_panel.Controls.Add(this.load_bar);
                this.Load_panel.Controls.Add(this.load5_lbl);
                this.Load_panel.Controls.Add(this.load4_lbl);
                this.Load_panel.Controls.Add(this.load3_lbl);
                this.Load_panel.Controls.Add(this.load2_lbl);
                this.Load_panel.Controls.Add(this.load1_lbl);
                this.Load_panel.Name = "Load_panel";

                //
                // load prvky
                //
                resources.ApplyResources(this.load1_lbl, "load1_lbl");
                this.load1_lbl.BackColor = System.Drawing.Color.Transparent;
                this.load1_lbl.ForeColor = System.Drawing.Color.White;
                this.load1_lbl.Name = "load1_lbl";
                resources.ApplyResources(this.load2_lbl, "load2_lbl");
                this.load2_lbl.BackColor = System.Drawing.Color.Transparent;
                this.load2_lbl.ForeColor = System.Drawing.Color.White;
                this.load2_lbl.Name = "load2_lbl";
                resources.ApplyResources(this.load3_lbl, "load3_lbl");
                this.load3_lbl.BackColor = System.Drawing.Color.Transparent;
                this.load3_lbl.ForeColor = System.Drawing.Color.White;
                this.load3_lbl.Name = "load3_lbl";
                this.load3_lbl.Text = "Vytvořeno: 2014";
                resources.ApplyResources(this.load4_lbl, "load4_lbl");
                this.load4_lbl.BackColor = System.Drawing.Color.Transparent;
                this.load4_lbl.ForeColor = System.Drawing.Color.White;
                this.load4_lbl.Name = "load4_lbl";
                resources.ApplyResources(this.load_bar, "load_bar");
                this.load_bar.Name = "load_bar";
                this.load_bar.Value = 0;
                this.load_bar.Visible = false;
                this.load_bar.Maximum = 272;
                this.load_bar.Size = new System.Drawing.Size(this.load_bar.Size.Width - 3, this.load_bar.Size.Height);
                resources.ApplyResources(this.load5_lbl, "load5_lbl");
                this.load5_lbl.BackColor = System.Drawing.Color.Transparent;
                this.load5_lbl.ForeColor = System.Drawing.Color.White;
                this.load5_lbl.Name = "load5_lbl";
                this.load5_lbl.Text = "Načítám aplikaci";
                this.load5_lbl.Refresh();
                this.wait = new System.Windows.Forms.Timer(this.components);
                wait.Tick += new EventHandler(this.wait_on_program);
                wait.Interval = 100;

                resources.ApplyResources(this, "$this");
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
                this.BackColor = System.Drawing.Color.Black;
                this.CancelButton = this.endbutton;
                this.ControlBox = false;
                this.DoubleBuffered = true;
                this.Size = new Size(757, 498);
                this.Controls.Add(this.Load_panel);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
                this.Shown += new System.EventHandler(this.load_program);
                this.Name = "client";
                this.Load_panel.ResumeLayout(false);
                this.Load_panel.PerformLayout();
                this.AllowDrop = true;
                this.KeyPreview = true;
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               // this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.program")));
            }
            else
            {
                this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
                this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
                this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
                this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
                this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
                this.helpanel = new System.Windows.Forms.Panel();
                this.dotace = new System.Windows.Forms.Button();
                this.napoveda = new System.Windows.Forms.Button();
                this.aplinfo = new System.Windows.Forms.Button();
                this.check_akt = new System.Windows.Forms.Button();
                this.generalpanel = new System.Windows.Forms.Panel();
                this.showuser = new System.Windows.Forms.Button();
                this.showset = new System.Windows.Forms.Button();
                this.close = new System.Windows.Forms.Button();
                this.showtest = new System.Windows.Forms.Button();
                this.Stavovyradek = new System.Windows.Forms.StatusStrip();
                this.User = new System.Windows.Forms.ToolStripStatusLabel();
                this.User_name = new System.Windows.Forms.ToolStripStatusLabel();
                this.statuslabel2 = new System.Windows.Forms.ToolStripStatusLabel();
                this.statuslabel3 = new System.Windows.Forms.ToolStripStatusLabel();
                this.time_status = new System.Windows.Forms.ToolStripStatusLabel();
                this.statuslabel4 = new System.Windows.Forms.ToolStripStatusLabel();
                this.Název = new System.Windows.Forms.ToolStripStatusLabel();
                this.statuslabel1 = new System.Windows.Forms.ToolStripStatusLabel();
                this.Link = new System.Windows.Forms.ToolStripStatusLabel();
                this.time = new System.Windows.Forms.NumericUpDown();
                this.label17 = new System.Windows.Forms.Label();
                this.last_time = new System.Windows.Forms.CheckBox();
                this.save_close = new System.Windows.Forms.Button();
                this.unsave = new System.Windows.Forms.Button();
                this.save = new System.Windows.Forms.Button();
                this.soucinitel = new System.Windows.Forms.NumericUpDown();
                this.label11 = new System.Windows.Forms.Label();
                this.delenec = new System.Windows.Forms.NumericUpDown();
                this.label12 = new System.Windows.Forms.Label();
                this.scitanec = new System.Windows.Forms.NumericUpDown();
                this.label14 = new System.Windows.Forms.Label();
                this.mensenec = new System.Windows.Forms.NumericUpDown();
                this.label15 = new System.Windows.Forms.Label();
                this.label18 = new System.Windows.Forms.Label();
                this.exercise = new System.Windows.Forms.NumericUpDown();
                this.nastavt = new System.Windows.Forms.RichTextBox();
                this.sound = new System.Windows.Forms.CheckBox();
                this.setpanel = new System.Windows.Forms.Panel();
                this.languages = new System.Windows.Forms.ListView();
                this.load_user_set = new System.Windows.Forms.Button();
                this.save_user_set = new System.Windows.Forms.Button();
                this.spravny_vys = new System.Windows.Forms.CheckBox();
                this.label19 = new System.Windows.Forms.Label();
                this.konec = new System.Windows.Forms.Button();
                this.mini = new System.Windows.Forms.Button();
                this.minmax = new System.Windows.Forms.Button();
                this.Title = new System.Windows.Forms.Label();
                this.icoprog = new System.Windows.Forms.PictureBox();
                this.nabidka_prog = new System.Windows.Forms.ContextMenuStrip(this.components);
                this.show_set_cms = new System.Windows.Forms.ToolStripMenuItem();
                this.show_test_cms = new System.Windows.Forms.ToolStripMenuItem();
                this.show_users_cms = new System.Windows.Forms.ToolStripMenuItem();
                this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
                this.check_akt_cms = new System.Windows.Forms.ToolStripMenuItem();
                this.help_cms = new System.Windows.Forms.ToolStripMenuItem();
                this.přispětToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
                this.aplinfo_cms = new System.Windows.Forms.ToolStripMenuItem();
                this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
                this.close_cms = new System.Windows.Forms.ToolStripMenuItem();
                this.presunpanel = new System.Windows.Forms.Label();
                this.ikonka = new System.Windows.Forms.NotifyIcon(this.components);
                this.odpocitavani = new System.Windows.Forms.Timer(this.components);
                this.workspace = new System.Windows.Forms.Panel();
                this.gen_menu = new System.Windows.Forms.Panel();
                this.general = new System.Windows.Forms.Button();
                this.help = new System.Windows.Forms.Button();
                this.set_panel = new System.Windows.Forms.Panel();
                this.krat = new System.Windows.Forms.Button();
                this.language = new System.Windows.Forms.Button();
                this.pocet_pr = new System.Windows.Forms.Button();
                this.odpocet = new System.Windows.Forms.Button();
                this.deleno = new System.Windows.Forms.Button();
                this.plus = new System.Windows.Forms.Button();
                this.minus = new System.Windows.Forms.Button();
                this.user_panel = new System.Windows.Forms.Panel();
                this.user_list = new System.Windows.Forms.Button();
                this.user_out = new System.Windows.Forms.Button();
                this.user_change = new System.Windows.Forms.Button();
                this.user_minus = new System.Windows.Forms.Button();
                this.user_plus = new System.Windows.Forms.Button();
                this.user_in = new System.Windows.Forms.Button();
                this.testpanel = new System.Windows.Forms.Panel();
                this.ri6 = new System.Windows.Forms.Label();
                this.vse = new System.Windows.Forms.RadioButton();
                this.label1 = new System.Windows.Forms.Label();
                this.le9 = new System.Windows.Forms.Label();
                this.rovn9 = new System.Windows.Forms.Label();
                this.nas = new System.Windows.Forms.RadioButton();
                this.prod10 = new System.Windows.Forms.NumericUpDown();
                this.ri9 = new System.Windows.Forms.Label();
                this.lomeno = new System.Windows.Forms.Label();
                this.prod9 = new System.Windows.Forms.NumericUpDown();
                this.od = new System.Windows.Forms.RadioButton();
                this.le10 = new System.Windows.Forms.Label();
                this.del = new System.Windows.Forms.RadioButton();
                this.ri8 = new System.Windows.Forms.Label();
                this.rovn10 = new System.Windows.Forms.Label();
                this.prod4 = new System.Windows.Forms.NumericUpDown();
                this.rovn8 = new System.Windows.Forms.Label();
                this.ri10 = new System.Windows.Forms.Label();
                this.prod1 = new System.Windows.Forms.NumericUpDown();
                this.le8 = new System.Windows.Forms.Label();
                this.last_time_num = new System.Windows.Forms.Label();
                this.zn7 = new System.Windows.Forms.Label();
                this.prod3 = new System.Windows.Forms.NumericUpDown();
                this.ri7 = new System.Windows.Forms.Label();
                this.last_time_label = new System.Windows.Forms.Label();
                this.zn8 = new System.Windows.Forms.Label();
                this.prod2 = new System.Windows.Forms.NumericUpDown();
                this.rovn7 = new System.Windows.Forms.Label();
                this.zn9 = new System.Windows.Forms.Label();
                this.le1 = new System.Windows.Forms.Label();
                this.le7 = new System.Windows.Forms.Label();
                this.zn10 = new System.Windows.Forms.Label();
                this.rovn1 = new System.Windows.Forms.Label();
                this.prod7 = new System.Windows.Forms.NumericUpDown();
                this.ri1 = new System.Windows.Forms.Label();
                this.prod8 = new System.Windows.Forms.NumericUpDown();
                this.le2 = new System.Windows.Forms.Label();
                this.rovn2 = new System.Windows.Forms.Label();
                this.prod18 = new System.Windows.Forms.NumericUpDown();
                this.le3 = new System.Windows.Forms.Label();
                this.prod17 = new System.Windows.Forms.NumericUpDown();
                this.rovn3 = new System.Windows.Forms.Label();
                this.le17 = new System.Windows.Forms.Label();
                this.ri3 = new System.Windows.Forms.Label();
                this.rovn17 = new System.Windows.Forms.Label();
                this.le4 = new System.Windows.Forms.Label();
                this.zn16 = new System.Windows.Forms.Label();
                this.ri17 = new System.Windows.Forms.Label();
                this.rovn4 = new System.Windows.Forms.Label();
                this.zn15 = new System.Windows.Forms.Label();
                this.le18 = new System.Windows.Forms.Label();
                this.ri4 = new System.Windows.Forms.Label();
                this.zn14 = new System.Windows.Forms.Label();
                this.rovn18 = new System.Windows.Forms.Label();
                this.prod5 = new System.Windows.Forms.NumericUpDown();
                this.zn13 = new System.Windows.Forms.Label();
                this.ri18 = new System.Windows.Forms.Label();
                this.prod6 = new System.Windows.Forms.NumericUpDown();
                this.zn12 = new System.Windows.Forms.Label();
                this.prod19 = new System.Windows.Forms.NumericUpDown();
                this.le5 = new System.Windows.Forms.Label();
                this.zn11 = new System.Windows.Forms.Label();
                this.prod20 = new System.Windows.Forms.NumericUpDown();
                this.rovn5 = new System.Windows.Forms.Label();
                this.ri16 = new System.Windows.Forms.Label();
                this.le19 = new System.Windows.Forms.Label();
                this.ri5 = new System.Windows.Forms.Label();
                this.rovn16 = new System.Windows.Forms.Label();
                this.rovn19 = new System.Windows.Forms.Label();
                this.le6 = new System.Windows.Forms.Label();
                this.le16 = new System.Windows.Forms.Label();
                this.ri19 = new System.Windows.Forms.Label();
                this.rovn6 = new System.Windows.Forms.Label();
                this.ri15 = new System.Windows.Forms.Label();
                this.le20 = new System.Windows.Forms.Label();
                this.rovn15 = new System.Windows.Forms.Label();
                this.TimeLabel = new System.Windows.Forms.Label();
                this.rovn20 = new System.Windows.Forms.Label();
                this.le15 = new System.Windows.Forms.Label();
                this.label21 = new System.Windows.Forms.Label();
                this.ri20 = new System.Windows.Forms.Label();
                this.label23 = new System.Windows.Forms.Label();
                this.prod16 = new System.Windows.Forms.NumericUpDown();
                this.sc = new System.Windows.Forms.RadioButton();
                this.zn17 = new System.Windows.Forms.Label();
                this.label25 = new System.Windows.Forms.Label();
                this.prod15 = new System.Windows.Forms.NumericUpDown();
                this.zn1 = new System.Windows.Forms.Label();
                this.zn18 = new System.Windows.Forms.Label();
                this.sprv20 = new System.Windows.Forms.Label();
                this.ri14 = new System.Windows.Forms.Label();
                this.zn2 = new System.Windows.Forms.Label();
                this.zn19 = new System.Windows.Forms.Label();
                this.sprv19 = new System.Windows.Forms.Label();
                this.rovn14 = new System.Windows.Forms.Label();
                this.zn20 = new System.Windows.Forms.Label();
                this.sprv18 = new System.Windows.Forms.Label();
                this.le14 = new System.Windows.Forms.Label();
                this.zn4 = new System.Windows.Forms.Label();
                this.sprv17 = new System.Windows.Forms.Label();
                this.ri13 = new System.Windows.Forms.Label();
                this.zn5 = new System.Windows.Forms.Label();
                this.sprv16 = new System.Windows.Forms.Label();
                this.rovn13 = new System.Windows.Forms.Label();
                this.zn6 = new System.Windows.Forms.Label();
                this.sprv15 = new System.Windows.Forms.Label();
                this.le13 = new System.Windows.Forms.Label();
                this.sprv14 = new System.Windows.Forms.Label();
                this.ri12 = new System.Windows.Forms.Label();
                this.sprv13 = new System.Windows.Forms.Label();
                this.rovn12 = new System.Windows.Forms.Label();
                this.sprv12 = new System.Windows.Forms.Label();
                this.le12 = new System.Windows.Forms.Label();
                this.sprv11 = new System.Windows.Forms.Label();
                this.ri11 = new System.Windows.Forms.Label();
                this.sprv1 = new System.Windows.Forms.Label();
                this.sprv10 = new System.Windows.Forms.Label();
                this.rovn11 = new System.Windows.Forms.Label();
                this.sprv2 = new System.Windows.Forms.Label();
                this.sprv9 = new System.Windows.Forms.Label();
                this.le11 = new System.Windows.Forms.Label();
                this.sprv3 = new System.Windows.Forms.Label();
                this.sprv8 = new System.Windows.Forms.Label();
                this.prod12 = new System.Windows.Forms.NumericUpDown();
                this.sprv4 = new System.Windows.Forms.Label();
                this.sprv7 = new System.Windows.Forms.Label();
                this.prod13 = new System.Windows.Forms.NumericUpDown();
                this.prod14 = new System.Windows.Forms.NumericUpDown();
                this.sprv5 = new System.Windows.Forms.Label();
                this.sprv6 = new System.Windows.Forms.Label();
                this.prod11 = new System.Windows.Forms.NumericUpDown();
                this.StartButton = new System.Windows.Forms.Button();
                this.endbutton = new System.Windows.Forms.Button();
                this.zn3 = new System.Windows.Forms.Label();
                this.ri2 = new System.Windows.Forms.Label();
                this.Userspanel = new System.Windows.Forms.Panel();
                this.back = new System.Windows.Forms.Button();
                this.Login_btn = new System.Windows.Forms.Button();
                this.Logout = new System.Windows.Forms.Button();
                this.uzivatele = new System.Windows.Forms.ListBox();
                this.deleteusers = new System.Windows.Forms.Button();
                this.createusers = new System.Windows.Forms.Button();
                this.label31 = new System.Windows.Forms.Label();
                this.changepass = new System.Windows.Forms.Button();
                this.Open_jpg = new System.Windows.Forms.OpenFileDialog();
                this.label13 = new System.Windows.Forms.Label();
                this.chng_m_clr = new System.Windows.Forms.Button();
                this.chng_prg_clr = new System.Windows.Forms.Button();
                this.chng_prg_jpg = new System.Windows.Forms.Button();
                this.Open_clr = new System.Windows.Forms.ColorDialog();
                this.show_result = new System.Windows.Forms.Button();
                this.vysledek_dat = new System.Windows.Forms.ListBox();
                this.label32 = new System.Windows.Forms.Label();
                this.popisek = new System.Windows.Forms.ToolTip(this.components);

                load5_lbl.Text = "Inicializace prvků byla hotova. Načítám prvky do aplikace.";
                load5_lbl.Refresh();
                load_bar.Increment(1);

                this.helpanel.SuspendLayout();
                this.generalpanel.SuspendLayout();
                this.Stavovyradek.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.soucinitel)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.delenec)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.scitanec)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.mensenec)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.exercise)).BeginInit();
                this.setpanel.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.icoprog)).BeginInit();
                this.nabidka_prog.SuspendLayout();
                this.workspace.SuspendLayout();
                this.gen_menu.SuspendLayout();
                this.set_panel.SuspendLayout();
                this.user_panel.SuspendLayout();
                this.testpanel.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.prod10)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod9)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod4)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod3)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod2)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod7)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod8)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod18)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod17)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod5)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod6)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod19)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod20)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod16)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod15)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod12)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod13)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod14)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod11)).BeginInit();
                this.Userspanel.SuspendLayout();
                this.SuspendLayout();
                // 
                // presunpanel
                // 
                load_bar.Increment(1);
                this.presunpanel.BackColor = Color.Transparent;
                resources.ApplyResources(this.presunpanel, "presunpanel");
                this.presunpanel.Name = "presunpanel";
                this.presunpanel.Size = new Size(1200, 39);
                this.presunpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pozice);
                this.presunpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.presun);
                this.presunpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spadnuti);
                this.presunpanel.DoubleClick += new EventHandler(this.maximalizace);
                // 
                // Stavovyradek
                // 
                load_bar.Increment(1);
                this.Stavovyradek.BackColor = Color.Transparent;
                this.Stavovyradek.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    this.User,
                    this.User_name,
                    this.statuslabel2,
                    this.statuslabel3,
                    this.time_status,
                    this.statuslabel4,
                    this.Název,
                    this.statuslabel1,
                    this.Link});
                resources.ApplyResources(this.Stavovyradek, "Stavovyradek");
                this.Stavovyradek.Name = "Stavovyradek";
                this.Stavovyradek.SizingGrip = false;
                // 
                // gen_menu
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.gen_menu, "gen_menu");
                this.gen_menu.BackColor = System.Drawing.Color.Transparent;
                this.gen_menu.Location = new Point(0, 38);
                this.gen_menu.Size = new Size(gen_menu.Size.Width, Stavovyradek.Location.Y - presunpanel.Size.Height + 21);
                this.gen_menu.Controls.Add(this.general);
                this.gen_menu.Controls.Add(this.help);
                this.gen_menu.Name = "gen_menu";
                // 
                // helpanel
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.helpanel, "helpanel");
                this.helpanel.BackColor = Color.Transparent;
                this.helpanel.Controls.Add(this.dotace);
                this.helpanel.Location = new Point(45, 38);
                this.helpanel.Size = new Size(gen_menu.Size.Width, Stavovyradek.Location.Y - presunpanel.Size.Height + 21);
                this.helpanel.Controls.Add(this.napoveda);
                this.helpanel.Controls.Add(this.aplinfo);
                this.helpanel.Controls.Add(this.check_akt);
                this.helpanel.Name = "helpanel";
                // 
                // dotace
                // 
                load_bar.Increment(1);
                this.dotace.BackColor = System.Drawing.Color.Transparent;
                this.dotace.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\donate.png");
                resources.ApplyResources(this.dotace, "dotace");
                this.dotace.Cursor = System.Windows.Forms.Cursors.Hand;
                this.dotace.FlatAppearance.BorderSize = 0;
                this.dotace.MouseEnter += new EventHandler(this.popisky);
                this.dotace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.dotace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.dotace.ForeColor = System.Drawing.Color.Transparent;
                this.dotace.Name = "dotace";
                this.dotace.UseVisualStyleBackColor = false;
                this.dotace.Click += new System.EventHandler(this.dotovani);
                // 
                // napoveda
                // 
                load_bar.Increment(1);
                this.napoveda.BackColor = System.Drawing.Color.Transparent;
                resources.ApplyResources(this.napoveda, "napoveda");
                this.napoveda.Cursor = System.Windows.Forms.Cursors.Hand;
                this.napoveda.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\help.png"); 
                this.napoveda.FlatAppearance.BorderSize = 0;
                this.napoveda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.napoveda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.napoveda.ForeColor = System.Drawing.Color.Transparent;
                this.napoveda.Name = "napoveda";
                this.napoveda.UseVisualStyleBackColor = false;
                this.napoveda.Click += new System.EventHandler(this.helper);
                this.napoveda.MouseEnter += new EventHandler(this.popisky);
                // 
                // aplinfo
                // 
                load_bar.Increment(1);
                this.aplinfo.BackColor = System.Drawing.Color.Transparent;
                resources.ApplyResources(this.aplinfo, "aplinfo");
                this.aplinfo.Cursor = System.Windows.Forms.Cursors.Hand;
                this.aplinfo.FlatAppearance.BorderSize = 0;
                this.aplinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.aplinfo.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\aplinfo.png");
                this.aplinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.aplinfo.ForeColor = System.Drawing.Color.Transparent;
                this.aplinfo.Name = "aplinfo";
                this.aplinfo.UseVisualStyleBackColor = false;
                this.aplinfo.Click += new System.EventHandler(this.aplinfo_click);
                this.aplinfo.MouseEnter += new EventHandler(this.popisky);
                // 
                // check_akt
                // 
                load_bar.Increment(1);
                this.check_akt.BackColor = System.Drawing.Color.Transparent;
                this.check_akt.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\aktualizace.png");
                resources.ApplyResources(this.check_akt, "check_akt");
                this.check_akt.Cursor = System.Windows.Forms.Cursors.Hand;
                this.check_akt.FlatAppearance.BorderSize = 0;
                this.check_akt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.check_akt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.check_akt.ForeColor = System.Drawing.Color.Transparent;
                this.check_akt.Name = "check_akt";
                this.check_akt.UseVisualStyleBackColor = false;
                this.check_akt.Click += new System.EventHandler(this.aktualizace);
                this.check_akt.MouseEnter += new EventHandler(this.popisky);
                // 
                // generalpanel
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.generalpanel, "generalpanel");
                this.generalpanel.BackColor = Color.Transparent;
                this.generalpanel.Controls.Add(this.showuser);
                this.generalpanel.Controls.Add(this.showset);
                this.generalpanel.Location = new Point(45, 38);
                this.generalpanel.Size = new Size(gen_menu.Size.Width, Stavovyradek.Location.Y - presunpanel.Size.Height + 21);
                this.generalpanel.Controls.Add(this.close);
                this.generalpanel.Controls.Add(this.showtest);
                this.generalpanel.Name = "generalpanel";
                // 
                // showuser
                // 
                load_bar.Increment(1);
                this.showuser.BackColor = System.Drawing.Color.Transparent;
                this.showuser.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\gen.png");
                resources.ApplyResources(this.showuser, "showuser");
                this.showuser.Cursor = System.Windows.Forms.Cursors.Hand;
                this.showuser.FlatAppearance.BorderSize = 0;
                this.showuser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.showuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.showuser.ForeColor = System.Drawing.Color.White;
                this.showuser.Name = "showuser";
                this.showuser.UseVisualStyleBackColor = false;
                this.showuser.Click += new System.EventHandler(this.zobraz_users);
                this.showuser.MouseEnter += new System.EventHandler(this.zobraz);
                this.showuser.MouseEnter += new EventHandler(this.popisky);
                // 
                // showset
                // 
                load_bar.Increment(1);
                this.showset.BackColor = System.Drawing.Color.Transparent;
                this.showset.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\set.png");
                resources.ApplyResources(this.showset, "showset");
                this.showset.Cursor = System.Windows.Forms.Cursors.Hand;
                this.showset.FlatAppearance.BorderSize = 0;
                this.showset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.showset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.showset.ForeColor = System.Drawing.Color.White;
                this.showset.Name = "showset";
                this.showset.UseVisualStyleBackColor = false;
                this.showset.Click += new System.EventHandler(this.zobraz_set);
                this.showset.MouseEnter += new System.EventHandler(this.zobraz);
                this.showset.MouseEnter += new EventHandler(this.popisky);
                // 
                // close
                // 
                load_bar.Increment(1);
                this.close.BackColor = System.Drawing.Color.Transparent;
                this.close.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\close.png");
                resources.ApplyResources(this.close, "close");
                this.close.Cursor = System.Windows.Forms.Cursors.Hand;
                this.close.FlatAppearance.BorderSize = 0;
                this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.close.ForeColor = System.Drawing.Color.White;
                this.close.Name = "close";
                this.close.UseVisualStyleBackColor = false;
                this.close.Click += new System.EventHandler(this.konecapi);
                this.close.MouseEnter += new System.EventHandler(this.zobraz);
                this.close.MouseEnter += new EventHandler(this.popisky);
                // 
                // showtest
                // 
                load_bar.Increment(1);
                this.showtest.BackColor = System.Drawing.Color.Transparent;
                this.showtest.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\main_program.png");
                resources.ApplyResources(this.showtest, "showtest");
                this.showtest.Cursor = System.Windows.Forms.Cursors.Hand;
                this.showtest.FlatAppearance.BorderSize = 0;
                this.showtest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.showtest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.showtest.ForeColor = System.Drawing.Color.White;
                this.showtest.Name = "showtest";
                this.showtest.UseVisualStyleBackColor = false;
                this.showtest.Click += new System.EventHandler(this.zobraz_test);
                this.showtest.MouseEnter += new System.EventHandler(this.zobraz);
                this.showtest.MouseEnter += new EventHandler(this.popisky);
                // 
                // User
                // 
                load_bar.Increment(1);
                this.User.ForeColor = System.Drawing.Color.White;
                this.User.Name = "User";
                this.User.Click += new EventHandler(this.Log_in_system);
                this.User.DoubleClick += new EventHandler(this.Log_in_system);
                resources.ApplyResources(this.User, "User");
                // 
                // User_name
                // 
                load_bar.Increment(1);
                this.User_name.ForeColor = System.Drawing.Color.White;
                this.User_name.Name = "User_name";
                this.User_name.Click += new EventHandler(this.Log_in_system);
                this.User_name.DoubleClick += new EventHandler(this.Log_in_system);
                resources.ApplyResources(this.User_name, "User_name");
                // 
                // statuslabel2
                // 
                load_bar.Increment(1);
                this.statuslabel2.Name = "statuslabel2";
                resources.ApplyResources(this.statuslabel2, "statuslabel2");
                // 
                // statuslabel3
                // 
                load_bar.Increment(1);
                this.statuslabel3.ForeColor = System.Drawing.Color.White;
                this.statuslabel3.Name = "statuslabel3";
                resources.ApplyResources(this.statuslabel3, "statuslabel3");
                // 
                // time_status
                // 
                load_bar.Increment(1);
                this.time_status.ForeColor = System.Drawing.Color.White;
                this.time_status.Name = "time_status";
                resources.ApplyResources(this.time_status, "time_status");
                // 
                // statuslabel4
                // 
                load_bar.Increment(1);
                this.statuslabel4.Name = "statuslabel4";
                resources.ApplyResources(this.statuslabel4, "statuslabel4");
                // 
                // Název
                // 
          //      load_bar.Increment(1);
            //    this.Název.ForeColor = System.Drawing.Color.White;
              //  this.Název.Name = "Název";
                //resources.ApplyResources(this.Název, "Název");
                // 
                // statuslabel1
                // 
                load_bar.Increment(1);
                this.statuslabel1.Name = "statuslabel1";
                resources.ApplyResources(this.statuslabel1, "statuslabel1");
                // 
                // Link
                // 
                load_bar.Increment(1);
                this.Link.ActiveLinkColor = System.Drawing.Color.Yellow;
                resources.ApplyResources(this.Link, "Link");
                this.Link.ForeColor = System.Drawing.Color.Lime;
                this.Link.LinkColor = System.Drawing.Color.Lime;
                this.Link.Name = "Link";
                this.Link.VisitedLinkColor = System.Drawing.Color.Cyan;
                this.Link.Click += new System.EventHandler(this.link_Click);
                // 
                // time
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.time, "time");
                this.time.ForeColor = System.Drawing.Color.Black;
                this.time.Maximum = new decimal(new int[] {
                    100000,
                    0,
                    0,
                    0});
                this.time.Minimum = new decimal(new int[] {
                    3,
                    0,
                    0,
                    0});
                this.time.Name = "time";
                this.time.Value = new decimal(new int[] {
                    60,
                    0,
                    0,
                    0});
                this.time.ValueChanged += new System.EventHandler(this.value_zmena);
                this.time.Location = new Point(this.time.Location.X + 25, this.time.Location.Y);
                // 
                // label17
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label17, "label17");
                this.label17.ForeColor = System.Drawing.Color.White;
                this.label17.Name = "label17";
                // 
                // last_time
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.last_time, "last_time");
                this.last_time.ForeColor = System.Drawing.Color.White;
                this.last_time.Name = "last_time";
                this.last_time.UseVisualStyleBackColor = true;
                this.last_time.CheckedChanged += new System.EventHandler(this.value_zmena);
                // 
                // save_close
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.save_close, "save_close");
                this.save_close.Location = new Point(390, 510);
                this.save_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.save_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.save_close.ForeColor = System.Drawing.Color.White;
                this.save_close.Name = "save_close";
                this.save_close.UseVisualStyleBackColor = true;
                this.save_close.Click += new System.EventHandler(this.save_close_Click);
                // 
                // unsave
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.unsave, "unsave");
                this.unsave.Location = new Point(621, 510);
                this.unsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.unsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.unsave.ForeColor = System.Drawing.Color.White;
                this.unsave.Name = "unsave";
                this.unsave.UseVisualStyleBackColor = true;
                this.unsave.Click += new System.EventHandler(this.unsave_Click);
                // 
                // save
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.save, "save");
                this.save.Location = new Point(236, 510);
                this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.save.ForeColor = System.Drawing.Color.White;
                this.save.Name = "save";
                this.save.UseVisualStyleBackColor = true;
                this.save.Click += new System.EventHandler(this.save_Click);
                // 
                // soucinitel
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.soucinitel, "soucinitel");
                this.soucinitel.ForeColor = System.Drawing.Color.Black;
                this.soucinitel.Maximum = new decimal(new int[] {
                    1000,
                    0,
                    0,
                    0});
                this.soucinitel.Minimum = new decimal(new int[] {
                    4,
                    0,
                    0,
                    0});
                this.soucinitel.Name = "soucinitel";
                this.soucinitel.Value = new decimal(new int[] {
                    10,
                    0,
                    0,
                    0});
                this.soucinitel.ValueChanged += new System.EventHandler(this.value_zmena);
                this.soucinitel.Location = new Point(this.soucinitel.Location.X + 25, this.soucinitel.Location.Y);
                // 
                // label11
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label11, "label11");
                this.label11.ForeColor = System.Drawing.Color.White;
                this.label11.Name = "label11";
                // 
                // delenec
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.delenec, "delenec");
                this.delenec.ForeColor = System.Drawing.Color.Black;
                this.delenec.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.delenec.Name = "delenec";
                this.delenec.Value = new decimal(new int[] {
                    100,
                    0,
                    0,
                    0});
                this.delenec.ValueChanged += new System.EventHandler(this.value_zmena);
                this.delenec.Location = new Point(this.delenec.Location.X + 25, this.delenec.Location.Y);
                // 
                // label12
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label12, "label12");
                this.label12.ForeColor = System.Drawing.Color.White;
                this.label12.Name = "label12";
                // 
                // scitanec
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.scitanec, "scitanec");
                this.scitanec.ForeColor = System.Drawing.Color.Black;
                this.scitanec.Maximum = new decimal(new int[] {
                    500000,
                    0,
                    0,
                    0});
                this.scitanec.Minimum = new decimal(new int[] {
                    5,
                    0,
                    0,
                    0});
                this.scitanec.Name = "scitanec";
                this.scitanec.Value = new decimal(new int[] {
                    50,
                    0,
                    0,
                    0});
                this.scitanec.ValueChanged += new System.EventHandler(this.value_zmena);
                this.scitanec.Location = new Point(this.scitanec.Location.X + 15, this.scitanec.Location.Y);
                // 
                // label14
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label14, "label14");
                this.label14.ForeColor = System.Drawing.Color.White;
                this.label14.Name = "label14";
                // 
                // mensenec
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.mensenec, "mensenec");
                this.mensenec.ForeColor = System.Drawing.Color.Black;
                this.mensenec.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.mensenec.Minimum = new decimal(new int[] {
                    10,
                    0,
                    0,
                    0});
                this.mensenec.Name = "mensenec";
                this.mensenec.Value = new decimal(new int[] {
                    100,
                    0,
                    0,
                    0});
                this.mensenec.ValueChanged += new System.EventHandler(this.value_zmena);
                this.mensenec.Location = new Point(this.mensenec.Location.X + 15, this.mensenec.Location.Y);
                // 
                // label15
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label15, "label15");
                this.label15.ForeColor = System.Drawing.Color.White;
                this.label15.Name = "label15";
                // 
                // label18
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label18, "label18");
                this.label18.ForeColor = System.Drawing.Color.White;
                this.label18.Name = "label18";
                // 
                // exercise
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.exercise, "exercise");
                this.exercise.ForeColor = System.Drawing.Color.Black;
                this.exercise.Maximum = new decimal(new int[] {
                    20,
                    0,
                    0,
                    0});
                this.exercise.Minimum = new decimal(new int[] {
                    1,
                    0,
                    0,
                    0});
                this.exercise.Name = "exercise";
                this.exercise.Value = new decimal(new int[] {
                    20,
                    0,
                    0,
                    0});
                this.exercise.ValueChanged += new System.EventHandler(this.value_zmena);
                this.exercise.Location = new Point(this.exercise.Location.X + 15, this.exercise.Location.Y);
                // 
                // nastavt
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.nastavt, "nastavt");
                this.nastavt.Name = "nastavt";
                this.nastavt.ReadOnly = true;
                this.nastavt.Location = new Point(739, 237);
                // 
                // sound
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sound, "sound");
                this.sound.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
                this.sound.ForeColor = System.Drawing.Color.White;
                this.sound.Name = "sound";
                this.sound.UseVisualStyleBackColor = true;
                this.sound.CheckedChanged += new System.EventHandler(this.value_zmena);
                // 
                // setpanel
                // 
                load_bar.Increment(1);
                this.setpanel.BackColor = System.Drawing.Color.Transparent;
                this.setpanel.Controls.Add(this.languages);
                this.setpanel.Controls.Add(this.load_user_set);
                this.setpanel.Controls.Add(this.chng_prg_clr);
                this.setpanel.Controls.Add(this.chng_prg_jpg);
                this.setpanel.Controls.Add(this.chng_m_clr);
                this.setpanel.Controls.Add(this.save_user_set);
                this.setpanel.Controls.Add(this.spravny_vys);
                this.setpanel.Controls.Add(this.sound);
                this.setpanel.Controls.Add(this.exercise);
                this.setpanel.Controls.Add(this.label19);
                this.setpanel.Controls.Add(this.label18);
                this.setpanel.Controls.Add(this.label15);
                this.setpanel.Controls.Add(this.mensenec);
                this.setpanel.Controls.Add(this.label14);
                this.setpanel.Controls.Add(this.label13);
                this.setpanel.Controls.Add(this.scitanec);
                this.setpanel.Controls.Add(this.label12);
                this.setpanel.Controls.Add(this.delenec);
                this.setpanel.Controls.Add(this.label11);
                this.setpanel.Controls.Add(this.soucinitel);
                this.setpanel.Controls.Add(this.save);
                this.setpanel.Controls.Add(this.unsave);
                this.setpanel.Controls.Add(this.save_close);
                this.setpanel.Controls.Add(this.last_time);
                this.setpanel.Controls.Add(this.label17);
                this.setpanel.Controls.Add(this.time);
                this.setpanel.Controls.Add(this.nastavt);
                this.setpanel.ForeColor = System.Drawing.Color.Black;
                resources.ApplyResources(this.setpanel, "setpanel");
                this.setpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.setpanel.Name = "setpanel";
                this.setpanel.Size = new Size(1104, 554);
                this.setpanel.Click += new System.EventHandler(this.zmiz);
                // 
                // languages
                // 
                load_bar.Increment(1);
                this.languages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
                this.languages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                resources.ApplyResources(this.languages, "languages");
                this.languages.MultiSelect = false;
                this.languages.Name = "languages";
                this.languages.Sorting = System.Windows.Forms.SortOrder.Ascending;
                this.languages.UseCompatibleStateImageBehavior = false;
                this.languages.View = System.Windows.Forms.View.Tile;
                this.languages.Click += new EventHandler(this.zmiz);
                this.languages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
                this.languages.ItemActivate += new System.EventHandler(this.change_lang);
                // 
                // label13
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label13, "label13");
                this.label13.ForeColor = System.Drawing.Color.White;
                this.label13.Name = "label13";
                this.label13.AutoSize = true;
                this.label13.Text = "Nastavení schéma programu";
                this.label13.Location = new Point(12, 390);
                this.label13.Font = new System.Drawing.Font("Expo", 14.249f);
                // 
                // chng_m_clr
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.chng_m_clr, "chng_m_clr");
                this.chng_m_clr.Location = new Point(17, 419);
                this.chng_m_clr.Size = new Size(296, 27);
                this.chng_m_clr.Text = "Menu - barva";
                this.chng_m_clr.Font = new System.Drawing.Font("Propaganda", 9.749f);
                this.chng_m_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.chng_m_clr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.chng_m_clr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.chng_m_clr.ForeColor = System.Drawing.Color.White;
                this.chng_m_clr.Name = "chng_m_clr";
                this.chng_m_clr.UseVisualStyleBackColor = true;
                this.chng_m_clr.Click += new System.EventHandler(this.set_m_clr);
                // 
                // chng_prg_jpg
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.chng_prg_jpg, "chng_prg_jpg");
                this.chng_prg_jpg.Location = new Point(319, 419);
                this.chng_prg_jpg.Size = new Size(296, 27);
                this.chng_prg_jpg.Font = new System.Drawing.Font("Propaganda", 9.749f);
                this.chng_prg_jpg.Text = "Program - obrázek na pozadí";
                this.chng_prg_jpg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.chng_prg_jpg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.chng_prg_jpg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.chng_prg_jpg.ForeColor = System.Drawing.Color.White;
                this.chng_prg_jpg.Name = "chng_prg_jpg";
                this.chng_prg_jpg.UseVisualStyleBackColor = true;
                this.chng_prg_jpg.Click += new System.EventHandler(this.set_prg_jpg);
                // 
                // chng_prg_clr
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.chng_prg_clr, "chng_prg_clr");
                this.chng_prg_clr.Location = new Point(623, 419);
                this.chng_prg_clr.Size = new Size(296, 27);
                this.chng_prg_clr.Text = "program - barva";
                this.chng_prg_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.chng_prg_clr.Font = new System.Drawing.Font("Propaganda", 9.749f);
                this.chng_prg_clr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.chng_prg_clr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.chng_prg_clr.ForeColor = System.Drawing.Color.White;
                this.chng_prg_clr.Name = "chng_prg_clr";
                this.chng_prg_clr.UseVisualStyleBackColor = true;
                this.chng_prg_clr.Click += new System.EventHandler(this.set_prg_clr);
                // 
                // load_user_set
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.load_user_set, "load_user_set");
                this.load_user_set.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.load_user_set.Location = new Point(538, 477);
                this.load_user_set.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.load_user_set.ForeColor = System.Drawing.Color.White;
                this.load_user_set.Name = "load_user_set";
                this.load_user_set.UseVisualStyleBackColor = true;
                this.load_user_set.Click += new System.EventHandler(this.load_set);
                // 
                // save_user_set
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.save_user_set, "save_user_set");
                this.save_user_set.Location = new Point(236, 477);
                this.save_user_set.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.save_user_set.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.save_user_set.ForeColor = System.Drawing.Color.White;
                this.save_user_set.Name = "save_user_set";
                this.save_user_set.UseVisualStyleBackColor = true;
                this.save_user_set.Click += new System.EventHandler(this.save_set);
                // 
                // spravny_vys
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.spravny_vys, "spravny_vys");
                this.spravny_vys.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
                this.spravny_vys.ForeColor = System.Drawing.Color.White;
                this.spravny_vys.Name = "spravny_vys";
                this.spravny_vys.UseVisualStyleBackColor = true;
                this.spravny_vys.CheckedChanged += new System.EventHandler(this.value_zmena);
                this.spravny_vys.Visible = false;
                // 
                // label19
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label19, "label19");
                this.label19.ForeColor = System.Drawing.Color.White;
                this.label19.Name = "label19";
                // 
                // konec
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.konec, "konec");
                this.konec.BackColor = Color.Transparent;
                this.konec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.konec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.konec.Cursor = System.Windows.Forms.Cursors.Hand;
                this.konec.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\close.png");
                this.konec.FlatAppearance.BorderSize = 0;
                this.konec.Name = "konec";
                this.konec.TabStop = false;
                this.konec.UseVisualStyleBackColor = true;
                this.konec.Click += new System.EventHandler(this.konecapi);
                this.konec.MouseEnter += new EventHandler(this.popisky);
                // 
                // mini
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.mini, "mini");
                this.mini.BackColor = Color.Transparent;
                this.mini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.mini.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\minimum.png");
                this.mini.Cursor = System.Windows.Forms.Cursors.Hand;
                this.mini.FlatAppearance.BorderSize = 0;
                this.mini.Name = "mini";
                this.mini.TabStop = false;
                this.mini.UseVisualStyleBackColor = true;
                this.mini.Click += new System.EventHandler(this.mini_Click);
                this.mini.MouseEnter += new EventHandler(this.popisky);
                // 
                // minmax
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.minmax, "minmax");
                this.minmax.BackColor = Color.Transparent;
                this.minmax.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\MAX.png");
                this.minmax.Cursor = System.Windows.Forms.Cursors.Hand;
                this.minmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.minmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.minmax.FlatAppearance.BorderSize = 0;
                this.minmax.Name = "minmax";
                this.minmax.TabStop = false;
                this.minmax.UseVisualStyleBackColor = true;
                this.minmax.Click += new System.EventHandler(this.minmax_Click);
                this.minmax.MouseEnter += new EventHandler(this.popisky);
                // 
                // Title
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.Title, "Title");
                this.Title.BackColor = Color.Transparent;
                this.Title.ForeColor = System.Drawing.Color.White;
                this.Title.Name = "Title";
                this.Title.Text = "Logout";
                this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pozice);
                this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.presun);
                this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spadnuti);
                this.Title.DoubleClick += new EventHandler(this.maximalizace);
                // 
                // icoprog
                // 
                load_bar.Increment(1);
                this.icoprog.BackColor = Color.Transparent;
                resources.ApplyResources(this.icoprog, "icoprog");
                this.icoprog.ContextMenuStrip = this.nabidka_prog;
                this.icoprog.Name = "icoprog";
                this.icoprog.TabStop = false;
                this.icoprog.DoubleClick += new System.EventHandler(this.konecapi);
                // 
                // nabidka_prog
                // 
                load_bar.Increment(1);
                this.nabidka_prog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    this.show_set_cms,
                    this.show_test_cms,
                    this.show_users_cms,
                    this.toolStripSeparator1,
                    this.check_akt_cms,
                    this.help_cms,
                    this.přispětToolStripMenuItem,
                    this.aplinfo_cms,
                    this.toolStripSeparator2,
                    this.close_cms});
                this.nabidka_prog.Name = "contextMenuStrip1";
                resources.ApplyResources(this.nabidka_prog, "nabidka_prog");
                // 
                // show_set_cms
                // 
                load_bar.Increment(1);
                this.show_set_cms.Name = "show_set_cms";
                resources.ApplyResources(this.show_set_cms, "show_set_cms");
                this.show_set_cms.Click += new System.EventHandler(this.zobraz_set);
                // 
                // show_test_cms
                //
                load_bar.Increment(1); 
                this.show_test_cms.Name = "show_test_cms";
                resources.ApplyResources(this.show_test_cms, "show_test_cms");
                this.show_test_cms.Click += new System.EventHandler(this.zobraz_test);
                // 
                // show_users_cms
                // 
                load_bar.Increment(1);
                this.show_users_cms.Name = "show_users_cms";
                resources.ApplyResources(this.show_users_cms, "show_users_cms");
                this.show_users_cms.Click += new System.EventHandler(this.zobraz_users);
                // 
                // toolStripSeparator1
                // 
                load_bar.Increment(1);
                this.toolStripSeparator1.Name = "toolStripSeparator1";
                resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
                // 
                // check_akt_cms
                // 
                load_bar.Increment(1);
                this.check_akt_cms.Name = "check_akt_cms";
                resources.ApplyResources(this.check_akt_cms, "check_akt_cms");
                this.check_akt_cms.Click += new System.EventHandler(this.aktualizace);
                // 
                // help_cms
                // 
                load_bar.Increment(1);
                this.help_cms.Name = "help_cms";
                resources.ApplyResources(this.help_cms, "help_cms");
                this.help_cms.Click += new System.EventHandler(this.helper);
                // 
                // přispětToolStripMenuItem
                // 
                load_bar.Increment(1);
                this.přispětToolStripMenuItem.Name = "přispětToolStripMenuItem";
                resources.ApplyResources(this.přispětToolStripMenuItem, "přispětToolStripMenuItem");
                this.přispětToolStripMenuItem.Click += new System.EventHandler(this.dotovani);
                // 
                // aplinfo_cms
                // 
                load_bar.Increment(1);
                this.aplinfo_cms.Name = "aplinfo_cms";
                resources.ApplyResources(this.aplinfo_cms, "aplinfo_cms");
                this.aplinfo_cms.Click += new System.EventHandler(this.aplinfo_click);
                // 
                // toolStripSeparator2
                // 
                load_bar.Increment(1);
                this.toolStripSeparator2.Name = "toolStripSeparator2";
                resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
                // 
                // close_cms
                // 
                load_bar.Increment(1);
                this.close_cms.Name = "close_cms";
                resources.ApplyResources(this.close_cms, "close_cms");
                this.close_cms.Click += new System.EventHandler(this.konecapi);
                // 
                // ikonka
                // 
                load_bar.Increment(1);
                this.ikonka.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
                this.ikonka.ContextMenuStrip = this.nabidka_prog;
                resources.ApplyResources(this.ikonka, "ikonka");
                this.ikonka.BalloonTipClicked += new System.EventHandler(this.aktualizace);
                this.ikonka.DoubleClick += new System.EventHandler(this.ikonka_DoubleClick);
                // 
                // odpocitavani
                // 
                load_bar.Increment(1);
                this.odpocitavani.Interval = 1000;
                this.odpocitavani.Tick += new System.EventHandler(this.Tick);
                // 
                // workspace
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.workspace, "workspace");
                this.workspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.workspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
                this.workspace.Controls.Add(this.setpanel);
                this.workspace.Size = new Size(Stavovyradek.Size.Width + 12, this.Size.Height);
                this.workspace.Controls.Add(this.testpanel);
                this.workspace.Controls.Add(this.Userspanel);
                this.workspace.Name = "workspace";
                this.workspace.Click += new EventHandler(this.zmiz);
                // 
                // general
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.general, "general");
                this.general.BackColor = System.Drawing.Color.Transparent;
                this.general.Cursor = System.Windows.Forms.Cursors.Hand;
                this.general.FlatAppearance.BorderSize = 0;
                this.general.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\general.png");
                this.general.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.general.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.general.ForeColor = System.Drawing.Color.Transparent;
                this.general.Name = "general";
                this.general.UseVisualStyleBackColor = false;
                this.general.Click += new System.EventHandler(this.kliknuti);
                this.general.MouseEnter += new EventHandler(this.popisky);
                // 
                // help
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.help, "help");
                this.help.Cursor = System.Windows.Forms.Cursors.Hand;
                this.help.BackColor = System.Drawing.Color.Transparent;
                this.help.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\help.png");
                this.help.FlatAppearance.BorderSize = 0;
                this.help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.help.ForeColor = System.Drawing.Color.Transparent;
                this.help.Name = "help";
                this.help.UseVisualStyleBackColor = false;
                this.help.Click += new System.EventHandler(this.kliknuti);
                this.help.MouseEnter += new EventHandler(this.popisky);
                // 
                // set_panel
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.set_panel, "set_panel");
                this.set_panel.BackColor = Color.Transparent;
                this.set_panel.Controls.Add(this.krat);
                this.set_panel.Controls.Add(this.language);
                this.set_panel.Location = new Point(90, 38);
                this.set_panel.Size = new Size(gen_menu.Size.Width, Stavovyradek.Location.Y - presunpanel.Size.Height + 21);
                this.set_panel.Controls.Add(this.pocet_pr);
                this.set_panel.Controls.Add(this.odpocet);
                this.set_panel.Controls.Add(this.deleno);
                this.set_panel.Controls.Add(this.plus);
                this.set_panel.Controls.Add(this.minus);
                this.set_panel.Name = "set_panel";
                // 
                // krat
                // 
                load_bar.Increment(1);
                this.krat.BackColor = System.Drawing.Color.Transparent;
                this.krat.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\krat.png");
                resources.ApplyResources(this.krat, "krat");
                this.krat.Cursor = System.Windows.Forms.Cursors.Hand;
                this.krat.FlatAppearance.BorderSize = 0;
                this.krat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.krat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.krat.ForeColor = System.Drawing.Color.Transparent;
                this.krat.Name = "krat";
                this.krat.UseVisualStyleBackColor = false;
                this.krat.Click += new EventHandler(this.set_okno);
                this.krat.MouseEnter += new EventHandler(this.popisky);
                // 
                // language
                // 
                load_bar.Increment(1);
                this.language.BackColor = System.Drawing.Color.Transparent;
                this.language.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\language.png");
                resources.ApplyResources(this.language, "language");
                this.language.Cursor = System.Windows.Forms.Cursors.Hand;
                this.language.FlatAppearance.BorderSize = 0;
                this.language.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.language.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.language.ForeColor = System.Drawing.Color.Transparent;
                this.language.Name = "language";
                this.language.UseVisualStyleBackColor = false;
                this.language.Click += new EventHandler(this.set_okno);
                this.language.MouseEnter += new EventHandler(this.popisky);
                // 
                // pocet_pr
                //
                load_bar.Increment(1); 
                this.pocet_pr.BackColor = System.Drawing.Color.Transparent;
                this.pocet_pr.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\exercise.png");
                resources.ApplyResources(this.pocet_pr, "pocet_pr");
                this.pocet_pr.Cursor = System.Windows.Forms.Cursors.Hand;
                this.pocet_pr.FlatAppearance.BorderSize = 0;
                this.pocet_pr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.pocet_pr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.pocet_pr.ForeColor = System.Drawing.Color.Transparent;
                this.pocet_pr.Name = "pocet_pr";
                this.pocet_pr.UseVisualStyleBackColor = false;
                this.pocet_pr.Click += new EventHandler(this.set_okno);
                this.pocet_pr.MouseEnter += new EventHandler(this.popisky);
                // 
                // odpocet
                // 
                load_bar.Increment(1);
                this.odpocet.BackColor = System.Drawing.Color.Transparent;
                this.odpocet.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\time.png");
                resources.ApplyResources(this.odpocet, "odpocet");
                this.odpocet.Cursor = System.Windows.Forms.Cursors.Hand;
                this.odpocet.FlatAppearance.BorderSize = 0;
                this.odpocet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.odpocet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.odpocet.ForeColor = System.Drawing.Color.Transparent;
                this.odpocet.Name = "odpocet";
                this.odpocet.UseVisualStyleBackColor = false;
                this.odpocet.Click += new EventHandler(this.set_okno);
                this.odpocet.MouseEnter += new EventHandler(this.popisky);
                // 
                // deleno
                // 
                load_bar.Increment(1);
                this.deleno.BackColor = System.Drawing.Color.Transparent;
                this.deleno.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\deleno.png");
                resources.ApplyResources(this.deleno, "deleno");
                this.deleno.Cursor = System.Windows.Forms.Cursors.Hand;
                this.deleno.FlatAppearance.BorderSize = 0;
                this.deleno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.deleno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.deleno.ForeColor = System.Drawing.Color.Transparent;
                this.deleno.Name = "deleno";
                this.deleno.UseVisualStyleBackColor = false;
                this.deleno.Click += new EventHandler(this.set_okno);
                this.deleno.MouseEnter += new EventHandler(this.popisky);
                // 
                // plus
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.plus, "plus");
                this.plus.BackColor = System.Drawing.Color.Transparent;
                this.plus.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\plus (2).png");
                this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
                this.plus.FlatAppearance.BorderSize = 0;
                this.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.plus.ForeColor = System.Drawing.Color.Transparent;
                this.plus.Name = "plus";
                this.plus.UseVisualStyleBackColor = false;
                this.plus.Click += new EventHandler(this.set_okno);
                this.plus.MouseEnter += new EventHandler(this.popisky);
                // 
                // minus
                // 
                load_bar.Increment(1);
                this.minus.BackColor = System.Drawing.Color.Transparent;
                this.minus.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\minus (2).png");
                resources.ApplyResources(this.minus, "minus");
                this.minus.MouseEnter += new EventHandler(this.popisky);
                this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
                this.minus.FlatAppearance.BorderSize = 0;
                this.minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.minus.ForeColor = System.Drawing.Color.Transparent;
                this.minus.Name = "minus";
                this.minus.UseVisualStyleBackColor = false;
                this.minus.Click += new EventHandler(this.set_okno);
                // 
                // user_panel
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.user_panel, "user_panel");
                this.user_panel.BackColor = Color.Transparent;
                this.user_panel.Controls.Add(this.user_list);
                this.user_panel.Controls.Add(this.user_out);
                this.user_panel.Controls.Add(this.user_change);
                this.user_panel.Location = new Point(90, 38);
                this.user_panel.Size = new Size(gen_menu.Size.Width, Stavovyradek.Location.Y - presunpanel.Size.Height + 21);
                this.user_panel.Controls.Add(this.user_minus);
                this.user_panel.Controls.Add(this.user_plus);
                this.user_panel.Controls.Add(this.user_in);
                this.user_panel.Name = "user_panel";
                // 
                // user_list
                // 
                load_bar.Increment(1);
                this.user_list.BackColor = System.Drawing.Color.Transparent;
                this.user_list.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\exercise.png");
                resources.ApplyResources(this.user_list, "user_list");
                this.user_list.Cursor = System.Windows.Forms.Cursors.Hand;
                this.user_list.FlatAppearance.BorderSize = 0;
                this.user_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.user_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.user_list.ForeColor = System.Drawing.Color.Transparent;
                this.user_list.Name = "user_list";
                this.user_list.UseVisualStyleBackColor = false;
                this.user_list.MouseEnter += new EventHandler(this.popisky);
                this.user_list.Click += new EventHandler(this.set_okno);
                // 
                // user_out
                // 
                load_bar.Increment(1);
                this.user_out.BackColor = System.Drawing.Color.Transparent;
                this.user_out.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\logout.png");
                resources.ApplyResources(this.user_out, "user_out");
                this.user_out.Cursor = System.Windows.Forms.Cursors.Hand;
                this.user_out.FlatAppearance.BorderSize = 0;
                this.user_out.MouseEnter += new EventHandler(this.popisky);
                this.user_out.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.user_out.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.user_out.ForeColor = System.Drawing.Color.Transparent;
                this.user_out.Name = "user_out";
                this.user_out.UseVisualStyleBackColor = false;
                this.user_out.Click += new System.EventHandler(this.Logout_Click);
                // 
                // user_change
                // 
                load_bar.Increment(1);
                this.user_change.BackColor = System.Drawing.Color.Transparent;
                this.user_change.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\change-pass.png");
                resources.ApplyResources(this.user_change, "user_change");
                this.user_change.Cursor = System.Windows.Forms.Cursors.Hand;
                this.user_change.FlatAppearance.BorderSize = 0;
                this.user_change.MouseEnter += new EventHandler(this.popisky);
                this.user_change.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.user_change.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.user_change.ForeColor = System.Drawing.Color.Transparent;
                this.user_change.Name = "user_change";
                this.user_change.UseVisualStyleBackColor = false;
                this.user_change.Click += new System.EventHandler(this.changepass_Click);
                // 
                // user_minus
                // 
                load_bar.Increment(1);
                this.user_minus.BackColor = System.Drawing.Color.Transparent;
                this.user_minus.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\minus.png");
                this.user_minus.MouseEnter += new EventHandler(this.popisky);
                resources.ApplyResources(this.user_minus, "user_minus");
                this.user_minus.Cursor = System.Windows.Forms.Cursors.Hand;
                this.user_minus.FlatAppearance.BorderSize = 0;
                this.user_minus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.user_minus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.user_minus.ForeColor = System.Drawing.Color.Transparent;
                this.user_minus.Name = "user_minus";
                this.user_minus.UseVisualStyleBackColor = false;
                this.user_minus.Click += new System.EventHandler(this.deleteusers_Click);
                // 
                // user_plus
                // 
                load_bar.Increment(1);
                this.user_plus.BackColor = System.Drawing.Color.Transparent;
                this.user_plus.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\plus.png");
                resources.ApplyResources(this.user_plus, "user_plus");
                this.user_plus.Cursor = System.Windows.Forms.Cursors.Hand;
                this.user_plus.FlatAppearance.BorderSize = 0;
                this.user_plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.user_plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.user_plus.ForeColor = System.Drawing.Color.Transparent;
                this.user_plus.Name = "user_plus";
                this.user_plus.UseVisualStyleBackColor = false;
                this.user_plus.Click += new System.EventHandler(this.new_user);
                this.user_plus.MouseEnter += new EventHandler(this.popisky);
                // 
                // user_in
                // 
                load_bar.Increment(1);
                this.user_in.BackColor = System.Drawing.Color.Transparent;
                this.user_in.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + @"\\Data\\Icons\\singin.png");
                resources.ApplyResources(this.user_in, "user_in");
                this.user_in.Cursor = System.Windows.Forms.Cursors.Hand;
                this.user_in.FlatAppearance.BorderSize = 0;
                this.user_in.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.user_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.user_in.ForeColor = System.Drawing.Color.Transparent;
                this.user_in.Name = "user_in";
                this.user_in.UseVisualStyleBackColor = false;
                this.user_in.Click += new System.EventHandler(this.Log_in_system);
                this.user_in.MouseEnter += new EventHandler(this.popisky);
                // 
                // testpanel
                // 
                load_bar.Increment(1);
                this.testpanel.BackColor = System.Drawing.Color.Transparent;
                this.testpanel.Controls.Add(this.ri6);
                this.testpanel.Controls.Add(this.vse);
                this.testpanel.Controls.Add(this.label1);
                this.testpanel.Controls.Add(this.le9);
                this.testpanel.Controls.Add(this.rovn9);
                this.testpanel.Controls.Add(this.nas);
                this.testpanel.Controls.Add(this.prod10);
                this.testpanel.Controls.Add(this.ri9);
                this.testpanel.Controls.Add(this.lomeno);
                this.testpanel.Controls.Add(this.prod9);
                this.testpanel.Controls.Add(this.od);
                this.testpanel.Controls.Add(this.le10);
                this.testpanel.Controls.Add(this.del);
                this.testpanel.Controls.Add(this.ri8);
                this.testpanel.Controls.Add(this.rovn10);
                this.testpanel.Controls.Add(this.prod4);
                this.testpanel.Controls.Add(this.rovn8);
                this.testpanel.Controls.Add(this.ri10);
                this.testpanel.Controls.Add(this.prod1);
                this.testpanel.Controls.Add(this.le8);
                this.testpanel.Controls.Add(this.last_time_num);
                this.testpanel.Controls.Add(this.zn7);
                this.testpanel.Controls.Add(this.prod3);
                this.testpanel.Controls.Add(this.ri7);
                this.testpanel.Controls.Add(this.last_time_label);
                this.testpanel.Controls.Add(this.zn8);
                this.testpanel.Controls.Add(this.prod2);
                this.testpanel.Controls.Add(this.rovn7);
                this.testpanel.Controls.Add(this.zn9);
                this.testpanel.Controls.Add(this.le1);
                this.testpanel.Controls.Add(this.le7);
                this.testpanel.Controls.Add(this.zn10);
                this.testpanel.Controls.Add(this.rovn1);
                this.testpanel.Controls.Add(this.prod7);
                this.testpanel.Controls.Add(this.ri1);
                this.testpanel.Controls.Add(this.prod8);
                this.testpanel.Controls.Add(this.le2);
                this.testpanel.Controls.Add(this.rovn2);
                this.testpanel.Controls.Add(this.prod18);
                this.testpanel.Controls.Add(this.le3);
                this.testpanel.Controls.Add(this.prod17);
                this.testpanel.Controls.Add(this.rovn3);
                this.testpanel.Controls.Add(this.le17);
                this.testpanel.Controls.Add(this.ri3);
                this.testpanel.Controls.Add(this.rovn17);
                this.testpanel.Controls.Add(this.le4);
                this.testpanel.Controls.Add(this.zn16);
                this.testpanel.Controls.Add(this.ri17);
                this.testpanel.Controls.Add(this.rovn4);
                this.testpanel.Controls.Add(this.zn15);
                this.testpanel.Controls.Add(this.le18);
                this.testpanel.Controls.Add(this.ri4);
                this.testpanel.Controls.Add(this.zn14);
                this.testpanel.Controls.Add(this.rovn18);
                this.testpanel.Controls.Add(this.prod5);
                this.testpanel.Controls.Add(this.zn13);
                this.testpanel.Controls.Add(this.ri18);
                this.testpanel.Controls.Add(this.prod6);
                this.testpanel.Controls.Add(this.zn12);
                this.testpanel.Controls.Add(this.prod19);
                this.testpanel.Controls.Add(this.le5);
                this.testpanel.Controls.Add(this.zn11);
                this.testpanel.Controls.Add(this.prod20);
                this.testpanel.Controls.Add(this.rovn5);
                this.testpanel.Controls.Add(this.ri16);
                this.testpanel.Controls.Add(this.le19);
                this.testpanel.Controls.Add(this.ri5);
                this.testpanel.Controls.Add(this.rovn16);
                this.testpanel.Controls.Add(this.rovn19);
                this.testpanel.Controls.Add(this.le6);
                this.testpanel.Controls.Add(this.le16);
                this.testpanel.Controls.Add(this.ri19);
                this.testpanel.Controls.Add(this.rovn6);
                this.testpanel.Controls.Add(this.ri15);
                this.testpanel.Controls.Add(this.le20);
                this.testpanel.Controls.Add(this.rovn15);
                this.testpanel.Controls.Add(this.TimeLabel);
                this.testpanel.Controls.Add(this.rovn20);
                this.testpanel.Controls.Add(this.le15);
                this.testpanel.Controls.Add(this.label21);
                this.testpanel.Controls.Add(this.ri20);
                this.testpanel.Controls.Add(this.label23);
                this.testpanel.Controls.Add(this.prod16);
                this.testpanel.Controls.Add(this.sc);
                this.testpanel.Controls.Add(this.zn17);
                this.testpanel.Controls.Add(this.label25);
                this.testpanel.Controls.Add(this.prod15);
                this.testpanel.Controls.Add(this.zn1);
                this.testpanel.Controls.Add(this.zn18);
                this.testpanel.Controls.Add(this.sprv20);
                this.testpanel.Controls.Add(this.ri14);
                this.testpanel.Controls.Add(this.zn2);
                this.testpanel.Controls.Add(this.zn19);
                this.testpanel.Controls.Add(this.sprv19);
                this.testpanel.Controls.Add(this.rovn14);
                this.testpanel.Controls.Add(this.zn20);
                this.testpanel.Controls.Add(this.sprv18);
                this.testpanel.Controls.Add(this.le14);
                this.testpanel.Controls.Add(this.zn4);
                this.testpanel.Controls.Add(this.sprv17);
                this.testpanel.Controls.Add(this.ri13);
                this.testpanel.Controls.Add(this.zn5);
                this.testpanel.Controls.Add(this.sprv16);
                this.testpanel.Controls.Add(this.rovn13);
                this.testpanel.Controls.Add(this.zn6);
                this.testpanel.Controls.Add(this.sprv15);
                this.testpanel.Controls.Add(this.le13);
                this.testpanel.Controls.Add(this.sprv14);
                this.testpanel.Controls.Add(this.ri12);
                this.testpanel.Controls.Add(this.sprv13);
                this.testpanel.Controls.Add(this.rovn12);
                this.testpanel.Controls.Add(this.sprv12);
                this.testpanel.Controls.Add(this.le12);
                this.testpanel.Controls.Add(this.sprv11);
                this.testpanel.Controls.Add(this.ri11);
                this.testpanel.Controls.Add(this.sprv1);
                this.testpanel.Controls.Add(this.sprv10);
                this.testpanel.Controls.Add(this.rovn11);
                this.testpanel.Controls.Add(this.sprv2);
                this.testpanel.Controls.Add(this.sprv9);
                this.testpanel.Controls.Add(this.le11);
                this.testpanel.Controls.Add(this.sprv3);
                this.testpanel.Controls.Add(this.sprv8);
                this.testpanel.Controls.Add(this.prod12);
                this.testpanel.Controls.Add(this.sprv4);
                this.testpanel.Controls.Add(this.sprv7);
                this.testpanel.Controls.Add(this.prod13);
                this.testpanel.Controls.Add(this.prod14);
                this.testpanel.Controls.Add(this.sprv5);
                this.testpanel.Controls.Add(this.sprv6);
                this.testpanel.Controls.Add(this.prod11);
                this.testpanel.Controls.Add(this.StartButton);
                this.testpanel.Controls.Add(this.endbutton);
                this.testpanel.Controls.Add(this.zn3);
                this.testpanel.Controls.Add(this.ri2);
                resources.ApplyResources(this.testpanel, "testpanel");
                this.testpanel.Name = "testpanel";
                this.testpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.testpanel.Click += new System.EventHandler(this.zmiz);
                // 
                // ri6
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri6, "ri6");
                this.ri6.ForeColor = System.Drawing.Color.White;
                this.ri6.Name = "ri6";
                this.ri6.Click += new System.EventHandler(this.zmiz);
                // 
                // vse
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.vse, "vse");
                this.vse.Checked = true;
                this.vse.ForeColor = System.Drawing.Color.White;
                this.vse.Name = "vse";
                this.vse.TabStop = true;
                this.vse.UseVisualStyleBackColor = true;
                this.vse.CheckedChanged += new System.EventHandler(this.check_zmena);
                // 
                // label1 
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label1, "label1");
                this.label1.ForeColor = System.Drawing.Color.White;
                this.label1.Name = "label1";
                // 
                // le9
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le9, "le9");
                this.le9.ForeColor = System.Drawing.Color.White;
                this.le9.Name = "le9";
                this.le9.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn9
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn9, "rovn9");
                this.rovn9.ForeColor = System.Drawing.Color.White;
                this.rovn9.Name = "rovn9";
                this.rovn9.Click += new System.EventHandler(this.zmiz);
                // 
                // nas
                //
                load_bar.Increment(1); 
                resources.ApplyResources(this.nas, "nas");
                this.nas.ForeColor = System.Drawing.Color.White;
                this.nas.Name = "nas";
                this.nas.UseVisualStyleBackColor = true;
                this.nas.CheckedChanged += new System.EventHandler(this.check_zmena);
                // 
                // prod10
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod10, "prod10");
                this.prod10.ForeColor = System.Drawing.Color.Black;
                this.prod10.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod10.Name = "prod10";
                this.prod10.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod10.Enter += new System.EventHandler(this.uprava_tab);
                this.prod10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // ri9
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri9, "ri9");
                this.ri9.ForeColor = System.Drawing.Color.White;
                this.ri9.Name = "ri9";
                this.ri9.Click += new System.EventHandler(this.zmiz);
                // 
                // lomeno
                // 
                this.lomeno.BackColor = System.Drawing.Color.White;
                resources.ApplyResources(this.lomeno, "lomeno");
                this.lomeno.ForeColor = System.Drawing.Color.White;
                this.lomeno.Name = "lomeno";
                // 
                // prod9
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod9, "prod9");
                this.prod9.ForeColor = System.Drawing.Color.Black;
                this.prod9.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod9.Name = "prod9";
                this.prod9.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod9.Enter += new System.EventHandler(this.uprava_tab);
                this.prod9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // od
                //
                load_bar.Increment(1); 
                resources.ApplyResources(this.od, "od");
                this.od.ForeColor = System.Drawing.Color.White;
                this.od.Name = "od";
                this.od.UseVisualStyleBackColor = true;
                this.od.CheckedChanged += new System.EventHandler(this.check_zmena);
                // 
                // le10
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le10, "le10");
                this.le10.ForeColor = System.Drawing.Color.White;
                this.le10.Name = "le10";
                this.le10.Click += new System.EventHandler(this.zmiz);
                // 
                // del
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.del, "del");
                this.del.ForeColor = System.Drawing.Color.White;
                this.del.Name = "del";
                this.del.UseVisualStyleBackColor = true;
                this.del.CheckedChanged += new System.EventHandler(this.check_zmena);
                // 
                // ri8
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri8, "ri8");
                this.ri8.ForeColor = System.Drawing.Color.White;
                this.ri8.Name = "ri8";
                this.ri8.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn10
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn10, "rovn10");
                this.rovn10.ForeColor = System.Drawing.Color.White;
                this.rovn10.Name = "rovn10";
                this.rovn10.Click += new System.EventHandler(this.zmiz);
                // 
                // prod4
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod4, "prod4");
                this.prod4.ForeColor = System.Drawing.Color.Black;
                this.prod4.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod4.Name = "prod4";
                this.prod4.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod4.Enter += new System.EventHandler(this.uprava_tab);
                this.prod4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // rovn8
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn8, "rovn8");
                this.rovn8.ForeColor = System.Drawing.Color.White;
                this.rovn8.Name = "rovn8";
                this.rovn8.Click += new System.EventHandler(this.zmiz);
                // 
                // ri10
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri10, "ri10");
                this.ri10.ForeColor = System.Drawing.Color.White;
                this.ri10.Name = "ri10";
                this.ri10.Click += new System.EventHandler(this.zmiz);
                // 
                // prod1
                // 
                load_bar.Increment(1);
                this.prod1.BackColor = System.Drawing.SystemColors.Window;
                resources.ApplyResources(this.prod1, "prod1");
                this.prod1.ForeColor = System.Drawing.Color.Black;
                this.prod1.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod1.Name = "prod1";
                this.prod1.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod1.Enter += new System.EventHandler(this.uprava_tab);
                this.prod1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // le8
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le8, "le8");
                this.le8.ForeColor = System.Drawing.Color.White;
                this.le8.Name = "le8";
                this.le8.Click += new System.EventHandler(this.zmiz);
                // 
                // last_time_num
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.last_time_num, "last_time_num");
                this.last_time_num.ForeColor = System.Drawing.Color.White;
                this.last_time_num.Name = "last_time_num";
                this.last_time_num.Click += new System.EventHandler(this.zmiz);
                // 
                // zn7
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn7, "zn7");
                this.zn7.ForeColor = System.Drawing.Color.White;
                this.zn7.Name = "zn7";
                this.zn7.Click += new System.EventHandler(this.zmiz);
                // 
                // prod3
                // 
                load_bar.Increment(1);
                this.prod3.BackColor = System.Drawing.SystemColors.Window;
                resources.ApplyResources(this.prod3, "prod3");
                this.prod3.ForeColor = System.Drawing.Color.Black;
                this.prod3.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod3.Name = "prod3";
                this.prod3.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod3.Enter += new System.EventHandler(this.uprava_tab);
                this.prod3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // ri7
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri7, "ri7");
                this.ri7.ForeColor = System.Drawing.Color.White;
                this.ri7.Name = "ri7";
                this.ri7.Click += new System.EventHandler(this.zmiz);
                // 
                // last_time_label
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.last_time_label, "last_time_label");
                this.last_time_label.ForeColor = System.Drawing.Color.White;
                this.last_time_label.Name = "last_time_label";
                this.last_time_label.Click += new System.EventHandler(this.zmiz);
                // 
                // zn8
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn8, "zn8");
                this.zn8.ForeColor = System.Drawing.Color.White;
                this.zn8.Name = "zn8";
                this.zn8.Click += new System.EventHandler(this.zmiz);
                // 
                // prod2
                // 
                load_bar.Increment(1);
                this.prod2.BackColor = System.Drawing.SystemColors.Window;
                resources.ApplyResources(this.prod2, "prod2");
                this.prod2.ForeColor = System.Drawing.Color.Black;
                this.prod2.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod2.Name = "prod2";
                this.prod2.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod2.Click += new System.EventHandler(this.zmiz);
                this.prod2.Enter += new System.EventHandler(this.uprava_tab);
                this.prod2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // rovn7
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn7, "rovn7");
                this.rovn7.ForeColor = System.Drawing.Color.White;
                this.rovn7.Name = "rovn7";
                this.rovn7.Click += new System.EventHandler(this.zmiz);
                // 
                // zn9
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn9, "zn9");
                this.zn9.ForeColor = System.Drawing.Color.White;
                this.zn9.Name = "zn9";
                this.zn9.Click += new System.EventHandler(this.zmiz);
                // 
                // le1
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le1, "le1");
                this.le1.ForeColor = System.Drawing.Color.White;
                this.le1.Name = "le1";
                this.le1.Click += new System.EventHandler(this.zmiz);
                // 
                // le7
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le7, "le7");
                this.le7.ForeColor = System.Drawing.Color.White;
                this.le7.Name = "le7";
                this.le7.Click += new System.EventHandler(this.zmiz);
                // 
                // zn10
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn10, "zn10");
                this.zn10.ForeColor = System.Drawing.Color.White;
                this.zn10.Name = "zn10";
                this.zn10.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn1
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn1, "rovn1");
                this.rovn1.ForeColor = System.Drawing.Color.White;
                this.rovn1.Name = "rovn1";
                this.rovn1.Click += new System.EventHandler(this.zmiz);
                // 
                // prod7
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod7, "prod7");
                this.prod7.ForeColor = System.Drawing.Color.Black;
                this.prod7.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod7.Name = "prod7";
                this.prod7.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod7.Enter += new System.EventHandler(this.uprava_tab);
                this.prod7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // ri1
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri1, "ri1");
                this.ri1.ForeColor = System.Drawing.Color.White;
                this.ri1.Name = "ri1";
                this.ri1.Click += new System.EventHandler(this.zmiz);
                // 
                // prod8
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod8, "prod8");
                this.prod8.ForeColor = System.Drawing.Color.Black;
                this.prod8.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod8.Name = "prod8";
                this.prod8.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod8.Enter += new System.EventHandler(this.uprava_tab);
                this.prod8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // le2
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le2, "le2");
                this.le2.ForeColor = System.Drawing.Color.White;
                this.le2.Name = "le2";
                this.le2.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn2
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn2, "rovn2");
                this.rovn2.ForeColor = System.Drawing.Color.White;
                this.rovn2.Name = "rovn2";
                this.rovn2.Click += new System.EventHandler(this.zmiz);
                // 
                // prod18
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod18, "prod18");
                this.prod18.ForeColor = System.Drawing.Color.Black;
                this.prod18.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod18.Name = "prod18";
                this.prod18.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod18.Enter += new System.EventHandler(this.uprava_tab);
                this.prod18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // le3
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le3, "le3");
                this.le3.ForeColor = System.Drawing.Color.White;
                this.le3.Name = "le3";
                this.le3.Click += new System.EventHandler(this.zmiz);
                // 
                // prod17
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod17, "prod17");
                this.prod17.ForeColor = System.Drawing.Color.Black;
                this.prod17.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod17.Name = "prod17";
                this.prod17.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod17.Enter += new System.EventHandler(this.uprava_tab);
                this.prod17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // rovn3
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn3, "rovn3");
                this.rovn3.ForeColor = System.Drawing.Color.White;
                this.rovn3.Name = "rovn3";
                this.rovn3.Click += new System.EventHandler(this.zmiz);
                // 
                // le17
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le17, "le17");
                this.le17.ForeColor = System.Drawing.Color.White;
                this.le17.Name = "le17";
                this.le17.Click += new System.EventHandler(this.zmiz);
                // 
                // ri3
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri3, "ri3");
                this.ri3.ForeColor = System.Drawing.Color.White;
                this.ri3.Name = "ri3";
                this.ri3.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn17
                //
                load_bar.Increment(1); 
                resources.ApplyResources(this.rovn17, "rovn17");
                this.rovn17.ForeColor = System.Drawing.Color.White;
                this.rovn17.Name = "rovn17";
                this.rovn17.Click += new System.EventHandler(this.zmiz);
                // 
                // le4
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le4, "le4");
                this.le4.ForeColor = System.Drawing.Color.White;
                this.le4.Name = "le4";
                this.le4.Click += new System.EventHandler(this.zmiz);
                // 
                // zn16
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn16, "zn16");
                this.zn16.ForeColor = System.Drawing.Color.White;
                this.zn16.Name = "zn16";
                this.zn16.Click += new System.EventHandler(this.zmiz);
                // 
                // ri17
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri17, "ri17");
                this.ri17.ForeColor = System.Drawing.Color.White;
                this.ri17.Name = "ri17";
                this.ri17.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn4
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn4, "rovn4");
                this.rovn4.ForeColor = System.Drawing.Color.White;
                this.rovn4.Name = "rovn4";
                this.rovn4.Click += new System.EventHandler(this.zmiz);
                // 
                // zn15
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn15, "zn15");
                this.zn15.ForeColor = System.Drawing.Color.White;
                this.zn15.Name = "zn15";
                this.zn15.Click += new System.EventHandler(this.zmiz);
                // 
                // le18
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le18, "le18");
                this.le18.ForeColor = System.Drawing.Color.White;
                this.le18.Name = "le18";
                this.le18.Click += new System.EventHandler(this.zmiz);
                // 
                // ri4
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri4, "ri4");
                this.ri4.ForeColor = System.Drawing.Color.White;
                this.ri4.Name = "ri4";
                this.ri4.Click += new System.EventHandler(this.zmiz);
                // 
                // zn14
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn14, "zn14");
                this.zn14.ForeColor = System.Drawing.Color.White;
                this.zn14.Name = "zn14";
                this.zn14.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn18
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn18, "rovn18");
                this.rovn18.ForeColor = System.Drawing.Color.White;
                this.rovn18.Name = "rovn18";
                this.rovn18.Click += new System.EventHandler(this.zmiz);
                // 
                // prod5
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod5, "prod5");
                this.prod5.ForeColor = System.Drawing.Color.Black;
                this.prod5.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod5.Name = "prod5";
                this.prod5.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod5.Enter += new System.EventHandler(this.uprava_tab);
                this.prod5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // zn13
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn13, "zn13");
                this.zn13.ForeColor = System.Drawing.Color.White;
                this.zn13.Name = "zn13";
                this.zn13.Click += new System.EventHandler(this.zmiz);
                // 
                // ri18
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri18, "ri18");
                this.ri18.ForeColor = System.Drawing.Color.White;
                this.ri18.Name = "ri18";
                this.ri18.Click += new System.EventHandler(this.zmiz);
                // 
                // prod6
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod6, "prod6");
                this.prod6.ForeColor = System.Drawing.Color.Black;
                this.prod6.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod6.Name = "prod6";
                this.prod6.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod6.Enter += new System.EventHandler(this.uprava_tab);
                this.prod6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // zn12
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn12, "zn12");
                this.zn12.ForeColor = System.Drawing.Color.White;
                this.zn12.Name = "zn12";
                this.zn12.Click += new System.EventHandler(this.zmiz);
                // 
                // prod19
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod19, "prod19");
                this.prod19.ForeColor = System.Drawing.Color.Black;
                this.prod19.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod19.Name = "prod19";
                this.prod19.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod19.Enter += new System.EventHandler(this.uprava_tab);
                this.prod19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // le5
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le5, "le5");
                this.le5.ForeColor = System.Drawing.Color.White;
                this.le5.Name = "le5";
                this.le5.Click += new System.EventHandler(this.zmiz);
                // 
                // zn11
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn11, "zn11");
                this.zn11.ForeColor = System.Drawing.Color.White;
                this.zn11.Name = "zn11";
                this.zn11.Click += new System.EventHandler(this.zmiz);
                // 
                // prod20
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod20, "prod20");
                this.prod20.ForeColor = System.Drawing.Color.Black;
                this.prod20.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod20.Name = "prod20";
                this.prod20.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod20.Enter += new System.EventHandler(this.uprava_tab);
                this.prod20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // rovn5
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn5, "rovn5");
                this.rovn5.ForeColor = System.Drawing.Color.White;
                this.rovn5.Name = "rovn5";
                this.rovn5.Click += new System.EventHandler(this.zmiz);
                // 
                // ri16
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri16, "ri16");
                this.ri16.ForeColor = System.Drawing.Color.White;
                this.ri16.Name = "ri16";
                this.ri16.Click += new System.EventHandler(this.zmiz);
                // 
                // le19
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le19, "le19");
                this.le19.ForeColor = System.Drawing.Color.White;
                this.le19.Name = "le19";
                this.le19.Click += new System.EventHandler(this.zmiz);
                // 
                // ri5
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri5, "ri5");
                this.ri5.ForeColor = System.Drawing.Color.White;
                this.ri5.Name = "ri5";
                this.ri5.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn16
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn16, "rovn16");
                this.rovn16.ForeColor = System.Drawing.Color.White;
                this.rovn16.Name = "rovn16";
                this.rovn16.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn19
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn19, "rovn19");
                this.rovn19.ForeColor = System.Drawing.Color.White;
                this.rovn19.Name = "rovn19";
                this.rovn19.Click += new System.EventHandler(this.zmiz);
                // 
                // le6
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le6, "le6");
                this.le6.ForeColor = System.Drawing.Color.White;
                this.le6.Name = "le6";
                this.le6.Click += new System.EventHandler(this.zmiz);
                // 
                // le16
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le16, "le16");
                this.le16.ForeColor = System.Drawing.Color.White;
                this.le16.Name = "le16";
                this.le16.Click += new System.EventHandler(this.zmiz);
                // 
                // ri19
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri19, "ri19");
                this.ri19.ForeColor = System.Drawing.Color.White;
                this.ri19.Name = "ri19";
                this.ri19.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn6
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn6, "rovn6");
                this.rovn6.ForeColor = System.Drawing.Color.White;
                this.rovn6.Name = "rovn6";
                this.rovn6.Click += new System.EventHandler(this.zmiz);
                // 
                // ri15
                // 
                load_bar.Increment(1);
                load_bar.Increment(1);
                resources.ApplyResources(this.ri15, "ri15");
                this.ri15.ForeColor = System.Drawing.Color.White;
                this.ri15.Name = "ri15";
                this.ri15.Click += new System.EventHandler(this.zmiz);
                // 
                // le20
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le20, "le20");
                this.le20.ForeColor = System.Drawing.Color.White;
                this.le20.Name = "le20";
                this.le20.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn15
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn15, "rovn15");
                this.rovn15.ForeColor = System.Drawing.Color.White;
                this.rovn15.Name = "rovn15";
                this.rovn15.Click += new System.EventHandler(this.zmiz);
                // 
                // TimeLabel
                // 
                load_bar.Increment(1);
                this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                resources.ApplyResources(this.TimeLabel, "TimeLabel");
                this.TimeLabel.ForeColor = System.Drawing.Color.White;
                this.TimeLabel.Name = "TimeLabel";
                this.TimeLabel.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn20
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn20, "rovn20");
                this.rovn20.ForeColor = System.Drawing.Color.White;
                this.rovn20.Name = "rovn20";
                this.rovn20.Click += new System.EventHandler(this.zmiz);
                // 
                // le15
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le15, "le15");
                this.le15.ForeColor = System.Drawing.Color.White;
                this.le15.Name = "le15";
                this.le15.Click += new System.EventHandler(this.zmiz);
                // 
                // label21
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label21, "label21");
                this.label21.ForeColor = System.Drawing.Color.White;
                this.label21.Name = "label21";
                this.label21.Location = new Point(this.label21.Location.X - 30, this.label21.Location.Y);
                this.label21.Click += new System.EventHandler(this.zmiz);
                // 
                // ri20
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri20, "ri20");
                this.ri20.ForeColor = System.Drawing.Color.White;
                this.ri20.Name = "ri20";
                this.ri20.Click += new System.EventHandler(this.zmiz);
                // 
                // label23
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label23, "label23");
                this.label23.ForeColor = System.Drawing.Color.White;
                this.label23.Name = "label23";
                this.label23.Click += new System.EventHandler(this.zmiz);
                // 
                // prod16
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod16, "prod16");
                this.prod16.ForeColor = System.Drawing.Color.Black;
                this.prod16.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod16.Name = "prod16";
                this.prod16.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod16.Enter += new System.EventHandler(this.uprava_tab);
                this.prod16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // sc
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sc, "sc");
                this.sc.ForeColor = System.Drawing.Color.White;
                this.sc.Name = "sc";
                this.sc.UseVisualStyleBackColor = true;
                this.sc.CheckedChanged += new System.EventHandler(this.check_zmena);
                // 
                // zn17
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn17, "zn17");
                this.zn17.ForeColor = System.Drawing.Color.White;
                this.zn17.Name = "zn17";
                this.zn17.Click += new System.EventHandler(this.zmiz);
                // 
                // label25
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label25, "label25");
                this.label25.ForeColor = System.Drawing.Color.White;
                this.label25.Name = "label25";
                this.label25.Click += new System.EventHandler(this.zmiz);
                // 
                // prod15
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod15, "prod15");
                this.prod15.ForeColor = System.Drawing.Color.Black;
                this.prod15.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod15.Name = "prod15";
                this.prod15.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod15.Enter += new System.EventHandler(this.uprava_tab);
                this.prod15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // zn1
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn1, "zn1");
                this.zn1.ForeColor = System.Drawing.Color.White;
                this.zn1.Name = "zn1";
                this.zn1.Click += new System.EventHandler(this.zmiz);
                // 
                // zn18
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn18, "zn18");
                this.zn18.ForeColor = System.Drawing.Color.White;
                this.zn18.Name = "zn18";
                this.zn18.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv20
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv20, "sprv20");
                this.sprv20.ForeColor = System.Drawing.Color.White;
                this.sprv20.Name = "sprv20";
                this.sprv20.Click += new System.EventHandler(this.zmiz);
                // 
                // ri14
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri14, "ri14");
                this.ri14.ForeColor = System.Drawing.Color.White;
                this.ri14.Name = "ri14";
                this.ri14.Click += new System.EventHandler(this.zmiz);
                // 
                // zn2
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn2, "zn2");
                this.zn2.ForeColor = System.Drawing.Color.White;
                this.zn2.Name = "zn2";
                this.zn2.Click += new System.EventHandler(this.zmiz);
                // 
                // zn19
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn19, "zn19");
                this.zn19.ForeColor = System.Drawing.Color.White;
                this.zn19.Name = "zn19";
                this.zn19.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv19
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv19, "sprv19");
                this.sprv19.ForeColor = System.Drawing.Color.White;
                this.sprv19.Name = "sprv19";
                this.sprv19.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn14
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn14, "rovn14");
                this.rovn14.ForeColor = System.Drawing.Color.White;
                this.rovn14.Name = "rovn14";
                this.rovn14.Click += new System.EventHandler(this.zmiz);
                // 
                // zn
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn20, "zn20");
                this.zn20.ForeColor = System.Drawing.Color.White;
                this.zn20.Name = "zn20";
                this.zn20.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv18
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv18, "sprv18");
                this.sprv18.ForeColor = System.Drawing.Color.White;
                this.sprv18.Name = "sprv18";
                this.sprv18.Click += new System.EventHandler(this.zmiz);
                // 
                // le14
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le14, "le14");
                this.le14.ForeColor = System.Drawing.Color.White;
                this.le14.Name = "le14";
                this.le14.Click += new System.EventHandler(this.zmiz);
                // 
                // zn4
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn4, "zn4");
                this.zn4.ForeColor = System.Drawing.Color.White;
                this.zn4.Name = "zn4";
                this.zn4.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv17
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv17, "sprv17");
                this.sprv17.ForeColor = System.Drawing.Color.White;
                this.sprv17.Name = "sprv17";
                this.sprv17.Click += new System.EventHandler(this.zmiz);
                // 
                // ri13
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri13, "ri13");
                this.ri13.ForeColor = System.Drawing.Color.White;
                this.ri13.Name = "ri13";
                this.ri13.Click += new System.EventHandler(this.zmiz);
                // 
                // zn5
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn5, "zn5");
                this.zn5.ForeColor = System.Drawing.Color.White;
                this.zn5.Name = "zn5";
                this.zn5.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv16
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv16, "sprv16");
                this.sprv16.ForeColor = System.Drawing.Color.White;
                this.sprv16.Name = "sprv16";
                this.sprv16.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn13
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn13, "rovn13");
                this.rovn13.ForeColor = System.Drawing.Color.White;
                this.rovn13.Name = "rovn13";
                this.rovn13.Click += new System.EventHandler(this.zmiz);
                // 
                // zn6
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn6, "zn6");
                this.zn6.ForeColor = System.Drawing.Color.White;
                this.zn6.Name = "zn6";
                this.zn6.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv15
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv15, "sprv15");
                this.sprv15.ForeColor = System.Drawing.Color.White;
                this.sprv15.Name = "sprv15";
                this.sprv15.Click += new System.EventHandler(this.zmiz);
                // 
                // le13
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le13, "le13");
                this.le13.ForeColor = System.Drawing.Color.White;
                this.le13.Name = "le13";
                this.le13.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv14
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv14, "sprv14");
                this.sprv14.ForeColor = System.Drawing.Color.White;
                this.sprv14.Name = "sprv14";
                this.sprv14.Click += new System.EventHandler(this.zmiz);
                // 
                // ri12
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri12, "ri12");
                this.ri12.ForeColor = System.Drawing.Color.White;
                this.ri12.Name = "ri12";
                this.ri12.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv13
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv13, "sprv13");
                this.sprv13.ForeColor = System.Drawing.Color.White;
                this.sprv13.Name = "sprv13";
                this.sprv13.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn12
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn12, "rovn12");
                this.rovn12.ForeColor = System.Drawing.Color.White;
                this.rovn12.Name = "rovn12";
                this.rovn12.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv12
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv12, "sprv12");
                this.sprv12.ForeColor = System.Drawing.Color.White;
                this.sprv12.Name = "sprv12";
                this.sprv12.Click += new System.EventHandler(this.zmiz);
                // 
                // le12
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le12, "le12");
                this.le12.ForeColor = System.Drawing.Color.White;
                this.le12.Name = "le12";
                this.le12.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv11
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv11, "sprv11");
                this.sprv11.ForeColor = System.Drawing.Color.White;
                this.sprv11.Name = "sprv11";
                this.sprv11.Click += new System.EventHandler(this.zmiz);
                // 
                // ri11
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri11, "ri11");
                this.ri11.ForeColor = System.Drawing.Color.White;
                this.ri11.Name = "ri11";
                this.ri11.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv1
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv1, "sprv1");
                this.sprv1.ForeColor = System.Drawing.Color.White;
                this.sprv1.Name = "sprv1";
                this.sprv1.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv10
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv10, "sprv10");
                this.sprv10.ForeColor = System.Drawing.Color.White;
                this.sprv10.Name = "sprv10";
                this.sprv10.Click += new System.EventHandler(this.zmiz);
                // 
                // rovn11
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.rovn11, "rovn11");
                this.rovn11.ForeColor = System.Drawing.Color.White;
                this.rovn11.Name = "rovn11";
                this.rovn11.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv2
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv2, "sprv2");
                this.sprv2.ForeColor = System.Drawing.Color.White;
                this.sprv2.Name = "sprv2";
                this.sprv2.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv9
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv9, "sprv9");
                this.sprv9.ForeColor = System.Drawing.Color.White;
                this.sprv9.Name = "sprv9";
                this.sprv9.Click += new System.EventHandler(this.zmiz);
                // 
                // le11
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.le11, "le11");
                this.le11.ForeColor = System.Drawing.Color.White;
                this.le11.Name = "le11";
                this.le11.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv3
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv3, "sprv3");
                this.sprv3.ForeColor = System.Drawing.Color.White;
                this.sprv3.Name = "sprv3";
                this.sprv3.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv8
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv8, "sprv8");
                this.sprv8.ForeColor = System.Drawing.Color.White;
                this.sprv8.Name = "sprv8";
                this.sprv8.Click += new System.EventHandler(this.zmiz);
                // 
                // prod12
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod12, "prod12");
                this.prod12.ForeColor = System.Drawing.Color.Black;
                this.prod12.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod12.Name = "prod12";
                this.prod12.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod12.Enter += new System.EventHandler(this.uprava_tab);
                this.prod12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // sprv4
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv4, "sprv4");
                this.sprv4.ForeColor = System.Drawing.Color.White;
                this.sprv4.Name = "sprv4";
                this.sprv4.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv7
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv7, "sprv7");
                this.sprv7.ForeColor = System.Drawing.Color.White;
                this.sprv7.Name = "sprv7";
                this.sprv7.Click += new System.EventHandler(this.zmiz);
                // 
                // prod13
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod13, "prod13");
                this.prod13.ForeColor = System.Drawing.Color.Black;
                this.prod13.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod13.Name = "prod13";
                this.prod13.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod13.Enter += new System.EventHandler(this.uprava_tab);
                this.prod13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // prod14
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod14, "prod14");
                this.prod14.ForeColor = System.Drawing.Color.Black;
                this.prod14.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod14.Name = "prod14";
                this.prod14.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod14.Enter += new System.EventHandler(this.uprava_tab);
                this.prod14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // sprv5
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv5, "sprv5");
                this.sprv5.ForeColor = System.Drawing.Color.White;
                this.sprv5.Name = "sprv5";
                this.sprv5.Click += new System.EventHandler(this.zmiz);
                // 
                // sprv6
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.sprv6, "sprv6");
                this.sprv6.ForeColor = System.Drawing.Color.White;
                this.sprv6.Name = "sprv6";
                this.sprv6.Click += new System.EventHandler(this.zmiz);
                // 
                // prod11
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.prod11, "prod11");
                this.prod11.ForeColor = System.Drawing.Color.Black;
                this.prod11.Maximum = new decimal(new int[] {
                    1000000,
                    0,
                    0,
                    0});
                this.prod11.Name = "prod11";
                this.prod11.ValueChanged += new System.EventHandler(this.valuechanged);
                this.prod11.Enter += new System.EventHandler(this.uprava_tab);
                this.prod11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uprava_mouse);
                // 
                // StartButton
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.StartButton, "StartButton");
                this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.StartButton.ForeColor = System.Drawing.Color.White;
                this.StartButton.Name = "StartButton";
                this.StartButton.UseVisualStyleBackColor = true;
                this.StartButton.Click += new System.EventHandler(this.Start);
                // 
                // endbutton
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.endbutton, "endbutton");
                this.endbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.endbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.endbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                this.endbutton.ForeColor = System.Drawing.Color.White;
                this.endbutton.Name = "endbutton";
                this.endbutton.UseVisualStyleBackColor = true;
                this.endbutton.Click += new System.EventHandler(this.Konec);
                // 
                // zn3
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.zn3, "zn3");
                this.zn3.ForeColor = System.Drawing.Color.White;
                this.zn3.Name = "zn3";
                this.zn3.Click += new System.EventHandler(this.zmiz);
                // 
                // ri2
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.ri2, "ri2");
                this.ri2.ForeColor = System.Drawing.Color.White;
                this.ri2.Name = "ri2";
                this.ri2.Click += new System.EventHandler(this.zmiz);
                // 
                // Userspanel
                // 
                load_bar.Increment(1);
                this.Userspanel.BackColor = System.Drawing.Color.Transparent;
                this.Userspanel.Controls.Add(this.back);
                this.Userspanel.Controls.Add(this.Login_btn);
                this.Userspanel.Controls.Add(this.Logout);
                this.Userspanel.Controls.Add(this.uzivatele);
                this.Userspanel.Controls.Add(this.deleteusers);
                this.Userspanel.Controls.Add(this.createusers);
                this.Userspanel.Controls.Add(this.show_result);
                this.Userspanel.Controls.Add(this.label31);
                this.Userspanel.Controls.Add(this.label32);
                this.Userspanel.Controls.Add(this.changepass);
                this.Userspanel.Controls.Add(this.vysledek_dat);
                resources.ApplyResources(this.Userspanel, "Userspanel");
                this.Userspanel.Name = "Userspanel";
                this.Userspanel.Size = new Size(this.Userspanel.Size.Width, this.Userspanel.Size.Height + 450);
                this.Userspanel.Anchor = System.Windows.Forms.AnchorStyles.None;
                this.Userspanel.Click += new System.EventHandler(this.zmiz);
                // 
                // changepass
                // 
                load_bar.Increment(1);
                this.changepass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.changepass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                resources.ApplyResources(this.changepass, "changepass");
                this.changepass.ForeColor = System.Drawing.Color.White;
                this.changepass.Name = "changepass";
                this.changepass.TabIndex = 3;
                this.changepass.UseVisualStyleBackColor = true;
                this.changepass.Click += new System.EventHandler(this.changepass_Click);
                // 
                // deleteusers
                // 
                load_bar.Increment(1);
                this.deleteusers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.deleteusers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                resources.ApplyResources(this.deleteusers, "deleteusers");
                this.deleteusers.ForeColor = System.Drawing.Color.White;
                this.deleteusers.Name = "deleteusers";
                this.deleteusers.TabIndex = 5;
                this.deleteusers.UseVisualStyleBackColor = true;
                this.deleteusers.Click += new System.EventHandler(this.deleteusers_Click);
                //
                // show_result
                //
                load_bar.Increment(1);
                this.show_result.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.show_result.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                resources.ApplyResources(this.show_result, "show_result");
                this.show_result.ForeColor = System.Drawing.Color.White;
                this.show_result.Name = "show_result";
                this.show_result.UseVisualStyleBackColor = true;
                this.show_result.Size = new Size(254, 27);
                this.show_result.TabIndex = 6;
                this.show_result.Location = new Point(819, 48);
                this.show_result.Text = "Zobrazit výsledky";
                this.show_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.show_result.Font = new System.Drawing.Font("Propaganda", 9.749f);
                this.show_result.Enabled = false;
                this.show_result.Click += new System.EventHandler(this.zobraz_vysledek);
                // 
                // Open_jpg
                // 
                load_bar.Increment(1);
                this.Open_jpg.FileName = "Obrázek na pozadí programu";
                this.Open_jpg.Multiselect = false;
                this.Open_jpg.Filter = "Obrázkové soubory (*.jpg, *.gif, *.png, *.tif)|*.jpg;*.gif;*.png;*.tif;*.bmp";
                // 
                // back
                // 
                load_bar.Increment(1);
                this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                resources.ApplyResources(this.back, "back");
                this.back.ForeColor = System.Drawing.Color.White;
                this.back.Location = new Point(back.Location.X, this.back.Location.Y + 100);
                this.back.Name = "back";
                this.back.UseVisualStyleBackColor = true;
                this.back.Click += new System.EventHandler(this.zobraz_test);
                // 
                // Login_btn
                // 
                load_bar.Increment(1);
                this.Login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.Login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                resources.ApplyResources(this.Login_btn, "Login_btn");
                this.Login_btn.ForeColor = System.Drawing.Color.White;
                this.Login_btn.Name = "Login_btn";
                this.Login_btn.TabIndex = 1;
                this.Login_btn.UseVisualStyleBackColor = true;
                this.Login_btn.Location = new Point(changepass.Location.X, changepass.Location.Y);
                this.Login_btn.Click += new System.EventHandler(this.Log_in_system);
                // 
                // Logout
                // 
                load_bar.Increment(1);
                this.Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                resources.ApplyResources(this.Logout, "Logout");
                this.Logout.ForeColor = System.Drawing.Color.White;
                this.Logout.Name = "Logout";
                this.Logout.TabIndex = 4;
                this.Logout.UseVisualStyleBackColor = true;
                this.Logout.Click += new System.EventHandler(this.Logout_Click);
                // 
                // createusers
                // 
                load_bar.Increment(1);
                this.createusers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
                this.createusers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                resources.ApplyResources(this.createusers, "createusers");
                this.createusers.ForeColor = System.Drawing.Color.White;
                this.createusers.Name = "createusers";
                this.createusers.UseVisualStyleBackColor = true;
                this.createusers.TabIndex = 2;
                this.createusers.Location = new Point(deleteusers.Location.X, deleteusers.Location.Y);
                this.deleteusers.Location = new Point(show_result.Location.X, show_result.Location.Y);
                this.changepass.Location = new Point(createusers.Location.X, createusers.Location.Y + createusers.Size.Height + (createusers.Location.Y - Login_btn.Location.Y - Login_btn.Size.Height));
                this.show_result.Location = new Point(deleteusers.Location.X, changepass.Location.Y);
                this.createusers.Click += new System.EventHandler(this.new_user);
                // 
                // label31
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label31, "label31");
                this.label31.ForeColor = System.Drawing.Color.White;
                this.label31.Name = "label31";
                this.label31.TextAlign = ContentAlignment.MiddleLeft;
                // 
                // uzivatele
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.uzivatele, "uzivatele");
                this.uzivatele.Name = "uzivatele";
                this.uzivatele.Font = new System.Drawing.Font("Expo", 11.5f, FontStyle.Bold);
                this.uzivatele.DoubleClick += new System.EventHandler(this.Login_item);
                // 
                // vysledek_dat
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.vysledek_dat, "vysledek_dat");
                this.vysledek_dat.Size = this.uzivatele.Size;
                this.vysledek_dat.Name = "vysledky_dat";
                this.vysledek_dat.Location = new Point(this.uzivatele.Location.X + this.uzivatele.Size.Width + 50, this.uzivatele.Location.Y);
                this.vysledek_dat.Font = new System.Drawing.Font("Expo", 11.5f, FontStyle.Bold);
                this.vysledek_dat.DoubleClick += new System.EventHandler(this.zobraz_vysledek);
                // 
                // label32
                // 
                load_bar.Increment(1);
                resources.ApplyResources(this.label31, "label32");
                this.label32.ForeColor = System.Drawing.Color.White;
                this.label32.Name = "label32";
                this.label32.Text = "Výsledky testů";
                this.label32.Font = this.label31.Font;
                this.label32.AutoSize = true;
                this.label32.Location = new Point(vysledek_dat.Location.X, label31.Location.Y);


                
                // 
                // client
                // 
                this.load5_lbl.Text = "Načítání prvků bylo hotvo. Načítám klienta.";
                load5_lbl.Refresh();
                load_bar.Increment(1);
                this.Controls.Add(this.gen_menu);
                this.Controls.Add(this.generalpanel);
                this.Controls.Add(this.helpanel);
                this.Controls.Add(this.set_panel);
                this.Controls.Add(this.user_panel);
                this.AcceptButton = this.StartButton;
                this.AllowDrop = true;
                this.KeyPreview = true;
                this.Controls.Add(this.icoprog);
                this.Controls.Add(this.Title);
                this.Controls.Add(this.minmax);
                this.Controls.Add(this.mini);
                this.Controls.Add(this.konec);
                this.Controls.Add(this.Stavovyradek);
                this.Controls.Add(this.workspace);
                this.Controls.Add(this.presunpanel);
                this.Cursor = System.Windows.Forms.Cursors.Default;
                this.DoubleBuffered = true;
                this.ForeColor = System.Drawing.Color.White;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
                this.helpanel.ResumeLayout(false);
                this.generalpanel.ResumeLayout(false);
                this.Stavovyradek.ResumeLayout(false);
                this.Stavovyradek.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.soucinitel)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.delenec)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.scitanec)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.mensenec)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.exercise)).EndInit();
                this.setpanel.ResumeLayout(false);
                this.setpanel.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.icoprog)).EndInit();
                this.nabidka_prog.ResumeLayout(false);
                this.workspace.ResumeLayout(false);
                this.gen_menu.ResumeLayout(false);
                this.set_panel.ResumeLayout(false);
                this.user_panel.ResumeLayout(false);
                this.testpanel.ResumeLayout(false);
                this.testpanel.PerformLayout();
                this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                ((System.ComponentModel.ISupportInitialize)(this.prod10)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod9)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod4)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod3)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod2)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod7)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod8)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod18)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod17)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod5)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod6)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod19)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod20)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod16)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod15)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod12)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod13)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod14)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.prod11)).EndInit();
                this.Userspanel.ResumeLayout(false);
                this.ResumeLayout(false);
                this.PerformLayout();
                load_bar.Increment(1);
                this.load5_lbl.Text = "Klient byl úspěšně načten. Načítám nastavení.";
                load5_lbl.Refresh();
                this.BackgroundImage = null;
            }
        }

        #endregion

        private System.Windows.Forms.Panel generalpanel;
        private System.Windows.Forms.Panel helpanel;
        private System.Windows.Forms.Button aplinfo;
        private System.Windows.Forms.Button showtest;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button showset;
        private System.Windows.Forms.StatusStrip Stavovyradek;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox last_time;
        private System.Windows.Forms.Button save_close;
        private System.Windows.Forms.Button unsave;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.NumericUpDown soucinitel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown delenec;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown scitanec;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown mensenec;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown exercise;
        private System.Windows.Forms.RichTextBox nastavt;
        private System.Windows.Forms.CheckBox sound;
        private System.Windows.Forms.Panel setpanel;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Button konec;
        private System.Windows.Forms.Button mini;
        private System.Windows.Forms.Button minmax;
        private System.Windows.Forms.PictureBox icoprog;
        private System.Windows.Forms.ContextMenuStrip nabidka_prog;
        private System.Windows.Forms.ToolStripMenuItem show_set_cms;
        private System.Windows.Forms.ToolStripMenuItem show_test_cms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem help_cms;
        private System.Windows.Forms.ToolStripMenuItem aplinfo_cms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem close_cms;
        private System.Windows.Forms.Label presunpanel;
        private System.Windows.Forms.NotifyIcon ikonka;
        private System.Windows.Forms.ToolStripMenuItem check_akt_cms;
        private System.Windows.Forms.Button check_akt;
        private System.Windows.Forms.CheckBox spravny_vys;
        private System.Windows.Forms.Timer odpocitavani;
        private System.Windows.Forms.Timer wait;
        private System.Windows.Forms.Panel workspace;
        private System.Windows.Forms.Panel Userspanel;
        private System.Windows.Forms.ToolStripMenuItem show_users_cms;
        internal System.Windows.Forms.ToolStripStatusLabel statuslabel1;
        internal System.Windows.Forms.ToolStripStatusLabel Název;
        internal System.Windows.Forms.ToolStripStatusLabel statuslabel2;
        internal System.Windows.Forms.ToolStripStatusLabel Link;
        internal System.Windows.Forms.ToolStripStatusLabel User;
        internal System.Windows.Forms.ToolStripStatusLabel statuslabel4;
        internal System.Windows.Forms.ToolStripStatusLabel User_name;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.ListBox uzivatele;
        private System.Windows.Forms.Button deleteusers;
        private System.Windows.Forms.Button createusers;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Button changepass;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel3;
        private System.Windows.Forms.ToolStripStatusLabel time_status;
        private System.Windows.Forms.Button load_user_set;
        private System.Windows.Forms.Button save_user_set;
        private System.Windows.Forms.Button showuser;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel testpanel;
        private System.Windows.Forms.RadioButton vse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label le9;
        private System.Windows.Forms.Label rovn9;
        private System.Windows.Forms.RadioButton nas;
        private System.Windows.Forms.NumericUpDown prod10;
        private System.Windows.Forms.Label ri9;
        private System.Windows.Forms.Label lomeno;
        private System.Windows.Forms.NumericUpDown prod9;
        private System.Windows.Forms.RadioButton od;
        private System.Windows.Forms.Label le10;
        private System.Windows.Forms.RadioButton del;
        private System.Windows.Forms.Label ri8;
        private System.Windows.Forms.Label rovn10;
        private System.Windows.Forms.Label rovn8;
        private System.Windows.Forms.Label ri10;
        private System.Windows.Forms.Label le8;
        private System.Windows.Forms.Label last_time_num;
        private System.Windows.Forms.Label zn7;
        private System.Windows.Forms.Label ri7;
        private System.Windows.Forms.Label last_time_label;
        private System.Windows.Forms.Label zn8;
        private System.Windows.Forms.Label rovn7;
        private System.Windows.Forms.Label zn9;
        private System.Windows.Forms.Label le1;
        private System.Windows.Forms.Label le7;
        private System.Windows.Forms.Label zn10;
        private System.Windows.Forms.Label rovn1;
        private System.Windows.Forms.NumericUpDown prod7;
        private System.Windows.Forms.Label ri1;
        private System.Windows.Forms.NumericUpDown prod8;
        private System.Windows.Forms.Label le2;
        private System.Windows.Forms.Label rovn2;
        private System.Windows.Forms.Label ri2;
        private System.Windows.Forms.NumericUpDown prod18;
        private System.Windows.Forms.Label le3;
        private System.Windows.Forms.NumericUpDown prod17;
        private System.Windows.Forms.Label rovn3;
        private System.Windows.Forms.Label le17;
        private System.Windows.Forms.Label ri3;
        private System.Windows.Forms.Label rovn17;
        private System.Windows.Forms.Label le4;
        private System.Windows.Forms.Label zn16;
        private System.Windows.Forms.Label ri17;
        private System.Windows.Forms.Label rovn4;
        private System.Windows.Forms.Label zn15;
        private System.Windows.Forms.Label le18;
        private System.Windows.Forms.Label ri4;
        private System.Windows.Forms.Label zn14;
        private System.Windows.Forms.Label rovn18;
        private System.Windows.Forms.NumericUpDown prod5;
        private System.Windows.Forms.Label zn13;
        private System.Windows.Forms.Label ri18;
        private System.Windows.Forms.NumericUpDown prod6;
        private System.Windows.Forms.Label zn12;
        private System.Windows.Forms.NumericUpDown prod19;
        private System.Windows.Forms.Label le5;
        private System.Windows.Forms.Label zn11;
        private System.Windows.Forms.NumericUpDown prod20;
        private System.Windows.Forms.Label rovn5;
        private System.Windows.Forms.Label ri16;
        private System.Windows.Forms.Label le19;
        private System.Windows.Forms.Label ri5;
        private System.Windows.Forms.Label rovn16;
        private System.Windows.Forms.Label rovn19;
        private System.Windows.Forms.Label le6;
        private System.Windows.Forms.Label le16;
        private System.Windows.Forms.Label ri19;
        private System.Windows.Forms.Label rovn6;
        private System.Windows.Forms.Label ri15;
        private System.Windows.Forms.Label ri6;
        private System.Windows.Forms.Label le20;
        private System.Windows.Forms.Label rovn15;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label rovn20;
        private System.Windows.Forms.Label le15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label ri20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown prod16;
        private System.Windows.Forms.RadioButton sc;
        private System.Windows.Forms.Label zn17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown prod15;
        private System.Windows.Forms.Label zn1;
        private System.Windows.Forms.Label zn18;
        private System.Windows.Forms.Label sprv20;
        private System.Windows.Forms.Label ri14;
        private System.Windows.Forms.Label zn2;
        private System.Windows.Forms.Label zn19;
        private System.Windows.Forms.Label sprv19;
        private System.Windows.Forms.Label rovn14;
        private System.Windows.Forms.Label zn3;
        private System.Windows.Forms.Label zn20;
        private System.Windows.Forms.Label sprv18;
        private System.Windows.Forms.Label le14;
        private System.Windows.Forms.Label zn4;
        private System.Windows.Forms.Label sprv17;
        private System.Windows.Forms.Label ri13;
        private System.Windows.Forms.Label zn5;
        private System.Windows.Forms.Label sprv16;
        private System.Windows.Forms.Label rovn13;
        private System.Windows.Forms.Label zn6;
        private System.Windows.Forms.Label sprv15;
        private System.Windows.Forms.Label le13;
        private System.Windows.Forms.Label sprv14;
        private System.Windows.Forms.Label ri12;
        private System.Windows.Forms.Label sprv13;
        private System.Windows.Forms.Label rovn12;
        private System.Windows.Forms.Label sprv12;
        private System.Windows.Forms.Label le12;
        private System.Windows.Forms.Label sprv11;
        private System.Windows.Forms.Label ri11;
        private System.Windows.Forms.Label sprv1;
        private System.Windows.Forms.Label sprv10;
        private System.Windows.Forms.Label rovn11;
        private System.Windows.Forms.Label sprv2;
        private System.Windows.Forms.Label sprv9;
        private System.Windows.Forms.Label le11;
        private System.Windows.Forms.Label sprv3;
        private System.Windows.Forms.Label sprv8;
        private System.Windows.Forms.NumericUpDown prod12;
        private System.Windows.Forms.Label sprv4;
        private System.Windows.Forms.Label sprv7;
        private System.Windows.Forms.NumericUpDown prod13;
        private System.Windows.Forms.NumericUpDown prod14;
        private System.Windows.Forms.Label sprv5;
        private System.Windows.Forms.Label sprv6;
        private System.Windows.Forms.NumericUpDown prod11;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button endbutton;
        private System.Windows.Forms.NumericUpDown prod4;
        private System.Windows.Forms.NumericUpDown prod1;
        private System.Windows.Forms.NumericUpDown prod3;
        private System.Windows.Forms.NumericUpDown prod2;
        internal System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button dotace;
        private System.Windows.Forms.ToolStripMenuItem přispětToolStripMenuItem;
        private System.Windows.Forms.Panel gen_menu;
        private System.Windows.Forms.Button general;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button napoveda;
        private System.Windows.Forms.Panel user_panel;
        private System.Windows.Forms.Button user_out;
        private System.Windows.Forms.Button user_change;
        private System.Windows.Forms.Button user_plus;
        private System.Windows.Forms.Button user_in;
        private System.Windows.Forms.Panel set_panel;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button user_minus;
        private System.Windows.Forms.Button krat;
        private System.Windows.Forms.Button odpocet;
        private System.Windows.Forms.Button deleno;
        private System.Windows.Forms.Button language;
        private System.Windows.Forms.Button pocet_pr;
        private System.Windows.Forms.Button user_list;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListView languages;
        private System.Windows.Forms.Panel Load_panel;
        private System.Windows.Forms.Label load1_lbl;
        private System.Windows.Forms.Label load3_lbl;
        private System.Windows.Forms.Label load2_lbl;
        private System.Windows.Forms.Label load4_lbl;
        private System.Windows.Forms.ProgressBar load_bar;
        private System.Windows.Forms.Label load5_lbl;
        private System.Windows.Forms.OpenFileDialog Open_jpg;
        private System.Windows.Forms.ColorDialog Open_clr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button chng_m_clr;
        private System.Windows.Forms.Button chng_prg_jpg;
        private System.Windows.Forms.Button chng_prg_clr;
        private System.Windows.Forms.Button show_result;
        private System.Windows.Forms.ListBox vysledek_dat;
        internal System.Windows.Forms.Label label32;
        private System.Windows.Forms.ToolTip popisek;
    }
}

