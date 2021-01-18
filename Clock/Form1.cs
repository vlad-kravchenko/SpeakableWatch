using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        Talk talk;

        public Form1()
        {
            InitializeComponent();
            talk = new Talk();
        }

        private void lbTime_Click(object sender, EventArgs e)
        {
            talk.TalkTime(DateTime.Now);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss");
            if (DateTime.Now.Second == 0) talk.TalkTime(DateTime.Now);
        }

        private void ShowTime()
        {
            
        }
    }
}
