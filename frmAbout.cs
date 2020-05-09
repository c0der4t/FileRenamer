using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class frmAbout : Form
    {
        private bool SelectionActive = false;

        public frmAbout()
        {
            InitializeComponent();
        }

        private void btnCloseAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/c0der4t/FileRenamer");
        }

        private void btnGithub_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnGithub_MouseEnter(object sender, EventArgs e)
        {
            SelectionActive = false;
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            SelectionActive = true;
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {
            SelectionActive = true;
        }

        private void btnResources_MouseEnter(object sender, EventArgs e)
        {
            SelectionActive = false;
        }

        private void btnCredits_MouseEnter(object sender, EventArgs e)
        {
            SelectionActive = false;
        }

        private void pnlVersionInfo_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pnlVersionInfo_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pnlVersionInfo_Paint(object sender, PaintEventArgs e)
        {

            Color col = Color.White; 
            ButtonBorderStyle bbs = ButtonBorderStyle.Solid; 
            int thickness = 1; 

            ControlPaint.DrawBorder(e.Graphics, this.pnlVersionInfo.ClientRectangle,col, thickness, bbs, col, thickness, bbs, col, thickness, bbs, col, thickness, bbs);

        }
    }
}
