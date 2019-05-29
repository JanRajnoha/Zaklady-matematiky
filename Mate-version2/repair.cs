using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Mate_version2
{
    public partial class repair : Form
    {
        int[] souradnice = new int[2];
        WebClient c = new WebClient();
        string[] adresa1 = new string[20];
        string[] soubory, odkazy;
        int d, i = 0;
        Timer tim = new Timer();

        public repair()
        {
            InitializeComponent();     
     
            if (!Directory.Exists(Environment.CurrentDirectory + @"\\Data"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\\Data");
                Directory.CreateDirectory(Environment.CurrentDirectory + @"\\Data\\Repair");
            }
            else
            { 
                if (!Directory.Exists(Environment.CurrentDirectory + @"\\Data\Repair"))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + @"\\Data\\Repair");
                }
            }

            if (!File.Exists(Environment.CurrentDirectory + @"\\Data\\Repair\\verze.txt"))
            {
                using(FileStream pass = new FileStream(Environment.CurrentDirectory + @"\\Data\\Repair\\verze.txt", FileMode.Create, FileAccess.Write))
                using (StreamWriter write = new StreamWriter(pass, Encoding.Default))
                {
                    write.Write(this.ProductVersion);
                    write.Close();
                }
                File.Delete(Environment.CurrentDirectory + @"\\Upgrade.dll");
            }
            else
            {
                using (FileStream pass = new FileStream(Environment.CurrentDirectory + @"\\Data\\Repair\\verze.txt", FileMode.Open, FileAccess.ReadWrite))
                using (StreamReader read = new StreamReader(pass, Encoding.Default))
                {
                    string verze = read.ReadToEnd();
                    if (verze != this.ProductVersion)
                    {
                        read.Close();
                        using (FileStream pass2 = new FileStream(Environment.CurrentDirectory + @"\\Data\\Repair\\verze.txt", FileMode.Create, FileAccess.ReadWrite))
                        using (StreamWriter write = new StreamWriter(pass2, Encoding.Default))
                        {
                            write.Write(this.ProductVersion);
                            write.Close();
                        }
                        File.Delete(Environment.CurrentDirectory + @"\\Upgrade.dll");
                    }
                }
            }

            try
            {
                StreamReader readname = new StreamReader(Environment.CurrentDirectory + @"\\Data\\Repair\\soubory.txt", Encoding.Default);
                soubory = Regex.Split(readname.ReadToEnd(), "<<<>>>");
                prvky_kontr.Maximum = soubory.Length;
                StreamReader readpath = new StreamReader(Environment.CurrentDirectory + @"\\Data\\Repair\\odkazy.txt", Encoding.Default);
                odkazy = Regex.Split(readpath.ReadToEnd(), "<<<>>>");
                tim.Interval = 1000;
                tim.Tick += new System.EventHandler(this.ticknuti);
                tim.Start();
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.ToString(), "Byla nalezena chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00C00000 /* WS_CAPTION */;
                return cp;
            }
        }

        public void spadnuti(object sender, MouseEventArgs e)
        {
            this.Location = new System.Drawing.Point(MousePosition.X - souradnice[0], MousePosition.Y - souradnice[1]);
            souradnice[1] = souradnice[0] = 0;
            this.Opacity = 1D;
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

        private void konecapi(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pokus(int poradi)
        {
            try
            {
                c.DownloadProgressChanged += c_DownloadProgressChanged;
                c.DownloadFileCompleted += new AsyncCompletedEventHandler(c_DownloadFileCompleted);

                if (d >= 1)
                {
                    if (poradi >= soubory.Length)
                        this.Close();

                    prvek.Text = "Prvek: " + soubory[poradi];
                    prvek.Refresh();
                    prvky_kontr.Refresh();
                    if (!File.Exists(Environment.CurrentDirectory + "\\" + @soubory[poradi]))
                    {
                        Uri u = new Uri(odkazy[poradi]);
                        c.DownloadFileAsync(u, Environment.CurrentDirectory + "\\" + soubory[poradi]);
                    }
                    else
                    {
                        i++;
                        pokus(i);
                    }
                    prvky_kontr.Increment(1);
                }
            }
            catch
            { }
        }

        private void c_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if ((i + 2 <= soubory.Length) && (!c.IsBusy))
            {
                i++;
                prvky_down.Value = 0;  
                pokus(i);
            }
            else 
            {
               if (!c.IsBusy)
               {
           //        System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\\Základy matematiky.exe");
                   this.Close(); 
               }
            }
        }

        void c_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            prvky_down.Value = e.ProgressPercentage;
            Procenta.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void kontrola(object sender, EventArgs e)
        {
            Timer tim = new Timer();
            tim.Interval = 1000;
            tim.Tick += new System.EventHandler(this.ticknuti);
            tim.Start(); 
        }

        public void ticknuti(object sender, EventArgs e)
        {
            d++;
            tim.Stop();
            tim.Tick += null;
            if (d == 1)
            {
                pokus(0);
            }
        }
    }
}
