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
    public partial class alarm : Form
    {
        public alarm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Second.ToString();
            label2.Text = DateTime.Now.Minute.ToString();
            label3.Text = DateTime.Now.Hour.ToString();

            if (comboBox2.Text==label2.Text && comboBox1.Text==label3.Text)
            {
                timer1.Enabled = false;
                MessageBox.Show("uyanma zamanı");
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int j = 0; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
            comboBox1.SelectedIndex = 12;
            comboBox2.SelectedIndex = 59;
        }
    }
}
