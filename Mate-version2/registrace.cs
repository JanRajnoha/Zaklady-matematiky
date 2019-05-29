using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mate_version2
{
    public partial class Registruj : Form
    {
        public Registruj()
        {
            InitializeComponent();
            Pass.Enabled = Pass2.Enabled = false;
            register.Enabled = false;
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

        private void zmena_user(object sender, EventArgs e)
        {
            if (Directory.Exists(Environment.CurrentDirectory + @"\Data\Users\" + User_Name.Text))
            {
                Pass.Enabled = false;
                this.User.SetError(User_Name, label4.Text);
                register.Enabled = false;
            }
            else
            {
                this.User.Clear();
                Pass.Enabled = true;
            }
        }

        public void zmena_pass(object sender, EventArgs e)
        {
            if (Pass.TextLength <= 6)
            {
                this.Password.SetError(Pass, label5.Text);
                register.Enabled = false;
            }
            else
            {
                this.Password.Clear();
                Pass2.Enabled = true;
            }            
        }

        private void zmena_pass2(object sender, EventArgs e)
        {
            if (Pass.Text != Pass2.Text)
            {
                this.Password1.SetError(Pass2, label6.Text);
                register.Enabled = false;
            }
            else
            {
                if (Pass.TextLength <= 6)
                {
                    register.Enabled = false;
                }
                else
                {
                    register.Enabled = true;
                    this.Password1.Clear();
                }
            }
        }
    }
}
