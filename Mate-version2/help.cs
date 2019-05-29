using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Mate_version2
{
    public partial class help : Form
    {
        ArrayList tema = new ArrayList();
        int[] souradnice = new int[2];
        
        public help()
        {
            InitializeComponent();
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

        private void help_Load(object sender, EventArgs e)
        {
            try
            {
                temata.Items.Clear();
                DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory + @"\Data\Help");
                FileInfo[] FI = di.GetFiles();
                if (FI.Length != 0)
                {
                    nacist(di);
                }
                txt.LoadFile(tema[0].ToString());
            }
            catch
            {
                MessageBox.Show("Program neobsahuje nápovědu", "Chybí nápověda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            search.Focus();      
        }

        private void zmena(object sender, EventArgs e)
        {
            txt.LoadFile(tema[temata.SelectedIndex].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storno(sender, e);
            if (cela.Checked)
            {
                int i = 0;
                int z = 0;
                while (i <= (temata.Items.Count - 1))
                {
                    txt.LoadFile(tema[i].ToString());
                    int find = txt.Find(search.Text);
                    int x = 0;
                    x = txt.Find(search.Text, x, RichTextBoxFinds.NoHighlight);
                    if (x == -1)
                    {
                        tema.Remove(temata.Items[z].ToString());
                        temata.Items.Remove(temata.Items[z].ToString());
                        cancel.Visible = true;
                    }
                    else
                    {
                        txt.Select(x, search.Text.Length);
                        x += search.Text.Length;
                        txt.SelectionColor = Color.Black;
                        txt.SelectionBackColor = Color.Yellow;
                        z++;
                        i++;
                    }
                }
                if (temata.Items.Count != 0)
                    txt.LoadFile(tema[0].ToString());
            }
            else
            {
                int find = txt.Find(search.Text);
                int i = 0;
                while (true)
                {
                    i = txt.Find(search.Text, i, RichTextBoxFinds.NoHighlight);
                    if (i == -1)
                        break;
                    txt.Select(i, search.Text.Length);
                    i += search.Text.Length;
                    txt.SelectionColor = Color.Black;
                    txt.SelectionBackColor = Color.Yellow;
                }
            }

        /*    Regex r = new Regex(search.Text);
            foreach (Match m in r.Matches(txt.Text))
            {
                txt.Select(m.Index, m.Length);
                txt.SelectionBackColor = Color.Blue;
            } */
        }

        private void zkratky(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    txt.Select();
                    txt.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
                    txt.SelectionColor = Color.White;
                    txt.Select(0, 0);
                    storno(sender, e);
                    break;
                case Keys.Enter:
                    button1_Click(sender, e);
                    break;
            }
        }

        private void napoveda(object sender, EventArgs e)
        {
            if ((cela.Checked) && (cancel.Visible == true))
            {
                int find = txt.Find(search.Text);
                int i = 0;
                while (true)
                {
                    i = txt.Find(search.Text, i, RichTextBoxFinds.NoHighlight);
                    if (i == -1)
                        break;
                    txt.Select(i, search.Text.Length);
                    i += search.Text.Length;
                    txt.SelectionColor = Color.Black;
                    txt.SelectionBackColor = Color.Yellow;
                }                
            }
        }

        private void storno(object sender, EventArgs e)
        {
            cancel.Visible = false;
            temata.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory + @"\Data\Help");
            FileInfo[] FI = di.GetFiles();
            if (FI.Length != 0)
            {
                nacist(di);
            }
            txt.LoadFile(tema[0].ToString());
        }

        private void nacist(DirectoryInfo di)
        {
            for (int i = 0; i <= 5; i++)
            {
                tema.Add("asd");
                temata.Items.Add("asdasd");
            }

            foreach (FileInfo topic in di.GetFiles("*.rtf"))
            {
                switch (Path.GetFileNameWithoutExtension(topic.FullName))
                {
                    case "Obecné":
                        tema[0] = topic.FullName;
                        temata.Items[0] = Path.GetFileNameWithoutExtension(topic.FullName);
                        break;
                    case "Aktualizace":
                        tema[5] = topic.FullName;
                        temata.Items[5] = Path.GetFileNameWithoutExtension(topic.FullName);
                        break;
                    case "Nastavení":
                        tema[2] = topic.FullName;
                        temata.Items[2] = Path.GetFileNameWithoutExtension(topic.FullName);
                        break;
                    case "Uživatelé":
                        tema[3] = topic.FullName;
                        temata.Items[3] = Path.GetFileNameWithoutExtension(topic.FullName);
                        break;
                    case "Test":
                        tema[1] = topic.FullName;
                        temata.Items[1] = Path.GetFileNameWithoutExtension(topic.FullName);
                        break;
                    case "Ukládání":
                        tema[4] = topic.FullName;
                        temata.Items[4] = Path.GetFileNameWithoutExtension(topic.FullName);
                        break;

                    default:
                        tema.Add(topic.FullName);
                        temata.Items.Add(Path.GetFileNameWithoutExtension(topic.FullName));
                        break;
                }
            }
        }
    }
}
