using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 16093491
// Joshua du Toit

namespace GadeAssignment1
{
    public partial class Form1 : Form
    {
        int time;
        string[,] mapDisplay = new string[20, 20];
        public Form1()
        {
            InitializeComponent();
            lblTime.Text = ("Tick: " + Convert.ToString(time));
           
            // Initialize Map

            Map display = new Map();
            mapDisplay = display.newMap();

            lblDisplay.Text = "";

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    lblDisplay.Text += mapDisplay[i, j] + "   ";
                }
                lblDisplay.Text += "\n";
            }
        }
    


        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            lblTime.Text = ("Time: " + time.ToString());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

    }
}
