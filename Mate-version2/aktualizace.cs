using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Mate_version2
{
    public partial class aktualizace : Form
    {
        WebClient c = new WebClient();
        string verz;

        public aktualizace()
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

        private void aktualizace_Load(object sender, EventArgs e)
        {
            load_pic.Load(Environment.CurrentDirectory + "\\Data\\Icons\\load4.gif");
            load_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void nacteno(object sender, EventArgs e)
        {
            verz = this.ProductVersion;
            download down = new download();
            bool full = true;
            String[] preklad = new string[6];
            preklad[0] = label2.Text;
            preklad[1] = label3.Text;
            preklad[2] = label4.Text;
            preklad[3] = label5.Text;
            preklad[4] = label6.Text;
            preklad[5] = label7.Text;
            if (down.kontrola(preklad, verz, label1.Text, full) == "Stahuji!")
            {
                status.Text = "Stahuji!";
                down.Download(label1.Text);
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            }
            else
                this.Close();
        }
    }
}
