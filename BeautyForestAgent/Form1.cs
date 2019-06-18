using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Visibled(bool visible)
        {
            this.Visible = visible;
            this.ntiTray.Visible = !visible;
        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            Visibled(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visibled(false);
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visibled(true);
        }

        private void NtiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Visibled(true);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ntiTray.Visible = false;
            Application.ExitThread();
        }
    }
}
