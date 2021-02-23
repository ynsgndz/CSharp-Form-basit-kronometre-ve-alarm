using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayacTimer
{
    public partial class kronometre : Form
    {
        public kronometre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            
           
        }
        int dakika = 0;
        int saniye = 0;
        int salise = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            salise++;
            label6.Text = salise.ToString();
            if (salise==10)
            {
                salise = 0;
                label6.Text = salise.ToString();
            }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye==60)
            {
                
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                label1.Text = saniye.ToString();
            }
        }

        private void kronometre_Load(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alarm alarm = new alarm();
            alarm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            label1.Text ="00";
            label2.Text = "00";
            label6.Text = "00";

        }
    }
}
