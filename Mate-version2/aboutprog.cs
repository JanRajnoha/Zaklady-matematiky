using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mate_version2
{
    public partial class aboutprog : Form
    {
        public aboutprog()
        {
            InitializeComponent();
        }

        private void konec(object sender, EventArgs e)
        {
            this.Close();
        }

        private void score_Click(object sender, EventArgs e)
        {
            hodnoceni result = new hodnoceni();
            result.ShowDialog(this);
        }
    }
}
