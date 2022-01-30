using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutsnuts
{
    public partial class countdown : Form
    {
        public int p = 0;
        public int masp = 0;
        public int ltime = 0;
        
        public int dc(string perc, string masps)
        {
            int time = 0;
            p = int.Parse(perc);
            masp = int.Parse(masps);
            time += p * 60;
            time += masp;
            return time;
        }
        public void ud()
        {
            p = ltime / 60;
            masp = ltime - (p*60);
            if(masp < 10)
            {
                label1.Text = Convert.ToString(p) + ":" + Convert.ToString(masp);
            }
        }
        public countdown()
        {
            InitializeComponent();
        }

        private void countdown_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(button1.Text == "Stop")
            {
                timer1.Stop();
                button1.Text = "Start";
                ltime = 0;
                ud();
            }
            else
            {
                button1.Text = "Stop";
                ltime = dc(p1.Text, mp.Text);
                timer1.Start();
                timer1.Enabled = true;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ltime != 0)
            {
                ltime--;
                
              ud();
                if (masp == 0) 
                {
                    if (masp == 0 && p == 0) 
                    { 
                        MessageBox.Show("Time is up!", "Alert");
                        timer1.Stop();
                        button1.Text = "Start";
                        ltime = 0;
                        ud();
                    }
                    else
                    {
                        ltime--;
                        ud();
                    }
                }
            }
        }
    }
}
