using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Mate_version2
{
    public partial class donate : Form
    {
        public donate()
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

        private void accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dotovat(object sender, EventArgs e)
        {
            string url = "";

            string business = "blade.kd@seznam.cz";  // your paypal email
            string description = "GoID";            // '%20' represents a space. remember HTML!
            string country = "CZ";                  // AU, US, etc.
            string currency = "CZK";                 // AUD, USD, etc.

            url += "https://www.paypal.com/cgi-bin/webscr" +
                "?cmd=" + "_donations" +
                "&business=" + business +
                "&lc=" + country +
                "&item_name=" + description +
                "&currency_code=" + currency +
                "&bn=" + "PP%2dDonationsBF";


            Process.Start(@"https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=YBT36PSV8CEXS");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
