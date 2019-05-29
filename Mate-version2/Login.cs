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
    public partial class Login : Form
    {

        string heslo;
        int i;
        DialogResult dr = new DialogResult();
        bool user, pass;

        public Login()
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

        private void with_login_Click(object sender, EventArgs e)
        {
          //  zmena(sender, e);
            dr = vysledek();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (i == 0)
                {
                    oznam ozn = new oznam();
                    ozn.nadpis.Text = this.Title.Text;
                    ozn.text.Text = label3.Text;
                    ozn.Size = new System.Drawing.Size(475, 201);
                    ozn.ShowDialog();
                    with_login.DialogResult = DialogResult.OK;
                    i = 1;
                }
            }
            else
            {
                if (pass == false)
                {
                    oznam ozn = new oznam();
                    ozn.nadpis.Text = label4.Text;
                    ozn.text.Text =label4.Text + ".";
                    ozn.Size = new System.Drawing.Size(475, 201);
                    ozn.icoprog.BackgroundImage = Mate_version2.Properties.Resources.krat;
                    ozn.ShowDialog();
                }
                else if (user == false)
                {
                    oznam ozn = new oznam();
                    ozn.nadpis.Text = label5.Text;
                    ozn.text.Text = label6.Text;
                    ozn.Size = new System.Drawing.Size(475, 201);
                    ozn.icoprog.BackgroundImage = Mate_version2.Properties.Resources.krat;
                    ozn.ShowDialog();
                }
                with_login.DialogResult = DialogResult.None;
            }
        }

        public DialogResult vysledek()
        {
            if (Directory.Exists(Environment.CurrentDirectory + @"\Data\Users\" + User_log.Text))
            {
                try
                {
                    using (StreamReader pass = new StreamReader(Environment.CurrentDirectory + @"\Data\Users\" + User_log.Text + "\\password.dta", Encoding.Default))
                    {
                        heslo = pass.ReadLine();
                        pass.Close();
                    }

                    if (User_pass.Text == heslo)
                    {
                        dr = DialogResult.OK;
                        with_login.DialogResult = System.Windows.Forms.DialogResult.OK;
                        return dr;
                    }
                    else
                    {

                        pass = false;
                        dr = DialogResult.None;
                        with_login.DialogResult = System.Windows.Forms.DialogResult.None;
                        return dr;
                    }
                }
                catch
                {
                    oznam ozn = new oznam();
                    ozn.nadpis.Text = label7.Text;
                    ozn.Size = new Size(300, ozn.Size.Width);
                    ozn.text.Text = label8.Text;
                    ozn.Size = new System.Drawing.Size(475, 201);
                    ozn.icoprog.BackgroundImage = Mate_version2.Properties.Resources.krat;
                    ozn.ShowDialog();
                    dr = DialogResult.None;
                    return dr;
                }
            }
            else
            {
                user = false;
                dr = DialogResult.None;
                return dr;
            }
        }  

        public void zmena(object sender, EventArgs e)
        {
            if (User_log.Text.Length != 0)
            {
                dr = vysledek();
                with_login.Enabled = true;
            }
            else
            {
                with_login.Enabled = false;
            }
        }
    }
}
