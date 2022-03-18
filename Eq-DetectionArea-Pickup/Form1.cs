using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eq_DetectionArea_Pickup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void act_telopmv_Tick(object sender, EventArgs e)
        {
            label1.Left += -trackBar1.Value;
            if (label1.Right < 0)
            {

                label1.Left = this.ClientSize.Width - label1.Right;
            }
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 160;
            //this.Height = 80;(元の高さ)
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "現在の速度:" + trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Height = 80;
        }

        private void act_k24api_Tick(object sender, EventArgs e)
        {

        }
    }
}
