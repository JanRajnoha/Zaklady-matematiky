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
    public partial class oznam : Form
    {
        public oznam()
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
    }
}
