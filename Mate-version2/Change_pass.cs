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
    public partial class Change_pass : Form
    {
        string heslo;
        int i;

        public Change_pass()
        {
            InitializeComponent();
            new_Pass2.Enabled = false;
            change.Enabled = false;
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

        public void zmena_pass(object sender, EventArgs e)
        {
            if (new_Pass1.TextLength <= 6)
            {
                this.Password.SetError(new_Pass1, label5.Text);
                change.Enabled = false;
            }
            else
            {
                this.Password.Clear();
                new_Pass2.Enabled = true;
            }
        }

        private void zmena_pass2(object sender, EventArgs e)
        {
            if (new_Pass1.Text != new_Pass2.Text)
            {
                this.Password1.SetError(new_Pass2, label6.Text);
                change.Enabled = false;
            }
            else
            {
                if (new_Pass1.TextLength <= 6)
                {
                    change.Enabled = false;
                }
                else
                {
                    change.Enabled = true;
                    this.Password1.Clear();
                }
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            if (vysledek() == System.Windows.Forms.DialogResult.OK)
            {
                if (i == 0)
                {
                    oznam ozn = new oznam();
                    ozn.nadpis.Text = label7.Text;
                    ozn.text.Text = label8.Text;
                    ozn.Size = new System.Drawing.Size(475, 220);
                    ozn.ShowDialog();
                    change.DialogResult = DialogResult.OK;
                    i = 1;
                    old_pass.Enabled = false;
                    new_Pass1.Enabled = false;
                    new_Pass2.Enabled = false;
                    cancel.Enabled = false;
                }
            }
            else
            {
                change.DialogResult = DialogResult.None;
            }
        }

        private System.Windows.Forms.DialogResult vysledek()
        {
            DialogResult dr = new DialogResult();
            try
            {
                using (StreamReader oldpass = new StreamReader(Environment.CurrentDirectory + @"\Data\Users\" + label4.Text + "\\password.dta", Encoding.Default))
                {
                    heslo = oldpass.ReadLine();
                    oldpass.Close();
                }
                if (old_pass.Text == heslo)
                {
                    dr = DialogResult.OK;
                    return dr;
                }
                else
                {
                    oznam ozn = new oznam();
                    ozn.nadpis.Text = label9.Text;
                    ozn.text.Text = label9.Text + ".";
                    ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                    ozn.Size = new System.Drawing.Size(475, 220);
                    ozn.ShowDialog();
                    dr = DialogResult.None;
                    return dr;
                }
            }
            catch
            {
                oznam ozn = new oznam();
                ozn.text.Text = label10.Text;
                ozn.nadpis.Text = label11.Text;
                ozn.icoprog.BackgroundImage = global::Mate_version2.Properties.Resources.krat;
                ozn.Size = new System.Drawing.Size(475, 220);
                ozn.ShowDialog();
                dr = DialogResult.None;
                return dr;
            }
        }
    }
}
