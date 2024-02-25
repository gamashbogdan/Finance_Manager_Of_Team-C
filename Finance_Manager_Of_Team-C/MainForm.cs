using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Finance_Manager_Of_Team_C
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            labelTime.Text = DateTime.Now.ToString("HH : mm : ss");
            labelDate.Text = DateTime.Now.ToString("dd : MM : yyyy");
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            labelTime.Text = DateTime.Now.ToString("HH : mm : ss");
        }

       
        private void labelDate_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.ShowDialog();
        }

    }
}
