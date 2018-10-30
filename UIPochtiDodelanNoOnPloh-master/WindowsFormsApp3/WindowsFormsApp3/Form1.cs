using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int panel1ColorR = 44;
        private int panel1ColorG = 62;
        private int panel1ColorB = 80;

        private int aquaColorR = 29;
        private int aquaColorG = 210;
        private int aquaColorB = 175;

        private int bufferColorR = 44;
        private int bufferColorG = 62;
        private int bufferColorB = 80;

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button1.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button2.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button3.BackColor = Color.FromArgb(panel1ColorR, panel1ColorG, panel1ColorB);
            button4.BackColor = Color.FromArgb(aquaColorR, aquaColorG, aquaColorB);
            timer1.Interval = 1;
            //button1.BackColor = Color.FromArgb(29,210,175);
            //button2.BackColor = Color.FromArgb(29, 210, 175);
            //button3.BackColor = Color.FromArgb(29, 210, 175);
        }
      
        private void ReverseTimerTickToChangeTheColor(object sender, EventArgs e)
        {
            if (bufferColorR != panel1ColorR) bufferColorR++;
            if (bufferColorG != panel1ColorG) bufferColorG--;
            if (bufferColorB != panel1ColorB) bufferColorB--;
            button1.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button2.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button3.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AnimationButtom(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load_2(object sender, EventArgs e)
        {

        }

        private void TurnOrOffTimer(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
                timer1.Enabled = true;
            else timer1.Enabled = false;
        }

        private void TimerTickToChangeTheColor(object sender, EventArgs e)
        {            
            if (bufferColorR > aquaColorR) bufferColorR-= 15;
            if (bufferColorG < aquaColorG) bufferColorG+=15;
            if (bufferColorB < aquaColorB) bufferColorB+= 15;
            button1.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button2.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
            button3.BackColor = Color.FromArgb(bufferColorR, bufferColorG, bufferColorB);
        }
    }
}
