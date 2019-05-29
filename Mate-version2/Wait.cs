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
    public partial class Wait : Form
    {
        public Wait()
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

        private void Wait_Load(object sender, EventArgs e)
        {
            load_pic.Load(Environment.CurrentDirectory + "\\Data\\Icons\\load4.gif");
            load_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
