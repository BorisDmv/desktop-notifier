using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Notifier
{
    public partial class Form1 : Form
    {
        bool dragStrip;
        int moveX, moveY;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeTextBtn_Click(object sender, EventArgs e)
        {
            titleText.Text = "Test Panel";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            this.clockLabel.Text = currentTime.ToString("hh:mm:ss");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void topStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragStrip)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void topStrip_MouseUp(object sender, MouseEventArgs e)
        {
            dragStrip = false;
        }

        private void topStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragStrip = true;
                moveX = e.X;
                moveY = e.Y;
            }
        }
    }
}
