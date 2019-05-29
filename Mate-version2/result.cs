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
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void konec(object sender, EventArgs e)
        {
            this.Close();
        }

        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.ToString() == Keys.Escape.ToString())
            {
                this.Close();
            }
        }

        private void lomeno_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.ToString() == Keys.Escape.ToString())
            {
                this.Close();
            }
        }

        private void result_Load(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            para_panel.Visible = true;
        }

        private void close_para(object sender, EventArgs e)
        {
            para_panel.Visible = false;
        }
    }
}
