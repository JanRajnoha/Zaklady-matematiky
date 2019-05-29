using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mate_version2
{
    public partial class delete : Form
    {
        string heslo;
        int i;
        DialogResult dr = new DialogResult();
        bool user, pass;

        public delete()
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

        private void delete_btn_Click(object sender, EventArgs e)
        {
          //  zmena(sender, e);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                if (i == 0)
                {
                    oznam ozn = new oznam();
                    ozn.Title.Text = label3.Text;
                    ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.ok;
                    ozn.nadpis.Text = label4.Text;
                    ozn.Size = new System.Drawing.Size(ozn.Size.Width, 300);
                    ozn.text.Text = label5.Text;
                    ozn.ShowDialog();
                    delete_btn.DialogResult = DialogResult.OK;
                    i = 1;
                   // delete_btn.Location = new Point(52,12);
                }
            }
            else
            {
                if (pass == false)
                {
                    oznam ozn = new oznam();
                    ozn.Title.Text = label6.Text;
                    ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                    ozn.nadpis.Text = label6.Text;
                    ozn.Size = new System.Drawing.Size(ozn.Size.Width, 250);
                    ozn.text.Text = label6.Text + ".";
                    ozn.ShowDialog();
                }
                else if (user == false)
                {
                    oznam ozn = new oznam();
                    ozn.Title.Text = label7.Text;
                    ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                    ozn.nadpis.Text = label7.Text;
                    ozn.Size = new System.Drawing.Size(ozn.Size.Width, 250);
                    ozn.text.Text = label8.Text;
                    ozn.ShowDialog();
                }
                delete_btn.DialogResult = DialogResult.None;
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
                        delete_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
                        return dr;
                    }
                    else
                    {

                        pass = false;
                        dr = DialogResult.None;
                        return dr;
                    }
                }
                catch
                {
                    oznam ozn = new oznam();
                    ozn.Title.Text = label9.Text;
                    ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                    ozn.nadpis.Text = label9.Text;
                    ozn.Size = new System.Drawing.Size(ozn.Size.Width, 250);
                    ozn.text.Text = label10.Text;
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
            dr = vysledek();
        }
    }
}
