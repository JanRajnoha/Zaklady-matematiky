using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mate_version2
{
    public partial class dialog_set : Form
    {
        public dialog_set()
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

        private void kolekce_DoubleClick(object sender, EventArgs e)
        {
            use_Click(sender, e);
        }

        private void use_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
