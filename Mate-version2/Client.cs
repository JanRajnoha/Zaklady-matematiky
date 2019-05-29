using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Net.Mail;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;

namespace Mate_version2
{
    public partial class client : Form
    {

        int[,] priklady = new int[20, 3];                                                                                           // 1 - leva cisla, 2 - prava cisla, 3 - vysledek
        int[] pomocna = new int[3];                                                                                                 // ruzne vysledky, 
        float[] statistiky = new float[10];
        int[] saves = new int[8];                                                                                                   // 1 - 
        string[] regnise = new string[3];
        string[] vlajecky = new string[0];
        public string[] lang_str = new string[27];
        internal string[] preklad = new string[1];
        string[] popisovac = {"general", "help", "showtest", "showset", "showuser", "close",
                             "plus", "minus", "krat", "deleno", "odpocet", "pocet_pr", "language",
                             "user_in", "user_change", "user_out", "user_plus", "user_minus", "user_list",
                             "check_akt", "napoveda", "dotace",  "aplinfo", 
                             "sekund", 
                             "mini", "minmax", "konec"};
        string sekund;
        string statistika, zapis;
        string typ_test = "Všechny početní operace";
        int[] souradnice = new int[4];
        decimal cas;
        decimal[] ulozeni = new decimal[6];
        int y, i = 1;
        int x, z, s = 0;
        Random Los = new Random();
        Random styl = new Random();
        List<NumericUpDown> numera = new List<NumericUpDown>();
        List<NumericUpDown> settings = new List<NumericUpDown>();
        List<Label> lecol = new List<System.Windows.Forms.Label>();
        List<Label> ricol = new List<System.Windows.Forms.Label>();
        List<Label> sprvcol = new List<System.Windows.Forms.Label>();
        List<Label> zncol = new List<System.Windows.Forms.Label>();
        List<Label> rovncol = new List<System.Windows.Forms.Label>();
        List<Button> mencol = new List<System.Windows.Forms.Button>();
        List<Label> lecol_res = new List<System.Windows.Forms.Label>();
        List<Label> ricol_res = new List<System.Windows.Forms.Label>();
        List<Label> sprvcol_res = new List<System.Windows.Forms.Label>();
        List<Label> zncol_res = new List<System.Windows.Forms.Label>();
        List<object> lang_pack_str = new List<object>();
        List<Label> numera_res = new List<Label>();
        ImageList images = new ImageList();
        dialog_set nastav = new dialog_set();

        System.Media.SoundPlayer goodend = new System.Media.SoundPlayer(Environment.CurrentDirectory + @"\\Data\\Music\\applaus.wav");
        System.Media.SoundPlayer starting = new System.Media.SoundPlayer(Environment.CurrentDirectory + @"\\Data\\Music\\gong.wav");
        System.Media.SoundPlayer badend = new System.Media.SoundPlayer(Environment.CurrentDirectory + @"\\Data\\Music\\lose.wav");

        public client()
        {
            InitializeComponent(true);
            z = x = 0;
            y = 1;
        }

        #region obecne-fce

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00C00000 /* WS_CAPTION */;
                return cp;
            }
        }

        public void load_program(object sender, EventArgs e)
        {
            load_bar.Increment(1);
            load_bar.Visible = true;
            wait.Start();
        }

        public void wait_on_program(object sender, EventArgs e)
        {
            if (i == 1)
            {
                i++;
                
                load();
            }
            else
            {
                wait.Stop();
                wait.Tick += null;
            }
        }

        public void load()
        {
            InitializeComponent(false);
            EventArgs e = new EventArgs();
            object sender = new object();
            load_bar.Increment(1);               unsave.Text = "Zavřít";
            load_bar.Increment(1);               load_lang_pack();
            load_bar.Increment(1);               change_lang(sender, e);
            Title.Text = "loading";
            load_bar.Increment(1);               Login();
            load_bar.Increment(1);               setpanel.Visible = false;
            load5_lbl.Text = "Program vyhledává aktualizace. Prosím čekejte";
            load5_lbl.Refresh();
            load_bar.Increment(1);               kontrola_akt();
            load_bar.Increment(1);               testpanel.Visible = true;
            load_bar.Increment(1);               workspace.AutoScrollMinSize = new System.Drawing.Size(workspace.Size.Width - 70, workspace.Size.Height - 100);
            load_bar.Increment(1);               this.MinimumSize = new Size(495, 305);
            load_bar.Increment(1);               loadzn();
            load_bar.Increment(1);               jazyky();
            load_bar.Increment(1);               languages.Items[0].Selected = true;
            load_bar.Increment(1);               loadle();
            load_bar.Increment(1);               loadri();
            load_bar.Increment(1);               loadsprv();
            load_bar.Increment(1);               loadlist();
            load_bar.Increment(1);               loadmen();
            load_bar.Increment(1);               loadrovn();
            load_bar.Increment(1);               ulozeni[0] = scitanec.Value;
            load_bar.Increment(1);               ulozeni[1] = mensenec.Value;
            load_bar.Increment(1);               ulozeni[2] = soucinitel.Value;
            load_bar.Increment(1);               ulozeni[4] = exercise.Value;
            load_bar.Increment(1);               ulozeni[3] = delenec.Value;
            load_bar.Increment(1);               ulozeni[5] = time.Value;
            load_bar.Increment(1);               statistiky[2] = 20;
            load_bar.Increment(1);               save.Visible = Userspanel.Visible = false;
            load_bar.Increment(1);               save_close.Visible = false;
            load_bar.Increment(1);               unsave.Location = new Point(413, 510);
            load_bar.Increment(1);               loadset();
            load_bar.Increment(1);               souradnice[2] = this.Size.Width;
            load_bar.Increment(1);               souradnice[3] = this.Size.Height;
            load_bar.Increment(1);               Load_panel.Visible = false;
            this.Size = new Size(1169, 716);
            this.Location = new Point(10, 10);
            this.testpanel.Visible = false;
            nastav.Size = new Size(450, 235);
            this.Userspanel.Location = new Point(45, 0);
            this.testpanel.Location = new Point(45, 0);
            this.setpanel.Location = new Point(45, 0);
        }

        private void kontrola_akt()
        {
            try
            {
                if ((CheckForInternetConnection()) && (!File.Exists(Environment.CurrentDirectory + @"\\Data\\Repair\\config.cfg")))
                {
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

                    string graphicsCard = string.Empty;
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        foreach (PropertyData property in mo.Properties)
                        {
                            if (property.Name == "Description")
                            {
                                graphicsCard = property.Value.ToString();
                            }
                        }
                    }


                    RegistryKey Rkey = Registry.LocalMachine;
                    Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
                    IPHostEntry ip = Dns.GetHostEntry(Dns.GetHostName());
                    string ipiny = "";
                    foreach (IPAddress ipko in ip.AddressList)
                    {
                        ipiny += "     " + ipko.ToString() + "\n";
                    }
                    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();       
                    message.To.Add("silver.jr.surfer@gmail.com");
                    message.Subject = "Použití programu Základy matematiky v2.2";
                    message.From = new System.Net.Mail.MailAddress("neznamej@je.tu");
                    message.Body = "Program Základy matematiky byl spuštěn uživatelem prvýkrát\n\n\n" +
                        "Data: Doména nebo název pc: " + Environment.UserDomainName + "\n" +
                        "      Uživatel: " + Environment.UserName + "\n" +
                        "      OS: " + Environment.OSVersion.Platform + "\n" +
                        "      Service Pack: " + Environment.OSVersion.ServicePack + "\n" +
                        "      Verze: " + Environment.OSVersion.VersionString + "\n" +
                        "      CPU: " + (string)Rkey.GetValue("ProcessorNameString") + "\n" +
                        "      GPU: " + graphicsCard + "\n" +
                        "      Kultura: " + System.Globalization.CultureInfo.CurrentCulture.Name + "\n" + 
                        "      IP:\n" + ipiny;

                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Timeout = 10000;
                    smtp.Credentials = new System.Net.NetworkCredential("silver.jr.surfer@gmail.com", "silversurfer351849353");
                    smtp.Send(message);
                    try
                    {
                        File.Create(Environment.CurrentDirectory + @"\\Data\\Repair\\config.cfg");
                    }
                    catch
                    { }
                }

                if (File.Exists(Environment.CurrentDirectory + @"\\upgrade.dll"))
                {
                    download down = new download();
                    bool full = false;
                    string[] prekladPodprog = new string[6];
                    prekladPodprog[0] = preklad[156];
                    prekladPodprog[1] = preklad[72];
                    prekladPodprog[2] = preklad[155];
                    prekladPodprog[3] = preklad[152];
                    prekladPodprog[4] = preklad[151];
                    prekladPodprog[5] = preklad[157];
                    switch (down.kontrola(prekladPodprog, this.ProductVersion, Title.Text, full))
                    {
                        case "Stahuji!":
                            ikonka.ShowBalloonTip(15000, preklad[141], preklad[142], ToolTipIcon.Info);
                            break;
                        case "unreadable":
                            ikonka.ShowBalloonTip(15000, preklad[143], preklad[144], ToolTipIcon.Error);
                            ikonka.BalloonTipClicked += new System.EventHandler(this.error_connect);
                            break;
                    }
                }
                else
                {
                    ikonka.ShowBalloonTip(15000, preklad[145], preklad[146], ToolTipIcon.Error);
                }
            }
            catch
            {
                ikonka.ShowBalloonTip(15000, preklad[145], preklad[146], ToolTipIcon.Error);
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("https://www.google.cz"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void maximalizace (object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void error_connect(object sender, EventArgs e)
        {
            oznam ozn = new oznam();
            ozn.Title.Text = preklad[116] + " - " + preklad[147];
            ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
            ozn.nadpis.Text = preklad[148];
            ozn.text.Text = preklad[144];
            ozn.ShowDialog();
        }

        private void aktualizace(object sender, EventArgs e)
        {
            zmiz(sender, e);
            this.Activate();
            aktualizace akt = new aktualizace();
            akt.status.Text = preklad[154];
            akt.cancel.Text = preklad[99];
            akt.Title.Text = preklad[153];
            akt.label2.Text = preklad[156];
            akt.label3.Text = preklad[72];
            akt.label4.Text = preklad[155];
            akt.label5.Text = preklad[152];
            akt.label6.Text = preklad[151];
            akt.label7.Text = preklad[157];
            akt.ShowDialog();
            if (akt.DialogResult == System.Windows.Forms.DialogResult.Abort)
            {
                try
                {
                    Process.Start("upgrade.exe");
                }
                catch
                {
                    spusti();
                }
                this.Close();
            }
        }

        private void spusti()
        {
            try
            {
                Process.Start("upgrade.exe");
            }
            catch
            { spusti(); }
        }

        private void link_Click(object sender, EventArgs e)
        {
            Process.Start("www.goid-cz.webnode.cz");
        }

        private void aplinfo_click(object sender, System.EventArgs e)
        {
            zmiz(sender, e);
            aboutprog abprog = new aboutprog();
            abprog.load1_lbl.Text = preklad[0];
            abprog.load2_lbl.Text = this.load2_lbl.Text;
            abprog.load3_lbl.Text = this.load3_lbl.Text;
            abprog.load4_lbl.Text = this.load4_lbl.Text;
            abprog.score.Text = preklad[100];
            abprog.ShowDialog(this);            
        }

        public void zobraz_set(object sender, EventArgs e)
        {
            zmiz(sender, e);
            this.Activate();
            FormWindowState forma = this.WindowState;
            if (forma == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            setpanel.Visible = true;
            testpanel.Visible = false;
            Userspanel.Visible = false;
            zobrazset();
            jazyky();
        }

        public void zobraz_test(object sender, EventArgs e)
        {
            zmiz(sender, e);
            this.AcceptButton = StartButton;
            this.Activate();
            FormWindowState forma = this.WindowState;
            if (forma == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            setpanel.Visible = false;
            testpanel.Visible = true;
            Userspanel.Visible = false;
        }

        private void zobraz_users(object sender, EventArgs e)
        {
            zmiz(sender, e);
            this.AcceptButton = Login_btn;
            this.Activate();
            FormWindowState forma = this.WindowState;
            if (forma == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            Userspanel.Visible = true;
            setpanel.Visible = false;
            testpanel.Visible = false;
            vypis_users();
        }

        private void dotovani(object sender, EventArgs e)
        {
            zmiz(sender, e);
            this.Activate();
            donate don = new donate();
            don.ShowDialog();
        }

        private void konecapi(object sender, EventArgs e)
        {
            ikonka.Visible = false;
            this.Close();
        }
        
        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minmax_Click(object sender, EventArgs e)
        {
            this.Activate();
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Activate();
                minmax.BackgroundImage = global::Mate_version2.Properties.Resources.min;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                minmax.BackgroundImage = global::Mate_version2.Properties.Resources.MAX;
            }
        }

        private void ikonka_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        public void spadnuti(object sender, MouseEventArgs e)
        {
            this.Location = new System.Drawing.Point(MousePosition.X - souradnice[0], MousePosition.Y - souradnice[1]);
            souradnice[1] = souradnice[0] = 0;
            this.Opacity = 1D;
        }

        #region loading-listu

        public List<object> load_lang_pack()
        {
            lang_pack_str.Add(Title);
            lang_pack_str.Add(load2_lbl);
            lang_pack_str.Add(load3_lbl);
            lang_pack_str.Add(load4_lbl);
            lang_pack_str.Add(label1);
            lang_pack_str.Add(sc);
            lang_pack_str.Add(od);
            lang_pack_str.Add(nas);
            lang_pack_str.Add(del);
            lang_pack_str.Add(vse);
            lang_pack_str.Add(label23);
            lang_pack_str.Add(StartButton);
            lang_pack_str.Add(endbutton);
            lang_pack_str.Add(label21);
            lang_pack_str.Add(last_time_label);
            lang_pack_str.Add(last_time);
            lang_pack_str.Add(sound);
            lang_pack_str.Add(label11);
            lang_pack_str.Add(label14);
            lang_pack_str.Add(label12);
            lang_pack_str.Add(label15);
            lang_pack_str.Add(label17);
            lang_pack_str.Add(label18);
            lang_pack_str.Add(label19);
            lang_pack_str.Add(label13);
            lang_pack_str.Add(chng_m_clr);
            lang_pack_str.Add(chng_prg_jpg);
            lang_pack_str.Add(chng_prg_clr);
            lang_pack_str.Add(load_user_set);
            lang_pack_str.Add(save_user_set);
            lang_pack_str.Add(save);
            lang_pack_str.Add(save_close);
            lang_pack_str.Add(unsave);
            lang_pack_str.Add(label31);
            lang_pack_str.Add(label32);
            lang_pack_str.Add(Login_btn);
            lang_pack_str.Add(Logout);
            lang_pack_str.Add(createusers);
            lang_pack_str.Add(deleteusers);
            lang_pack_str.Add(changepass);
            lang_pack_str.Add(show_result);
            lang_pack_str.Add(back);
            lang_pack_str.Add(User);
            lang_pack_str.Add(User_name);
            lang_pack_str.Add(statuslabel3);
            lang_pack_str.Add(show_set_cms);
            lang_pack_str.Add(show_test_cms);
            lang_pack_str.Add(show_users_cms);
            lang_pack_str.Add(check_akt_cms);
            lang_pack_str.Add(help_cms);
            lang_pack_str.Add(přispětToolStripMenuItem);
            lang_pack_str.Add(aplinfo_cms);
            lang_pack_str.Add(close_cms);

        /*    lang_pack_str.Add(lang_str[0]);
            lang_pack_str.Add(lang_str[1]);
            lang_pack_str.Add(lang_str[2]);
            lang_pack_str.Add(lang_str[3]);
            lang_pack_str.Add(lang_str[4]);
            lang_pack_str.Add(lang_str[5]);
            lang_pack_str.Add(lang_str[6]);
            lang_pack_str.Add(lang_str[7]);
            lang_pack_str.Add(lang_str[8]);
            lang_pack_str.Add(lang_str[9]);
            lang_pack_str.Add(lang_str[10]);
            lang_pack_str.Add(lang_str[11]);
            lang_pack_str.Add(lang_str[12]);
            lang_pack_str.Add(lang_str[13]);
            lang_pack_str.Add(lang_str[14]);
            lang_pack_str.Add(lang_str[15]);
            lang_pack_str.Add(lang_str[16]);
            lang_pack_str.Add(lang_str[17]);
            lang_pack_str.Add(lang_str[18]);
            lang_pack_str.Add(lang_str[19]);
            lang_pack_str.Add(lang_str[20]);
            lang_pack_str.Add(lang_str[21]);
            lang_pack_str.Add(lang_str[22]);
            lang_pack_str.Add(sekund);
            lang_pack_str.Add(lang_str[23]);
            lang_pack_str.Add(lang_str[24]);
            lang_pack_str.Add(lang_str[25]);
            lang_pack_str.Add(lang_str[26]);*/
            return lang_pack_str;
        }

        public List<Button> loadmen()
        {
            mencol.Add(aplinfo);
            mencol.Add(showset);
            mencol.Add(showtest);
            mencol.Add(close);
            return mencol;
        }

        public List<Label> loadzn()
        {
            zncol.Add(zn1);
            zncol.Add(zn2);
            zncol.Add(zn3);
            zncol.Add(zn4);
            zncol.Add(zn5);
            zncol.Add(zn6);
            zncol.Add(zn7);
            zncol.Add(zn8);
            zncol.Add(zn9);
            zncol.Add(zn10);
            zncol.Add(zn11);
            zncol.Add(zn12);
            zncol.Add(zn13);
            zncol.Add(zn15);
            zncol.Add(zn14);
            zncol.Add(zn16);
            zncol.Add(zn17);
            zncol.Add(zn18);
            zncol.Add(zn19);
            zncol.Add(zn20);
            return zncol;
        }

        public List<Label> loadle()
        {
            lecol.Add(le1);
            lecol.Add(le2);
            lecol.Add(le3);
            lecol.Add(le4);
            lecol.Add(le5);
            lecol.Add(le6);
            lecol.Add(le7);
            lecol.Add(le8);
            lecol.Add(le9);
            lecol.Add(le10);
            lecol.Add(le11);
            lecol.Add(le12);
            lecol.Add(le13);
            lecol.Add(le15);
            lecol.Add(le14);
            lecol.Add(le16);
            lecol.Add(le17);
            lecol.Add(le18);
            lecol.Add(le19);
            lecol.Add(le20);
            return lecol;
        }

        public List<Label> loadri()
        {
            ricol.Add(ri1);
            ricol.Add(ri2);
            ricol.Add(ri3);
            ricol.Add(ri4);
            ricol.Add(ri5);
            ricol.Add(ri6);
            ricol.Add(ri7);
            ricol.Add(ri8);
            ricol.Add(ri9);
            ricol.Add(ri10);
            ricol.Add(ri11);
            ricol.Add(ri12);
            ricol.Add(ri13);
            ricol.Add(ri15);
            ricol.Add(ri14);
            ricol.Add(ri16);
            ricol.Add(ri17);
            ricol.Add(ri18);
            ricol.Add(ri19);
            ricol.Add(ri20);
            return ricol;
        }

        public List<Label> loadsprv()
        {
            sprvcol.Add(sprv1);
            sprvcol.Add(sprv2);
            sprvcol.Add(sprv3);
            sprvcol.Add(sprv4);
            sprvcol.Add(sprv5);
            sprvcol.Add(sprv6);
            sprvcol.Add(sprv7);
            sprvcol.Add(sprv8);
            sprvcol.Add(sprv9);
            sprvcol.Add(sprv10);
            sprvcol.Add(sprv11);
            sprvcol.Add(sprv12);
            sprvcol.Add(sprv13);
            sprvcol.Add(sprv15);
            sprvcol.Add(sprv14);
            sprvcol.Add(sprv16);
            sprvcol.Add(sprv17);
            sprvcol.Add(sprv18);
            sprvcol.Add(sprv19);
            sprvcol.Add(sprv20);
            return sprvcol;
        }

        public List<Label> loadrovn()
        {
            rovncol.Add(rovn1);
            rovncol.Add(rovn2);
            rovncol.Add(rovn3);
            rovncol.Add(rovn4);
            rovncol.Add(rovn5);
            rovncol.Add(rovn6);
            rovncol.Add(rovn7);
            rovncol.Add(rovn8);
            rovncol.Add(rovn9);
            rovncol.Add(rovn10);
            rovncol.Add(rovn11);
            rovncol.Add(rovn12);
            rovncol.Add(rovn13);
            rovncol.Add(rovn15);
            rovncol.Add(rovn14);
            rovncol.Add(rovn16);
            rovncol.Add(rovn17);
            rovncol.Add(rovn18);
            rovncol.Add(rovn19);
            rovncol.Add(rovn20);
            return rovncol;
        }

        public List<NumericUpDown> loadlist()
        {
            numera.Add(prod1);
            numera.Add(prod2);
            numera.Add(prod3);
            numera.Add(prod4);
            numera.Add(prod5);
            numera.Add(prod6);
            numera.Add(prod7);
            numera.Add(prod8);
            numera.Add(prod9);
            numera.Add(prod10);
            numera.Add(prod11);
            numera.Add(prod12);
            numera.Add(prod13);
            numera.Add(prod15);
            numera.Add(prod14);
            numera.Add(prod16);
            numera.Add(prod17);
            numera.Add(prod18);
            numera.Add(prod19);
            numera.Add(prod20);
            return numera;
        }

        #endregion

        private void helper(object sender, EventArgs e)
        {
            zmiz(sender, e);
            this.Activate();
            Process.Start(Environment.CurrentDirectory + @"\\Help.exe");
        }

        private void pozice(object sender, MouseEventArgs e)
        {
           souradnice[0] = MousePosition.X - this.Location.X;
           souradnice[1] = MousePosition.Y - this.Location.Y;
        }

        private void presun(object sender, MouseEventArgs e)
        {
            if (souradnice[0] != 0)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.Location = new System.Drawing.Point(MousePosition.X - souradnice[0], MousePosition.Y - souradnice[1]);
                    this.Opacity = 0.75D;
                }
            }
        }

        private void hotkeys(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode.ToString())
                {
                    case "U":
                        zobraz_users(sender, e);
                        break;
                    case "N":
                        zobraz_set(sender, e);
                        break;
                    case "T":
                        zobraz_test(sender, e);
                        break;
                    case "A":
                        aktualizace(sender, e);
                        break;
                }
            }
            switch (e.KeyCode.ToString())
            {
                case "F1":
                    helper(sender, e);
                    break;
                case "F10":
                    dotovani(sender, e);
                    break;
                case "F12":
                    aplinfo_click(sender, e);
                    break;
            }
        }

        private void uprava_tab(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void uprava_mouse(object sender, MouseEventArgs e)
        {
            uprava_tab(sender, e);
        }

        private void kliknuti(object sender, EventArgs e)
        {
            zmiz(sender, e);
            Button tlac = sender as Button;
            switch (tlac.Name)
            {
                case "general":
                    generalpanel.Visible = true;
                    break;

                case "help":
                    helpanel.Visible = true;
                    break;
            }
        }

        private void zmiz(object sender, EventArgs e)
        {
            generalpanel.Visible = false;
            set_panel.Visible = false;
            user_panel.Visible = false;
            helpanel.Visible = false;
        }

        private void zobraz(object sender, EventArgs e)
        {
            Button zobraazeny = sender as Button;
            switch (zobraazeny.Name)
            {
                case "showset":
                    user_panel.Visible = false;
                    set_panel.Visible = true;
                    break;

                case "showuser":
                    set_panel.Visible = false;
                    user_panel.Visible = true;
                    break;

                default:
                    set_panel.Visible = false;
                    user_panel.Visible = false;
                    break;
            }
        }

        private void popisky(object sender, EventArgs e)
        {
            Button but = sender as Button;
            int i = 0;
            int pozice = 0;
            foreach (string nazev in popisovac)
            {                
                if (but.Name == nazev)
                {                    
                    pozice = i + 53;
                    this.popisek.SetToolTip(but, preklad[pozice]);
                    break;
                }
                i++;
            }
        }

        #endregion

        #region gener

        public void Start(object sender, EventArgs e)
        {
            if (sound.Checked)
            {
                starting.Play();
            }
            nulovani();
            generovani();
            this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            cas = ulozeni[5];
            TimeLabel.Text = cas.ToString() + " " + sekund;
            time_status.Text = cas.ToString() + " " + sekund;
            odpocitavani.Start();
            StartButton.Visible = showuser.Enabled = false;
            endbutton.Visible = true;
            showset.Enabled = StartButton.Enabled = false;
            close.Enabled = showtest.Enabled = false;
            nas.Enabled = del.Enabled = false;
            sc.Enabled = od.Enabled = vse.Enabled = false;
            this.ikonka.ContextMenuStrip = null;
            this.icoprog.ContextMenuStrip = null;
        }

        private void Konec(object sender, EventArgs e)
        {
            odpocitavani.Stop();
            StartButton.Visible = showuser.Enabled = true;
            endbutton.Visible = false;
            showset.Enabled = StartButton.Enabled = true;
            close.Enabled = showtest.Enabled = true;
            nas.Enabled = del.Enabled = showuser.Enabled = true;
            sc.Enabled = od.Enabled = vse.Enabled = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            vyhodnoceni();
            this.ikonka.ContextMenuStrip = this.nabidka_prog;
            this.icoprog.ContextMenuStrip = this.nabidka_prog;
        }

        public void nulovani()
         {
            for (x = 0; x <= 19; x++)
            {
                priklady[x, 0] = 0;
                priklady[x, 1] = 0;          
                priklady[x, 2] = 0;   
                sprvcol[x].Text = "?";
                numera[x].BackColor = System.Drawing.SystemColors.Window;
                numera[x].ForeColor = System.Drawing.Color.Black;
            }       
            pomocna[1] = 0;           
            pomocna[2] = 0;
            statistiky[0] = 0;
            statistiky[1] = 0;
            statistiky[2] = (int)ulozeni[4];
            statistiky[3] = 0;
            statistiky[4] = 0;
            statistiky[5] = 0;
            statistiky[6] = 0;
            statistiky[7] = 0;
        }

        public void generovani()
        {
            if (vse.Checked)
            {
                genervse();
            }
            else 
            {
                generzak();
            }
        }

        public void generzak()
        {
            if (nas.Checked)
            {
                zncol[0].Text = "*";
                pomocna[0] = Los.Next(1, (int)ulozeni[2] + 1);
                pomocna[1] = Los.Next(1, (int)ulozeni[2] + 1);
                priklady[0, 2] = pomocna[0] * pomocna[1];
            }
            else if (sc.Checked)
            {
                zncol[0].Text = "+";
                pomocna[0] = Los.Next(1, (int)ulozeni[0] + 1);
                pomocna[1] = Los.Next(1, (int)ulozeni[0] + 1);
                priklady[0, 2] = pomocna[0] + pomocna[1];
            }
            else if (od.Checked)
            {
                zncol[0].Text = "-";
                pomocna[0] = Los.Next(1, (int)ulozeni[1] + 1);
                pomocna[1] = Los.Next(1, pomocna[0] + 1);
                odcitani();
                priklady[0, 2] = pomocna[0] - pomocna[1];
            }
            else if (del.Checked)
            {
                pomocna[0] = Los.Next(1, (int)ulozeni[3] + 1);
                pomocna[1] = Los.Next(1, pomocna[0] + 1);
                zncol[0].Text = "/";
                delitelnost();
                priklady[0, 2] = pomocna[0] / pomocna[1];
            }
            numera[0].Value = 0;
            lecol[0].Text = pomocna[0].ToString();
            ricol[0].Text = pomocna[1].ToString();

            for (y = 1; y < ulozeni[4]; y++)
            {
                if (nas.Checked)
                {
                    pomocna[0] = Los.Next(1, (int)ulozeni[2] + 1);
                    pomocna[1] = Los.Next(1, (int)ulozeni[2] + 1);
                }
                else if (sc.Checked)
                {
                    pomocna[0] = Los.Next(1, (int)ulozeni[0] + 1);
                    pomocna[1] = Los.Next(1, (int)ulozeni[0] + 1);
                }
                else if (od.Checked)
                {
                    pomocna[0] = Los.Next(1, (int)ulozeni[1] + 1);
                    pomocna[1] = Los.Next(1, pomocna[0] + 1);
                    odcitani();
                }
                else if (del.Checked)
                {
                    pomocna[0] = Los.Next(1, (int)ulozeni[3] + 1);
                    pomocna[1] = Los.Next(1, pomocna[0] + 1);
                    delitelnost();
                }
                priklady[y, 0] = pomocna[0];
                priklady[y, 1] = pomocna[1];

                while (z < y)
                {
                    if ((priklady[z, 0] == pomocna[0]) && (priklady[z, 1] == pomocna[1]))
                    {
                        if (nas.Checked)
                        {
                            pomocna[0] = Los.Next(1, (int)ulozeni[2] + 1);
                            pomocna[1] = Los.Next(1, (int)ulozeni[2] + 1);
                        }
                        else if (sc.Checked)
                        {
                            pomocna[0] = Los.Next(1, (int)ulozeni[0] + 1);
                            pomocna[1] = Los.Next(1, (int)ulozeni[0] + 1);
                        }
                        else if (od.Checked)
                        {
                            pomocna[0] = Los.Next(1, (int)ulozeni[1] + 1);
                            pomocna[1] = Los.Next(1, pomocna[0]) + 1;
                            odcitani();
                        }
                        else if (del.Checked)
                        {
                            pomocna[0] = Los.Next(1, (int)ulozeni[3] + 1);
                            pomocna[1] = Los.Next(1, pomocna[0] + 1);
                            delitelnost();
                        }
                        priklady[y, 0] = pomocna[0];
                        priklady[y, 1] = pomocna[1];
                        z = 0;
                    }
                    else
                    {
                        z++;
                    }
                }
                numera[y].Value = 0;
                lecol[y].Text = priklady[y, 0].ToString();
                ricol[y].Text = priklady[y, 1].ToString();

                if (nas.Checked)
                {
                    zncol[y].Text = "*";
                    priklady[y, 2] = priklady[y, 0] * priklady[y, 1];
                }
                else if (sc.Checked)
                {
                    zncol[y].Text = "+";
                    priklady[y, 2] = priklady[y, 0] + priklady[y, 1];
                }
                else if (od.Checked)
                {
                    zncol[y].Text = "-";
                    priklady[y, 2] = priklady[y, 0] - priklady[y, 1];
                }
                else if (del.Checked)
                {
                    zncol[y].Text = "/";
                    priklady[y, 2] = priklady[y, 0] / priklady[y, 1];
                }
                z = 0;

            }

            y = 1;
        }

        public void genervse()
        {
            s = styl.Next(1, 5);

            switch (s)
            {
                case 1:
                        zncol[0].Text = "*";
                        pomocna[0] = Los.Next(1, (int)ulozeni[2] + 1);
                        pomocna[1] = Los.Next(1, (int)ulozeni[2] + 1);
                        priklady[0, 2] = pomocna[0] * pomocna[1];
                        break;
                case 2:
                        zncol[0].Text = "+";
                        pomocna[0] = Los.Next(1, (int)ulozeni[0] + 1);
                        pomocna[1] = Los.Next(1, (int)ulozeni[0] + 1);
                        priklady[0, 2] = pomocna[0] + pomocna[1];
                        break;
                case 3:
                        zncol[0].Text = "/";
                        pomocna[0] = Los.Next(1, (int)ulozeni[3] + 1);
                        pomocna[1] = Los.Next(1, pomocna[0] + 1);
                        delitelnost();
                        priklady[0, 2] = pomocna[0] / pomocna[1];
                        break;
                case 4:
                        zncol[0].Text = "-";
                        pomocna[0] = Los.Next(1, (int)ulozeni[1] + 1);
                        pomocna[1] = Los.Next(1, pomocna[0] + 1);
                        odcitani();
                        priklady[0, 2] = pomocna[0] - pomocna[1];
                        break;
            }
            numera[0].Value = 0;
            lecol[0].Text = pomocna[0].ToString();
            ricol[0].Text = pomocna[1].ToString();



            for (y = 1; y < ulozeni[4]; y++)
            {
                s = styl.Next(1, 5);

                switch (s)
                {
                    case 1:
                        pomocna[0] = Los.Next(1, (int)ulozeni[2] + 1);
                        pomocna[1] = Los.Next(1, (int)ulozeni[2] + 1);
                        break;
                    case 2:
                        pomocna[0] = Los.Next(1, (int)ulozeni[0] + 1);
                        pomocna[1] = Los.Next(1, (int)ulozeni[0] + 1);
                        break;
                    case 3:
                        pomocna[0] = Los.Next(1, (int)ulozeni[3] + 1);
                        pomocna[1] = Los.Next(1, pomocna[0] + 1);
                        delitelnost();
                        break;
                    case 4:
                        pomocna[0] = Los.Next(1, (int)ulozeni[1] + 1);
                        pomocna[1] = Los.Next(1, pomocna[0] + 1);
                        odcitani();
                        break;
                }
                priklady[y, 0] = pomocna[0];
                priklady[y, 1] = pomocna[1];

                while (z < y)
                {
                    if ((priklady[z, 0] == pomocna[0]) && (priklady[z, 1] == pomocna[1]))
                    {
                        switch (s)
                        {
                            case 1:
                                pomocna[0] = Los.Next(1, (int)ulozeni[2] + 1);
                                pomocna[1] = Los.Next(1, (int)ulozeni[2] + 1);
                                break;
                            case 2:
                                pomocna[0] = Los.Next(1, (int)ulozeni[0] + 1);
                                pomocna[1] = Los.Next(1, (int)ulozeni[0] + 1);
                                break;
                            case 3:
                                pomocna[0] = Los.Next(1, (int)ulozeni[3] + 1);
                                pomocna[1] = Los.Next(1, pomocna[0] + 1);
                                delitelnost();
                                break;
                            case 4:
                                pomocna[0] = Los.Next(1, (int)ulozeni[1] + 1);
                                pomocna[1] = Los.Next(1, pomocna[0] + 1);
                                odcitani();
                                break;
                        }
                        priklady[y, 0] = pomocna[0];
                        priklady[y, 1] = pomocna[1];
                        z = 0;
                    }
                    else
                    {
                        z++;
                    }
                }
                numera[y].Value = 0;
                lecol[y].Text = priklady[y, 0].ToString();
                ricol[y].Text = priklady[y, 1].ToString();

                switch (s)
                {
                    case 1:
                        zncol[y].Text = "*";
                        priklady[y, 2] = priklady[y, 0] * priklady[y, 1];
                        break;
                    case 2:
                        zncol[y].Text = "+";
                        priklady[y, 2] = priklady[y, 0] + priklady[y, 1];
                        break;
                    case 3:
                        zncol[y].Text = "/";
                        priklady[y, 2] = priklady[y, 0] / priklady[y, 1];
                        break;
                    case 4:
                        zncol[y].Text = "-";
                        priklady[y, 2] = priklady[y, 0] - priklady[y, 1];
                        break;
                }
                z = 0;

            }

            y = 1;
        }

        private void Tick(object sender, EventArgs e)
        {
          if (cas > 0)
          {                     
              cas--;
              TimeLabel.Text = cas + " " + sekund;
              time_status.Text = cas + " " + sekund;
          }
          else
          {
              odpocitavani.Stop();
              if (sound.Checked)
              {
                  badend.Play();
              }
              TimeLabel.Text = preklad[139] + " !!";
              time_status.Text = preklad[139] + " !!";
              last_time_num.Text = preklad[140] + " !!";
              vyhodnoceni();
          }
        }

        private void vyhodnoceni()
        {
            for (int i = 0; i < ulozeni[4]; i++)
            {
                if (numera[i].Value == priklady[i,2])
                {
                    statistiky[0] += 1;                  // kontrola good

                    if (numera[i].Visible == false)
                    {
                        statistiky[0] -= 1;              // kontrola good
                    }
                }
                else  if (numera[i].Value != priklady[i, 2])
                {
                    if (numera[i].Value == 0)
                    {
                        statistiky[1] += 1;              // nevyplneno 
                        statistiky[2] -= 1;              // vyplneno
                        statistiky[3] += 1;              // kontrola bad
                    }
                    else
                    {
                        statistiky[3] += 1;              // kontrola bad
                    }
                }
            }

            if (statistiky[3] == 0)
            {
                if (sound.Checked)
                {
                    goodend.Play();
                }
            }

            statistiky[5] = (statistiky[2] / (float)exercise.Value) * 100;
            if (statistiky[2] != 0)
            {
                statistiky[4] = (statistiky[0] / statistiky[2]) * 100;
            }
            else
            {
                statistiky[4] = 0;
            }
            statistiky[7] = (statistiky[0] / (float)exercise.Value) * 100;
            last_time_num.Text = preklad[172];
            if ((statistiky[7] <= 100) && (statistiky[7] >= 90))
            {
                statistiky[6] = 1;
                last_time_num.Text += "1 ";
            }
            else if ((statistiky[7] <= 89) && (statistiky[7] >= 74))
            {
                statistiky[6] = 2;
                last_time_num.Text += "2 ";
            }
            else if ((statistiky[7] <= 73) && (statistiky[7] >= 62))
            {
                statistiky[6] = 3;
                last_time_num.Text += "3 ";
            }
            else if ((statistiky[7] <= 61) && (statistiky[7] >= 45))
            {
                statistiky[6] = 4;
                last_time_num.Text += "4 ";
            }
            else
            {
                statistiky[6] = 5;
                last_time_num.Text += "5 ";
                if (sound.Checked)
                {
                    badend.Play();
                }
            }
            last_time_num.Text += preklad[173] + (ulozeni[5] - cas) + " " + sekund;

            if ((cas == 0) && (statistiky[4] == 100))
            {
                statistika = preklad[174] + preklad[175] + ulozeni[5].ToString() + " " + sekund + ")";
                zapis = ulozeni[5].ToString() + " " + sekund + " -> " + preklad[176];
            }
            else if (cas != 0)
            {
                statistika = preklad[177] + (ulozeni[5] - cas) + " " + sekund + " " + preklad[202] + " " + ulozeni[5].ToString() + " " + sekund;
                zapis = (ulozeni[5] - cas) + " " + sekund + " " + preklad[202] + " " + ulozeni[5].ToString() + " " + sekund;
            }
            else
            {
                statistika = preklad[178] + " !!";
                zapis = preklad[178] + " !!" + preklad[175] + ulozeni[5].ToString() + " " + sekund + ")";
            }

            for (int y = 0; y <= 19; y++)
            {
                if (numera[y].Value == priklady[y, 2])
                {
                    numera[y].ForeColor = System.Drawing.Color.Black;
                    numera[y].BackColor = System.Drawing.Color.Lime;
                }
                else
                {
                    numera[y].ForeColor = System.Drawing.Color.White;
                    numera[y].BackColor = System.Drawing.Color.Red;
                }
            }

            zapis += "<" + preklad[179] + statistiky[1] + preklad[180] + "<" + preklad[181] + statistiky[2] + preklad[180] + ".<" +
               preklad[182] + statistiky[0] + preklad[180] + ".<" + preklad[183] + statistiky[3] + preklad[180] + ".<" +
               preklad[181] + statistiky[5] + "%" + preklad[184] + ".<" + preklad[185] + statistiky[4] + "% (" + statistiky[7] + "%" + preklad[184] + ").<" + preklad[186] + statistiky[6];

            statistika += "\n\n" + preklad[187] + statistiky[1] + preklad[180] + ".\n\n" + preklad[188] + statistiky[2] + preklad[180] + ".\n\n" +
                         preklad[189] + statistiky[0] + preklad[180] + ".\n\n" + preklad[190] + statistiky[3] + preklad[180] + ".\n\n" +
                         preklad[191] + statistiky[5] + "%" + preklad[184] + ".\n\n" + preklad[192] + statistiky[4] + "% (" + statistiky[7] + "%" + preklad[184] + "). \n\n" + preklad[186] + statistiky[6];

            oznam result = new oznam();
            result.Size = new System.Drawing.Size(result.Size.Width + 50, 660);
            result.nadpis.Text = preklad[193];
            result.text.Text = statistika;
            result.ShowDialog();

            zapis += "<" + preklad[194] + typ_test + "---";
            switch (typ_test)
            {
                case "Odčítání":
                    zapis += preklad[195] + ": " + ulozeni[1].ToString();
                    break;
                case "Sčítání":
                    zapis += preklad[195] + ": " + ulozeni[0].ToString();
                    break;
                case "Násobení":
                    zapis += preklad[195] + ": " + ulozeni[2].ToString();
                    break;
                case "Dělení":
                    zapis += preklad[195] + ": " + ulozeni[3].ToString();
                    break;
                case "Všechny početní operace":
                    zapis += preklad[195] + preklad[196] + ": " + ulozeni[0].ToString();
                    zapis += "---" + preklad[195] + preklad[197] + ": " + ulozeni[1].ToString();
                    zapis += "---" + preklad[195] + preklad[198] + ": " + ulozeni[2].ToString();
                    zapis += "---" + preklad[195] + preklad[199] + ": " + ulozeni[3].ToString();
                    break;
            }
            StartButton.Enabled = nas.Enabled = true;
            del.Enabled = sc.Enabled = true;
            od.Enabled = showset.Enabled = vse.Enabled = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hotkeys);
            for (int i = 0; i <= 19; i++)
            {
                sprvcol[i].Text = priklady[i, 2].ToString();
            }
            close.Enabled = showtest.Enabled = true;
            StartButton.Visible = showuser.Enabled = true;
            endbutton.Visible = false;

            if (User_name.Text != preklad[43])
            {
                otazka quest = new otazka();
                quest.nadpis.Text = preklad[200];
                quest.text.Text = preklad[201];
                quest.Size = new System.Drawing.Size(476, 205);
                quest.accept.Text = preklad[152];
                quest.cancel.Text = preklad[151];
                quest.ShowDialog();
                if (quest.DialogResult == DialogResult.Yes)
                {
                    zapis_test(zapis);
//                    using (FileStream results = new FileStream(Environment.CurrentDirectory + @"\Data\Users\" + this.User_name.Text + "\\Vys_" +
  //                      DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month + "_" + DateTime.Today.Year + ".doc", FileMode.Create, FileAccess.Write))
    //                {
      //                  results.Close();
        //            }
          //          using (StreamWriter vysledek = new StreamWriter(Environment.CurrentDirectory + @"\Data\Users\" + this.User_name.Text + "\\Vys_" +
            //            DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month + "_" + DateTime.Today.Year + ".doc", true, Encoding.Default))
              //      {
                //        vysledek.WriteLine("\n\n\n\n---------" + DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString() + "---------");
                  //      vysledek.Write(statistika);
                    //    vysledek.Close();
                    //}
                }
                vypis_vysledky();
            }

        }

        private void zapis_test(string statistik)
        {
            string[] datum = new string[6];
            if (DateTime.Now.Month.ToString().Length == 1)
                datum[1] = "0" + DateTime.Now.Month.ToString();
            else
                datum[1] = DateTime.Now.Month.ToString();

            if (DateTime.Now.Day.ToString().Length == 1)
                datum[2] = "0" + DateTime.Now.Day.ToString();
            else
                datum[2] = DateTime.Now.Day.ToString();

            if (DateTime.Now.Hour.ToString().Length == 1)
                datum[3] = "0" + DateTime.Now.Hour.ToString();
            else
                datum[3] = DateTime.Now.Hour.ToString();

            if (DateTime.Now.Minute.ToString().Length == 1)
                datum[4] = "0" + DateTime.Now.Minute.ToString();
            else
                datum[4] = DateTime.Now.Minute.ToString();

            if (DateTime.Now.Second.ToString().Length == 1)
                datum[5] = "0" + DateTime.Now.Second.ToString();
            else
                datum[5] = DateTime.Now.Second.ToString();

            using (FileStream pass = new FileStream(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Results\\" + DateTime.Now.Year.ToString() + "." +
                datum[1] + "." + datum[2] + "." + datum[3] + "." + datum[4] + "." + datum[5] + ".txt", 
                FileMode.Create, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(pass, Encoding.Default))
            {
                foreach (Label cislo in ricol)
                {
                    sw.Write(cislo.Text + "<");
                }

                foreach (Label cislo in lecol)
                {
                    sw.Write(cislo.Text + "<");
                }

                foreach (Label cislo in sprvcol)
                {
                    sw.Write(cislo.Text + "<");
                }

                foreach (Label cislo in zncol)
                {
                    sw.Write(cislo.Text + "<");
                }

                foreach (NumericUpDown vysledek in numera)
                {
                    sw.Write(vysledek.Value + "<");
                }

                sw.Write("///");

                foreach (NumericUpDown vysledek in numera)
                {
                    sw.Write(vysledek.BackColor.A.ToString() + "<" + vysledek.BackColor.R.ToString() + "<" + vysledek.BackColor.G.ToString() + "<" + vysledek.BackColor.B.ToString() + ">");
                }

                sw.Write("///" + statistik);
            }
        }

        private void valuechanged(object sender, EventArgs e)
        {            
            if (spravny_vys.Checked)
            {
                for (int y = 0; y <= 19; y++)
                {
                    if (numera[y].Value == priklady[y, 2])
                    {
                        numera[y].ForeColor = System.Drawing.Color.Black;
                        numera[y].BackColor = System.Drawing.Color.Lime;
                    }
                    else
                    {
                        numera[y].ForeColor = System.Drawing.Color.White;
                        numera[y].BackColor = System.Drawing.Color.Red;
                    }
                }
            }
        }

        public void delitelnost()
        {
            while ((pomocna[0] / pomocna[1] == 1) || (pomocna[0] % pomocna[1] != 0) || (pomocna[1] == 1))
            {
                pomocna[0] = Los.Next(1, (int)ulozeni[3] + 1);
                pomocna[1] = Los.Next(1, pomocna[0] + 1);
            }
        }

        public void odcitani()
        {
            while (pomocna[0] - pomocna[1] <= 0)
            {
                pomocna[0] = Los.Next(1, (int)ulozeni[1] + 1);
                pomocna[1] = Los.Next(1, pomocna[0] + 1);
            }
        }

        private void zobraz_vysledek(object sender, EventArgs e)
        {
            result res = new result();
            string[] datum;
            if (vysledek_dat.SelectedIndex != -1)
            {
                datum = vysledek_dat.SelectedItem.ToString().Split('.');
            }
            else
            {
                datum = vysledek_dat.Items[vysledek_dat.Items.Count - 1].ToString().Split('.');
            }
            if (datum[4].Length == 1)
                datum[4] = "0" + datum[4];
            res.Title.Text += datum[2] + ". " + datum[1] + ". " + datum[0] + " Čas: " + datum[3] + ":" + datum[4] + " a " + datum[5] + " " + sekund; 
            numera_res.Clear();
            lecol_res.Clear();
            ricol_res.Clear();
            sprvcol_res.Clear();
            zncol_res.Clear();
            loadzn(res);
            loadri(res);
            loadsprv(res);
            loadle(res);
            loadlist(res);
            string[] data = separace();
            string[] hodnoty = Regex.Split(data[0], "<");

            int projdi = 0;
            for(int ip = 0; ip < hodnoty.Length; ip++)
            {
                if (ip <= 19)
                {
                    ricol_res[projdi].Text = hodnoty[ip];
                    projdi++;
                    if (projdi == 20)
                        projdi = 0;
                }
                else if (ip <= 39)
                {
                    lecol_res[projdi].Text = hodnoty[ip];
                    projdi++;
                    if (projdi == 20)
                        projdi = 0;
                }
                else if (ip <= 59)
                {
                    sprvcol_res[projdi].Text = hodnoty[ip];
                    projdi++;
                    if (projdi == 20)
                        projdi = 0;
                }
                else if (ip <= 79)
                {
                    zncol_res[projdi].Text = hodnoty[ip];
                    projdi++;
                    if (projdi == 20)
                        projdi = 0;
                }
                else
                {
                    numera_res[projdi].Text = hodnoty[ip];
                    projdi++;
                    if (projdi == 20)
                        projdi = 0;
                    numera_res[0].Text = hodnoty[80];
                }
            }

            projdi = 0;
            string[] barvy = Regex.Split(data[1], ">");
            foreach (string str in barvy)
            {
                if (projdi < barvy.Length - 1)
                {
                    string[] barva = Regex.Split(str, "<");
                    numera_res[projdi].BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(barva[0]), Convert.ToInt32(barva[1]), Convert.ToInt32(barva[2]), Convert.ToInt32(barva[3]));
                    projdi++;
                }
            }

            string[] informace = Regex.Split(data[2], "<");
            res.TimeLabel.Text = informace[0];
            res.lab1.Text = informace[1];
            res.lab2.Text = informace[2];
            res.lab3.Text = informace[3];
            res.lab4.Text = informace[4];
            res.lab5.Text = informace[5];
            res.lab6.Text = informace[6];
            res.lab7.Text = informace[7];
            string[] parametry = Regex.Split(informace[8], "---");
            if (parametry.Length == 2)
            {
                res.para_label.Text = parametry[0] + "\n" + parametry[1];
            }
            else
            {
                res.para_label.Text = parametry[0] + "\n" + parametry[1] + "\n" + parametry[2] + "\n" + parametry[3] + "\n" + parametry[4];
            }
            res.ShowDialog();
        }

        #region load_res

        private string[] separace()
        {
            StreamReader stream;
            if (vysledek_dat.SelectedIndex != -1)
            {
                stream = new StreamReader(Environment.CurrentDirectory + @"\Data\Users\" + User_name.Text + @"\Results\" + vysledek_dat.SelectedItem.ToString() + ".txt", Encoding.Default);    
            }
            else
            {
                stream = new StreamReader(Environment.CurrentDirectory + @"\Data\Users\" + User_name.Text + @"\Results\" + vysledek_dat.Items[vysledek_dat.Items.Count - 1].ToString() + ".txt", Encoding.Default);
            }
            string[] data = Regex.Split(stream.ReadToEnd(), "///");
            return data;                
        }

        public void loadle(result res)
        {
            lecol_res.Add(res.le1);
            lecol_res.Add(res.le2);
            lecol_res.Add(res.le3);
            lecol_res.Add(res.le4);
            lecol_res.Add(res.le5);
            lecol_res.Add(res.le6);
            lecol_res.Add(res.le7);
            lecol_res.Add(res.le8);
            lecol_res.Add(res.le9);
            lecol_res.Add(res.le10);
            lecol_res.Add(res.le11);
            lecol_res.Add(res.le12);
            lecol_res.Add(res.le13);
            lecol_res.Add(res.le15);
            lecol_res.Add(res.le14);
            lecol_res.Add(res.le16);
            lecol_res.Add(res.le17);
            lecol_res.Add(res.le18);
            lecol_res.Add(res.le19);
            lecol_res.Add(res.le20);
        }

        public void loadlist(result res)
        {
            numera_res.Add(res.prod1);
            numera_res.Add(res.prod2);
            numera_res.Add(res.prod3);
            numera_res.Add(res.prod4);
            numera_res.Add(res.prod5);
            numera_res.Add(res.prod6);
            numera_res.Add(res.prod7);
            numera_res.Add(res.prod8);
            numera_res.Add(res.prod9);
            numera_res.Add(res.prod10);
            numera_res.Add(res.prod11);
            numera_res.Add(res.prod12);
            numera_res.Add(res.prod13);
            numera_res.Add(res.prod15);
            numera_res.Add(res.prod14);
            numera_res.Add(res.prod16);
            numera_res.Add(res.prod17);
            numera_res.Add(res.prod18);
            numera_res.Add(res.prod19);
            numera_res.Add(res.prod20);
        }

        public void loadsprv(result res)
        {
            sprvcol_res.Add(res.sprv1);
            sprvcol_res.Add(res.sprv2);
            sprvcol_res.Add(res.sprv3);
            sprvcol_res.Add(res.sprv4);
            sprvcol_res.Add(res.sprv5);
            sprvcol_res.Add(res.sprv6);
            sprvcol_res.Add(res.sprv7);
            sprvcol_res.Add(res.sprv8);
            sprvcol_res.Add(res.sprv9);
            sprvcol_res.Add(res.sprv10);
            sprvcol_res.Add(res.sprv11);
            sprvcol_res.Add(res.sprv12);
            sprvcol_res.Add(res.sprv13);
            sprvcol_res.Add(res.sprv15);
            sprvcol_res.Add(res.sprv14);
            sprvcol_res.Add(res.sprv16);
            sprvcol_res.Add(res.sprv17);
            sprvcol_res.Add(res.sprv18);
            sprvcol_res.Add(res.sprv19);
            sprvcol_res.Add(res.sprv20);
        }

        private void loadri(result res)
        {
            ricol_res.Add(res.ri1);
            ricol_res.Add(res.ri2);
            ricol_res.Add(res.ri3);
            ricol_res.Add(res.ri4);
            ricol_res.Add(res.ri5);
            ricol_res.Add(res.ri6);
            ricol_res.Add(res.ri7);
            ricol_res.Add(res.ri8);
            ricol_res.Add(res.ri9);
            ricol_res.Add(res.ri10);
            ricol_res.Add(res.ri11);
            ricol_res.Add(res.ri12);
            ricol_res.Add(res.ri13);
            ricol_res.Add(res.ri15);
            ricol_res.Add(res.ri14);
            ricol_res.Add(res.ri16);
            ricol_res.Add(res.ri17);
            ricol_res.Add(res.ri18);
            ricol_res.Add(res.ri19);
            ricol_res.Add(res.ri20);
        }

        private void loadzn(result res)
        {
            zncol_res.Add(res.zn1);
            zncol_res.Add(res.zn2);
            zncol_res.Add(res.zn3);
            zncol_res.Add(res.zn4);
            zncol_res.Add(res.zn5);
            zncol_res.Add(res.zn6);
            zncol_res.Add(res.zn7);
            zncol_res.Add(res.zn8);
            zncol_res.Add(res.zn9);
            zncol_res.Add(res.zn10);
            zncol_res.Add(res.zn11);
            zncol_res.Add(res.zn12);
            zncol_res.Add(res.zn13);
            zncol_res.Add(res.zn15);
            zncol_res.Add(res.zn14);
            zncol_res.Add(res.zn16);
            zncol_res.Add(res.zn17);
            zncol_res.Add(res.zn18);
            zncol_res.Add(res.zn19);
            zncol_res.Add(res.zn20);
        }

        #endregion

        #endregion
        
        #region saving

        private void value_zmena(object sender, EventArgs e)
        {
            if (last_time.Checked)
            {
                last_time_label.Visible = last_time_num.Visible = true;
            }
            else
            {
                last_time_label.Visible = last_time_num.Visible = false;
            }
            save.Visible = true;
            save_close.Visible = true;
            unsave.Text = preklad[32];
            unsave.Location = new Point(621, 510);
            load_user_set.Enabled = true;
            save_user_set.Enabled = true;
        }

        private void set_okno(object sender, EventArgs e)
        {
            nastav.cancel.Text = preklad[99];
            nastav.Size = new Size(450, 235);
            nastav.kolekce.Visible = false;
            nastav.set.Visible = false;
            Button prvek = sender as Button;
            switch (prvek.Name)
            {
                case "plus":
                    nastav.Title.Text = preklad[80] + preklad[84];
                    nastav.typ.Text = label14.Text;
                    nastav.set.Maximum = this.scitanec.Maximum;
                    nastav.set.Value = this.scitanec.Value;
                    nastav.set.Focus();
                    nastav.set.Visible = true;
                    nastav.use.Text = preklad[81];
                    break;

                case "minus":
                    nastav.Title.Text = preklad[80] + preklad[87];
                    nastav.typ.Text = label15.Text;
                    nastav.set.Maximum = this.mensenec.Maximum;
                    nastav.set.Value = this.mensenec.Value;
                    nastav.set.Focus();
                    nastav.set.Visible = true;
                    nastav.use.Text = preklad[81];
                    break;

                case "deleno":
                    nastav.Title.Text = preklad[80] + preklad[86];
                    nastav.typ.Text = label12.Text;
                    nastav.set.Maximum = this.delenec.Maximum;
                    nastav.set.Value = this.delenec.Value;
                    nastav.set.Focus();
                    nastav.set.Visible = true;
                    nastav.use.Text = preklad[81];
                    break;

                case "krat":
                    nastav.Title.Text = preklad[80] + preklad[85];
                    nastav.typ.Text = label11.Text;
                    nastav.set.Maximum = this.soucinitel.Maximum;
                    nastav.set.Value = this.soucinitel.Value;
                    nastav.set.Focus();
                    nastav.set.Visible = true;
                    nastav.use.Text = preklad[81];
                    break;

                case "odpocet":
                    nastav.Title.Text = preklad[80] + preklad[88];
                    nastav.typ.Text = label17.Text;
                    nastav.set.Maximum = this.time.Maximum;
                    nastav.set.Value = this.time.Value;
                    nastav.set.Focus();
                    nastav.set.Visible = true;
                    nastav.use.Text = preklad[81];
                    break;

                case "pocet_pr":
                    nastav.Title.Text = preklad[80] + preklad[89];
                    nastav.typ.Text = label18.Text;
                    nastav.set.Maximum = this.exercise.Maximum;
                    nastav.set.Value = this.exercise.Value;
                    nastav.set.Focus();
                    nastav.set.Visible = true;
                    nastav.use.Text = preklad[81];
                    break;

                case "language":
                    nastav.Title.Text = preklad[80] + label19.Text;
                    nastav.typ.Text = preklad[83] + " " + label19.Text;
                    nastav.set.Visible = false;
                    nastav.kolekce.Visible = true;
                    nastav.kolekce.Items.Clear();
                    for (i = 0; i < languages.Items.Count; i++)
                    {
                        nastav.kolekce.Items.Add(languages.Items[i].Text);
                    }
                    nastav.Size = new System.Drawing.Size(nastav.Size.Width, nastav.Size.Height + 120);
                    nastav.kolekce.Focus();
                    nastav.use.Text = preklad[81];
                    break;

                case "user_list":
                    nastav.Title.Text = preklad[82] + " " + preklad[96];
                    nastav.typ.Text = preklad[83] + " " + preklad[96];
                    nastav.set.Visible = false;
                    nastav.kolekce.Visible = true;
                    vypis_users();
                    nastav.kolekce.Items.Clear();
                    foreach (object ob in uzivatele.Items)
                    {
                        nastav.kolekce.Items.Add(ob);
                    }
                    nastav.Size = new System.Drawing.Size(nastav.Size.Width, nastav.Size.Height + 120);
                    nastav.kolekce.Focus();
                    nastav.use.Text = Login_btn.Text;
                    break;
            }

            if (nastav.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    switch (prvek.Name)
                    {
                        case "plus":
                            scitanec.Value = nastav.set.Value;
                            saving();
                            break;

                        case "minus":
                            mensenec.Value = nastav.set.Value;
                            saving();
                            break;

                        case "deleno":
                            delenec.Value = nastav.set.Value;
                            saving();
                            break;

                        case "krat":
                            soucinitel.Value = nastav.set.Value;
                            saving();
                            break;

                        case "odpocet":
                            time.Value = nastav.set.Value;
                            saving();
                            break;

                        case "language":
                            languages.FocusedItem = languages.Items[nastav.kolekce.SelectedIndex];
                            change_lang(sender, e);
                            nastav.kolekce.Items.Clear();
                            break;

                        case "pocet_pr":
                            exercise.Value = nastav.set.Value;
                            saving();
                            break;

                        case "user_list":
                            uzivatele.SelectedItem = nastav.kolekce.SelectedItem;
                            Login();
                            nastav.kolekce.Items.Clear();
                            break;
                    }
                }
                catch
                { }
                zobrazset();
            }
        }

        public void zobrazset() 
        {
            if (languages.FocusedItem != null)
            {
                nastavt.Text = preklad[90] + preklad[80] + "\n" +
                preklad[91] + ": max. " + preklad[84] + ": " + ulozeni[0] + "\n" +
                preklad[92] + ": max. " + preklad[87] + ": " + ulozeni[1] + "\n" +
                preklad[93] + ": max. " + preklad[85] + ": " + ulozeni[2] + "\n" +
                preklad[94] + ": max. " + preklad[86] + ": " + ulozeni[3] + "\n" +
                preklad[89] + ": " + ulozeni[4] + "\n" +
                preklad[88] + " " + preklad[95] + ": " + ulozeni[5] + " " + sekund + "\n" +
                preklad[97] + " " + label19.Text + " " + preklad[98] + " " + languages.FocusedItem.Text.ToString();
            }
            else
            {
                nastavt.Text = preklad[90] + preklad[80] + "\n" +
                preklad[91] + ": max. " + preklad[84] + ": " + ulozeni[0] + "\n" +
                preklad[92] + ": max. " + preklad[87] + ": " + ulozeni[1] + "\n" +
                preklad[93] + ": max. " + preklad[85] + ": " + ulozeni[2] + "\n" +
                preklad[94] + ": max. " + preklad[86] + ": " + ulozeni[3] + "\n" +
                preklad[89] + ": " + ulozeni[4] + "\n" +
                preklad[88] + " " + preklad[95] + ": " + ulozeni[5] + " " + sekund + "\n" +
                preklad[97] + " " + label19.Text + " " + preklad[98] + " čeština";
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            save_close.Visible = false;
            saving();
            zobrazset();
        }

        private void save_close_Click(object sender, EventArgs e)
        {
            save.Visible = false;
            save_close.Visible = false;
            testpanel.Visible = true;
            setpanel.Visible = false;
            saving();
            zobrazset();
        }

        private void unsave_Click(object sender, EventArgs e)
        {
            testpanel.Visible = true;
            setpanel.Visible = false;
        }

        private void check_zmena(object sender, EventArgs e)
        {
            if (sc.Checked)
            {
                zobrazeno();
                settings[0].Enabled = true;
                typ_test = preklad[91];
            }
            else if (od.Checked)
            {
                zobrazeno();
                settings[1].Enabled = true;
                typ_test = preklad[92];
            }
            else if (del.Checked)
            {
                zobrazeno();
                settings[3].Enabled = true;
                typ_test = preklad[93];
            }
            else if (nas.Checked)
            {
                zobrazeno();
                settings[2].Enabled = true;
                typ_test = preklad[94];
            }
            else
            {
                zobrazeno();
                settings[0].Enabled = true;
                settings[1].Enabled = true;
                settings[2].Enabled = true;
                settings[3].Enabled = true;
                typ_test = preklad[138];
            }
        }

        private void zobrazeno()
        {
            settings[0].Enabled = false;
            settings[1].Enabled = false;
            settings[2].Enabled = false;
            settings[3].Enabled = false;
        }

        public List<NumericUpDown> loadset()
        {
            settings.Add(scitanec);
            settings.Add(mensenec);
            settings.Add(soucinitel);
            settings.Add(delenec);
            return settings;
        }

        public void saving()
        {
            unsave.Text = preklad[52];
            unsave.Location = new Point(413, 510);
            ulozeni[0] = scitanec.Value;
            ulozeni[1] = mensenec.Value;
            ulozeni[2] = soucinitel.Value;
            ulozeni[3] = delenec.Value;
            ulozeni[5] = time.Value;
            Wait wait = new Wait();
            wait.Title.Text = preklad[112];
            wait.label1.Text = preklad[113];
            wait.Show();
            if (ulozeni[4] != exercise.Value)
            {
                i = 0;
                for ( i = 0; i < 20; i++)
                {
                    ricol[i].Visible = true;
                    lecol[i].Visible = true;
                    sprvcol[i].Visible = true;
                    rovncol[i].Visible = true;
                    zncol[i].Visible = true;
                    numera[i].Visible = true;
                    if (i == 10)
                        label25.Visible = true;
                }
                ulozeni[4] = exercise.Value;
                for ( i = 0; ulozeni[4] < 20; ulozeni[4]++)
                {
                    ricol[(int)ulozeni[4]].Visible = false;
                    lecol[(int)ulozeni[4]].Visible = false;
                    sprvcol[(int)ulozeni[4]].Visible = false;
                    rovncol[(int)ulozeni[4]].Visible = false;
                    zncol[(int)ulozeni[4]].Visible = false;
                    numera[(int)ulozeni[4]].Visible = false; 
                    
                    ricol[(int)ulozeni[4]].Text = "0";
                    lecol[(int)ulozeni[4]].Text = "0";
                    sprvcol[(int)ulozeni[4]].Text = "0";
                    rovncol[(int)ulozeni[4]].Text = "0";
                    zncol[(int)ulozeni[4]].Text = "¤";
                    numera[(int)ulozeni[4]].Value = 0;
                    if (ulozeni[4] == 10)
                        label25.Visible = false;
                }
                ulozeni[4] = exercise.Value;
            }
            wait.Close();
        }

        private void set_m_clr(object sender, EventArgs e)
        {
            if (Open_clr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = Open_clr.Color;
            }

            if (User_name.Text == preklad[43])
            {
                oznam ozn = new oznam();
                ozn.Size = new System.Drawing.Size(ozn.Size.Width, 250);
                ozn.text.Text = preklad[136];
                ozn.nadpis.Text = preklad[137];
                ozn.ShowDialog();
            }
            else
            {
                using (StreamWriter write = new StreamWriter(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Color_menu.txt"))
                {
                    write.Write(Open_clr.Color.A.ToString() + "<" + Open_clr.Color.R.ToString() + "<" + Open_clr.Color.G.ToString() + "<" + Open_clr.Color.B.ToString());
                    write.Close();
                }
            }
        }

        private void set_prg_jpg(object sender, EventArgs e)
        {
            if (Open_jpg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Image im = Image.FromFile(Open_jpg.FileName))
                {
                    this.workspace.BackgroundImage = null;
                    Bitmap bm = new Bitmap(im);
                    workspace.BackgroundImage = bm;
                    setpanel.Visible = false;
                }
            }

            if (User_name.Text == preklad[43])
            {
                oznam ozn = new oznam();
                ozn.Size = new System.Drawing.Size(ozn.Size.Width, 250);
                ozn.text.Text = preklad[136];
                ozn.nadpis.Text = preklad[137];
                ozn.ShowDialog();
            }
            else
            {
                using (StreamWriter write = new StreamWriter(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Color_program.txt"))
                {
                    write.Write("tapeta");
                    write.Close();
                }
            
                try
                {
                    if (File.Exists(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\pozadi.jpg"))
                        File.Delete(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\pozadi.jpg");
                    if (Open_jpg.FileName != "Obrázek na pozadí programu")
                        File.Copy(Open_jpg.FileName, Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\pozadi.jpg");
                                   
                }
                catch (InvalidExpressionException k)
                {
                    oznam ozn = new oznam();
                    ozn.Title.Text = preklad[116];
                    ozn.nadpis.Text = preklad[135];
                    ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                    ozn.text.Text = k.ToString();
                    ozn.Size = new System.Drawing.Size(495, 482);
                    ozn.ShowDialog();
                }
            }
        }

        private void set_prg_clr(object sender, EventArgs e)
        {
            if (Open_clr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.workspace.BackColor = Open_clr.Color;
                this.workspace.BackgroundImage = null;
            }

            if (User_name.Text == preklad[43])
            {
                oznam ozn = new oznam();
                ozn.Size = new System.Drawing.Size(ozn.Size.Width, 250);
                ozn.text.Text = preklad[136];
                ozn.nadpis.Text = preklad[137];
                ozn.ShowDialog();
            }
            else  // int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            {
                using (StreamWriter write = new StreamWriter(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Color_program.txt"))
                {
                    write.Write(Open_clr.Color.A.ToString() + "<" + Open_clr.Color.R.ToString() + "<" + Open_clr.Color.G.ToString() + "<" + Open_clr.Color.B.ToString());
                    write.Close();
                }
            }
        }
        
        #endregion

        #region Users

        private void new_user(object sender, EventArgs e)
        {
            if (User_name.Text != preklad[43])
            {
                otazka quest = new otazka();
                quest.nadpis.Text = preklad[119];
                quest.text.Text = preklad[120];
                quest.cancel.Text = preklad[151];
                quest.accept.Text = preklad[152];
                quest.Size = new Size(quest.Size.Width, 200);
                if (quest.ShowDialog() == DialogResult.Yes)
                {
                    create_user();
                    save_set(sender, e);
                }
            }
            else
            {
                create_user();
                save_set(sender, e);
            }
        }

        public void create_user()
        {
            Registruj registr = new Registruj();
            registr.Title.Text = preklad[110];
            registr.label1.Text = preklad[102];
            registr.label2.Text = preklad[103];
            registr.label3.Text = preklad[103] + preklad[109];
            registr.cancel.Text = preklad[99];
            registr.label4.Text = preklad[168];
            registr.label5.Text = preklad[166];
            registr.label6.Text = preklad[167];
            registr.register.Text = preklad[111];
            registr.ShowDialog(this);
            if (registr.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = Color.Black;
                this.workspace.BackColor = Color.FromArgb(29, 29, 29);
                if (this.workspace.BackgroundImage != null)
                    this.workspace.BackgroundImage = null;
                regnise[0] = registr.User_Name.Text.ToString();
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0]);
                this.User_name.Text = regnise[0];
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\Data\Users\" + User_name.Text + "\\Results");
                regnise[1] = registr.Pass.Text.ToString();
                try
                {
                    using (FileStream pass = new FileStream(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\password.dta", FileMode.Create, FileAccess.Write))
                    using (StreamWriter wpass = new StreamWriter(pass, Encoding.Default))
                    {
                        wpass.WriteLine(regnise[1]);
                        FileAttributes fatr = FileAttributes.Hidden;
                        File.SetAttributes(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\password.dta", fatr);
                        wpass.Close();
                    }
                    using (FileStream setup = new FileStream(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\Nastaveni.txt", FileMode.Create, FileAccess.Write))
                    using (FileStream clr_menu = new FileStream(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\Color_menu.txt", FileMode.Create, FileAccess.Write))
                    using (FileStream clr_prg = new FileStream(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\Color_program.txt", FileMode.Create, FileAccess.Write))
                    {
                        oznam ozn = new oznam();
                        ozn.nadpis.Text = preklad[114];
                        ozn.text.Text = preklad[115];
                        ozn.Size = new System.Drawing.Size(ozn.Size.Width, 180);                        
                        ozn.ShowDialog();
                    }
                    changepass.Enabled = true;
                    Logout.Enabled = true;
                    deleteusers.Enabled = true;
                    save_user_set.Enabled = true;
                    load_user_set.Enabled = true;
                    Login_btn.Enabled = true;
                    show_result.Enabled = true;
                    vysledek_dat.Enabled = true;
                }

                catch
                {
                    oznam ozn = new oznam();
                    ozn.Title.Text = preklad[116];
                    ozn.text.Text = preklad[117];
                    ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                    ozn.nadpis.Text = preklad[118];
                    ozn.Size = new System.Drawing.Size(ozn.Size.Width, 180);
                    ozn.ShowDialog();
                }
            }
            vypis_users();
        }

        private void changepass_Click(object sender, EventArgs e)
        {
            if (User_name.Text != preklad[43])
            {
                Change_pass chp = new Change_pass();
                chp.label4.Text = this.User_name.Text;
                chp.Title.Text = preklad[39];
                chp.label1.Text = preklad[106] + preklad[107];
                chp.label2.Text = preklad[105] + preklad[107];
                chp.label3.Text = preklad[105] + preklad[107] + preklad[109];
                chp.change.Text = preklad[108];
                chp.cancel.Text = preklad[99];
                chp.label5.Text = preklad[166];
                chp.label6.Text = preklad[167];
                chp.label7.Text = preklad[164];
                chp.label8.Text = preklad[165];
                chp.label9.Text = preklad[159];
                chp.label10.Text = preklad[163];
                chp.label11.Text = preklad[162];
                chp.ShowDialog(this);
                if (chp.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    regnise[1] = chp.new_Pass1.Text.ToString();
                    FileAttributes fatr = FileAttributes.Normal;
                    File.SetAttributes(Environment.CurrentDirectory + @"\Data\Users\" + this.User_name.Text + "\\password.dta", fatr);
                    using (StreamWriter new_pass = new StreamWriter(Environment.CurrentDirectory + @"\Data\Users\" + this.User_name.Text + "\\password.dta", false, Encoding.Default))
                    {
                        new_pass.WriteLine(regnise[1]);
                        fatr = FileAttributes.Hidden;
                        File.SetAttributes(Environment.CurrentDirectory + @"\Data\Users\" + this.User_name.Text + "\\password.dta", fatr);
                        new_pass.Close();
                    }
                }
            }
        }

        private void Log_in_system(object sender, EventArgs e)
        {
            if (User_name.Text != preklad[43])
            {
                otazka quest = new otazka();
                quest.nadpis.Text = preklad[119];
                quest.text.Text = preklad[120];
                quest.cancel.Text = preklad[151];
                quest.accept.Text = preklad[152];
                quest.Size = new Size(quest.Size.Width, 200);
                if (quest.ShowDialog() == DialogResult.Yes)
                {
                    Login();
                }
            }
            else
            {
                Login();
            }
        }

        public void Login()
        {
            Login log = new Login();
            log.label1.Text = preklad[102];
            log.label2.Text = preklad[103];
            log.with_login.Text = preklad[35];
            log.without_login.Text = preklad[104];
            log.label3.Text = preklad[158];
            log.label4.Text = preklad[159];
            log.label5.Text = preklad[160];
            log.label6.Text = preklad[161];
            log.label7.Text = preklad[162];
            log.label8.Text = preklad[163];
            if (uzivatele.SelectedIndex != -1)
            {
                log.User_log.Text = uzivatele.SelectedItem.ToString();
            }
            log.ShowDialog(this);
            if (log.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                this.User_name.Text = log.User_log.Text;
                changepass.Enabled = true;
                Logout.Enabled = true;
                deleteusers.Enabled = true;
                save_user_set.Enabled = true;
                load_user_set.Visible = true;
                load_user_set.Enabled = true;
                save_user_set.Visible = true;
                show_result.Enabled = true;
                vysledek_dat.Enabled = true;

                if ((this.User_name.Text != preklad[43]) && (Title.Text != "loading"))
                {
                    otazka quest = new otazka();
                    quest.nadpis.Text = preklad[149];
                    quest.text.Text = preklad[150];
                    quest.cancel.Text = preklad[151];
                    quest.accept.Text = preklad[152];
                    quest.Size = new System.Drawing.Size(quest.Size.Width, 300);
                    quest.ShowDialog();

                    if (quest.DialogResult == DialogResult.Yes)
                    {
                        
                        using (StreamWriter write = new StreamWriter(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Color_menu.txt"))
                        {

                            write.Write(this.BackColor.A.ToString() + "<" + this.BackColor.R.ToString() + "<" + this.BackColor.G.ToString() + "<" + this.BackColor.B.ToString());
                            write.Close();
                        }                        

                        if (this.workspace.BackColor != null)
                        {
                            
                            using (StreamWriter write = new StreamWriter(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Color_program.txt"))
                            {

                                write.Write(workspace.BackColor.A.ToString() + "<" + workspace.BackColor.R.ToString() + "<" + workspace.BackColor.G.ToString() + "<" + workspace.BackColor.B.ToString());
                                write.Close();
                            }
                            
                        }

                        if (this.workspace.BackgroundImage != null)
                        {
                            try
                            {
                                if (File.Exists(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\pozadi.jpg"))
                                    File.Delete(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\pozadi.jpg");
                                if (Open_jpg.FileName != "Obrázek na pozadí programu")
                                    File.Copy(Open_jpg.FileName, Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\pozadi.jpg");
                            }
                            catch
                            { }


                            using (StreamWriter write = new StreamWriter(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Color_program.txt"))
                            {
                                write.Write("tapeta");
                                write.Close();
                            }
                        }
                    }
                }
                
                using (StreamReader read = new StreamReader(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Color_program.txt"))
                {
                    try
                    {
                        string[] barva = Regex.Split(read.ReadToEnd(), "<");
                        if (barva[0] == "tapeta")
                        {
                            try
                            {
                                using (Image im = Image.FromFile(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\pozadi.jpg"))
                                {
                                    Bitmap bm = new Bitmap(im);
                                    workspace.BackgroundImage = bm;
                                }
                            }
                            catch
                            { }
                        }
                        else
                        {
                            workspace.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(barva[0]), Convert.ToInt32(barva[1]), Convert.ToInt32(barva[2]), Convert.ToInt32(barva[3]));
                        }

                        read.Close();
                    }
                    catch { }
                } 
                
                using (StreamReader read = new StreamReader(Environment.CurrentDirectory + "\\Data\\Users\\" + User_name.Text + "\\Color_menu.txt"))
                {
                    try
                    {
                        string[] pokus = Regex.Split(read.ReadToEnd(), "<");
                        this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(pokus[0]), Convert.ToInt32(pokus[1]), Convert.ToInt32(pokus[2]), Convert.ToInt32(pokus[3]));
                        read.Close();
                    }
                    catch { }
                }
                vypis_vysledky();
            }
            else
            {
                this.User_name.Text = preklad[43];
                changepass.Enabled = false;
                Logout.Enabled = false;
                deleteusers.Enabled = false;
                save_user_set.Enabled = false;
                load_user_set.Enabled = false;
                load_user_set.Visible = false;
                save_user_set.Visible = false;
                show_result.Enabled = false;
                vysledek_dat.Enabled = false;
                vysledek_dat.Items.Clear();
            }

            Title.Text = preklad[0];         
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (User_name.Text != preklad[43])
            {
                this.User_name.Text = preklad[43];
                oznam ozn = new oznam();
                ozn.nadpis.Text = preklad[123];
                ozn.text.Text = preklad[124];
                ozn.Size = new System.Drawing.Size(475, 201);
                ozn.ShowDialog();
                changepass.Enabled = false;
                Logout.Enabled = false;
                deleteusers.Enabled = false;
                save_user_set.Enabled = false;
                load_user_set.Enabled = false;
                load_user_set.Visible = false;
                save_user_set.Visible = false;
                show_result.Enabled = false;
                vysledek_dat.Enabled = false;
                vysledek_dat.Items.Clear();
            }
        }

        private void vypis_users()
        {
            try
            {
                uzivatele.Items.Clear();
                DirectoryInfo users = new DirectoryInfo(Environment.CurrentDirectory + @"\Data\Users");
                DirectoryInfo[] uzivatel = users.GetDirectories();
                if (uzivatel.Length != 0)
                {
                    foreach (DirectoryInfo di in uzivatel)
                    {
                        uzivatele.Items.Add(di.Name);
                    }
                    uzivatele.Select();
                }
                if (uzivatele.Items.Count == 0)
                {
                    Login_btn.Enabled = false;
                }
            }
            catch
            {
                oznam ozn = new oznam();
                ozn.Title.Text = preklad[116];
                ozn.nadpis.Text = preklad[125];
                ozn.text.Text = preklad[126];
                ozn.Size = new System.Drawing.Size(ozn.Size.Width, 440);
                ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                ozn.ShowDialog();
            }
        }

        public void vypis_vysledky()
        {
            try
            {
                vysledek_dat.Items.Clear();
                DirectoryInfo vysledky = new DirectoryInfo(Environment.CurrentDirectory + @"\Data\Users\" + User_name.Text + "\\Results");
                FileInfo[] vysledek = vysledky.GetFiles();
                if (vysledek.Length != 0)
                {
                    foreach (FileInfo di in vysledek)
                    {
                        vysledek_dat.Items.Add(Path.GetFileNameWithoutExtension(di.Name));
                    }
                    vysledek_dat.Select();
                    show_result.Enabled = true;
                }
                if (vysledek_dat.Items.Count == 0)
                {
                    show_result.Enabled = false;
                }
                vysledek_dat.Sorted = true;
            }
            catch
            {
                oznam ozn = new oznam();
                ozn.Title.Text = preklad[116];
                ozn.nadpis.Text = preklad[125];
                ozn.text.Text = preklad[134];
                ozn.Size = new System.Drawing.Size(ozn.Size.Width, 460);
                ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
            }
        }

        private void Login_item(object sender, EventArgs e)
        {
            if (uzivatele.SelectedIndex != -1)
            {
                Login();
            }
        }

        private void deleteusers_Click(object sender, EventArgs e)
        {
            if (User_name.Text != preklad[43])
            {
                otazka quest = new otazka();
                quest.nadpis.Text = preklad[119];
                quest.text.Text = preklad[127];
                quest.cancel.Text = preklad[151];
                quest.accept.Text = preklad[152];
                quest.Size = new Size(quest.Size.Width, 250);
                if (quest.ShowDialog() == DialogResult.Yes)
                {
                    delete del = new delete();
                    del.User_log.Text = User_name.Text;
                    del.label1.Text = preklad[102];
                    del.label2.Text = preklad[103];
                    del.Title.Text = preklad[101];
                    del.cancel.Text = preklad[99];
                    del.label3.Text = preklad[169];
                    del.label4.Text = preklad[170];
                    del.label5.Text = preklad[171];
                    del.label6.Text = preklad[159];
                    del.label7.Text = preklad[160];
                    del.label8.Text = preklad[161];
                    del.label9.Text = preklad[162];
                    del.label10.Text = preklad[163];
                    del.delete_btn.Text = del.Title.Text;
                    del.ShowDialog(this);
                    regnise[0] = del.User_log.Text;
                    if (del.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        try
                        {
                            File.Delete(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\password.dta");
                            File.Delete(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\Statistiky.doc");
                            File.Delete(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\nastaveni.txt");
                            File.Delete(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\Color_menu.txt");
                            File.Delete(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\Color_program.txt");
                            File.Delete(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\pozadi.jpg");

                            DirectoryInfo dir = new DirectoryInfo(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\Results");
                            FileInfo[] soubory = dir.GetFiles();
                            foreach (FileInfo fil in dir.GetFiles("*.*"))
                            {
                                fil.Delete();
                            }

                            Directory.Delete(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0] + "\\Results");
                            Directory.Delete(Environment.CurrentDirectory + @"\Data\Users\" + regnise[0]);

                            oznam ozn = new oznam();
                            ozn.text.Text = preklad[128];
                            ozn.nadpis.Text = preklad[129];
                            ozn.Size = new System.Drawing.Size(ozn.Size.Width, 180);
                            ozn.ShowDialog();  
                            this.User_name.Text = preklad[43];  
                        }
                        catch
                        {
                            oznam ozn = new oznam();
                            ozn.text.Text = preklad[130];
                            ozn.nadpis.Text = preklad[131];
                            ozn.Title.Text = preklad[116];
                            ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                            ozn.Size = new System.Drawing.Size(ozn.Size.Width, 180);
                            ozn.ShowDialog();
                        }
                    }
                    deleteusers.Enabled = false;
                    Logout.Enabled = false;
                    changepass.Enabled = false;
                    show_result.Enabled = false;
                    show_result.Enabled = false;
                    vysledek_dat.Enabled = false;
                    vysledek_dat.Items.Clear();
                    vypis_users();
                }
            }
        }

        private void save_set(object sender, EventArgs e)
        {
            save_user_set.Enabled = false;
            if (User_name.Text != preklad[43])
            {
                using (StreamWriter nastaveni = new StreamWriter(Environment.CurrentDirectory + @"\Data\Users\" + User_name.Text + "\\nastaveni.txt", false, Encoding.Default))
                {
                    nastaveni.Write(ulozeni[2] + "<" + ulozeni[0] + "<" + ulozeni[3] + "<" + ulozeni[1] + "<" +
                        ulozeni[5] + "<" + ulozeni[4]);
                    nastaveni.Close();
                }
            }
        }

        private void load_set(object sender, EventArgs e)
        {
            string[] file_nastaveni = new string[7];
            load_user_set.Enabled = false;
            try
            {
                using (StreamReader nastaveni = new StreamReader(Environment.CurrentDirectory + @"\Data\Users\" + User_name.Text + "\\nastaveni.txt", Encoding.Default))
                {
                    file_nastaveni[6] = nastaveni.ReadLine();
                    file_nastaveni = file_nastaveni[6].Split('<');
                    soucinitel.Value = Convert.ToDecimal(file_nastaveni[0]);
                    scitanec.Value = Convert.ToDecimal(file_nastaveni[1]);
                    delenec.Value = Convert.ToDecimal(file_nastaveni[2]);
                    mensenec.Value = Convert.ToDecimal(file_nastaveni[3]);
                    time.Value = Convert.ToDecimal(file_nastaveni[4]);
                    exercise.Value = Convert.ToDecimal(file_nastaveni[5]);
                }
            }
            catch
            {
                oznam ozn = new oznam();
                ozn.text.Text = preklad[132];
                ozn.nadpis.Text = preklad[133];
                ozn.Title.Text = preklad[116];
                ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                ozn.Size = new System.Drawing.Size(ozn.Size.Width, 200);
                ozn.ShowDialog();
            }
        }

        #region languages

        public void jazyky()
        {
            languages.Clear();
            images.Images.Clear();
            vlajky();
            for (int i = 0; i < images.Images.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Text = vlajecky[i];
                languages.Items.Add(item);
            }
            foreach (ListViewItem it in languages.Items)
            {
                it.Font = new Font("Expo", 15);
                it.ForeColor = System.Drawing.Color.White;                
            }
        }

        public void vlajky()
        {
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory + "\\Data\\Languages");
            int i = 0;

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Extension.ToUpper() != ".TXT")
                {
                    images.Images.Add(Image.FromFile(file.FullName));
                    System.Array.Resize(ref vlajecky, vlajecky.Length + 1);
                    vlajecky[i] = Path.GetFileNameWithoutExtension(file.FullName);
                    i++;
                }
            }
            languages.View = View.LargeIcon;
            images.ImageSize = new Size(45, 45);
            languages.LargeImageList = images;
        }

        public void change_lang(object sender, EventArgs e)
        {
            int i = 0;
            bool logged = true;
            if ((preklad.Length != 1) && (User_name.Text == preklad[43]))
                logged = false;
            preklad = jazyk();
            if (preklad != null)
            {
                sekund = preklad[76];
                for (i = 0; i < lang_pack_str.Count; i++)
                {
                    switch (lang_pack_str[i].GetType().ToString())
                    {
                        case "System.Windows.Forms.Button":
                            Button but = lang_pack_str[i] as Button;
                            if ((but.Text != "") && (but.Name != "unsave"))
                            {
                                but.Text = preklad[i];
                            }
                            else if (but.Name == "unsave")
                            {
                                but.Text = preklad[41];
                            }
                            break;

                        case "System.Windows.Forms.RadioButton":
                            RadioButton rabut = lang_pack_str[i] as RadioButton;
                            rabut.Text = preklad[i];
                            break;

                        case "System.Windows.Forms.Label":
                            Label lab = lang_pack_str[i] as Label;
                            lab.Text = preklad[i];
                            if (i == 10)
                                label25.Text = preklad[i];
                            break;

                        case "System.Windows.Forms.CheckBox":
                            CheckBox check = lang_pack_str[i] as CheckBox;
                            check.Text = preklad[i];
                            break;

                        case "System.Windows.Forms.ToolStripStatusLabel":
                            ToolStripStatusLabel toolko = lang_pack_str[i] as ToolStripStatusLabel;
                            if ((toolko.Name == "User_name") && (logged == false))
                            {
                                toolko.Text = preklad[i];
                            }
                            else
                            {
                                if (toolko.Name != "User_name")
                                toolko.Text = preklad[i];
                            }
                            break;

                        case "System.Windows.Forms.ToolStripMenuItem":
                            ToolStripMenuItem cms = lang_pack_str[i] as ToolStripMenuItem;
                            cms.Text = preklad[i];
                            break;
                    }
                }
                zobrazset();
                int j = 0;
                foreach (string s in preklad)
                {
                    preklad[j] = s.Replace("\\n", "\n");
                    j++;
                }
            }
            else
            {
                oznam ozn = new oznam();
                ozn.Title.Text = "Error - chyba";
                ozn.text.Text = "Program hasn´t got translate pack.\nProgram will be close.\nProgram nemá balíček pro překlad.\nProgram bude ukončen.";
                ozn.nadpis.Text = "Translate lost - chybí překlad";
                ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                ozn.Size = new System.Drawing.Size(ozn.Size.Width, 250);
                ozn.ShowDialog();
                this.Close();
            }
        }

        public string[] jazyk()
        {
            string kultura = System.Globalization.CultureInfo.CurrentCulture.Name;
            if ((nastav.kolekce.SelectedItem == null) && (languages.FocusedItem == null))
            {
                try
                {
                    if (kultura == "cs-CZ")
                    {
                        kultura = "cestina";
                    }
                    else
                    {
                        kultura = "english";
                    }
                }
                catch
                {
                    kultura = "cestina";
                }

            }
            else
            {
                if (nastav.kolekce.SelectedItem != null)
                    kultura = nastav.kolekce.SelectedItem.ToString();
                else
                    kultura = languages.FocusedItem.Text;
            }

            string translate;

            try
            {
                using (StreamReader read = new StreamReader(Environment.CurrentDirectory + @"\Data\Languages\" + kultura + ".txt", Encoding.Default))
                {
                    translate = read.ReadToEnd();
                }

                string[] jazyk = new string[Regex.Split(translate, "<>").Length];
                jazyk = Regex.Split(translate, "<>");
                return jazyk;
            }

            catch
            {
                using (StreamReader read = new StreamReader(Environment.CurrentDirectory + @"\Data\Languages\" + kultura + ".txt", Encoding.Default))
                {
                    translate = read.ReadToEnd();
                }

                string[] jazyk = new string[Regex.Split(translate, "<>").Length];
                jazyk = Regex.Split(translate, "<>");
                return jazyk;
            }
        }
        
        #endregion

        #endregion
    }
}