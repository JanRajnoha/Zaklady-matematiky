using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mate_version2
{
    public partial class hodnoceni : Form
    {

        string celkove = "Spokojen";

        public hodnoceni()
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

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.To.Add("silver.jr.surfer@gmail.com");
                message.Subject = "Hodnocení programu Základy matematiky";
                message.From = new System.Net.Mail.MailAddress("neznamej@je.tu");
                message.Body = "Program hodnotil: " + Sender.Text + "\nE_mail: " + EMail.Text + 
                    "\n\nCelkové hodnocení programu: " + celkove +
                    "\n\n" + Evaluate.Text;


                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Timeout = 10000;
                smtp.Credentials = new System.Net.NetworkCredential("silver.jr.surfer@gmail.com", "tajne");
                smtp.Send(message);

                MessageBox.Show("Zpráva odeslána. Děkujeme za Váš názor", "Děkujeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                message.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\n\nAkci zopakujte za pár minut.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check_mail(object sender, EventArgs e)
        {
            int zavinac = 0;
            foreach (char c in EMail.Text)
            {
                if (c == '@')
                {
                    zavinac++;
                }
                else if (zavinac == 1)
                    break;
            }

            try
            {
                int tecka = 0;
                string[] domena = EMail.Text.Split('@');
                foreach (char c in domena[1])
                {
                    if (c == '.')
                    {
                        tecka++;
                    }
                    else if (tecka == 1)
                        break;
                }

                if ((zavinac == 1) && (tecka == 1))
                    send.Enabled = true;
                else
                    send.Enabled = false;
            }
            
            catch { }
        }

        private void zmena_hodnoceni(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bad_CheckedChanged(object sender, EventArgs e)
        {
            if (bad.Checked)
                celkove = "Špatné";
            if (this.good.Checked)
                celkove = "Dobré";
            if (middle.Checked)
                celkove = "+- tak nějak nic moc";
        }
    }
}
