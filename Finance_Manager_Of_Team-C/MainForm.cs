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
            labelDate.Text = DateTime.Now.ToString("dd. MM. yyyy");
            labelDateRange.Text = $"Expenses from {DateTime.Now.ToString("dd. MM. yyyy")}";
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
            bool dateSelected = false;
            while (!dateSelected)
            {
                Calendar calendar = new Calendar();
                calendar.ShowDialog();

                if (calendar.StartDate > DateTime.MinValue && calendar.EndDate > DateTime.MinValue)
                {
                    if (calendar.StartDate != calendar.EndDate)
                    {
                        labelDateRange.Text = $"Expenses from {calendar.StartDate.ToString("dd. MM. yyyy")} to {calendar.EndDate.ToString("dd. MM. yyyy")}";
                    }
                    else
                    {
                        labelDateRange.Text = $"Expenses from {calendar.StartDate.ToString("dd. MM. yyyy")}";
                    }
                    dateSelected = true; // Встановлюємо флаг, що дата була вибрана
                }
                else
                {
                    if (MessageBox.Show("Select today's date?", "No Date Set", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        labelDateRange.Text = $"Expenses from {DateTime.Now.ToString("dd. MM. yyyy")}";
                        dateSelected = true; // Встановлюємо флаг, що дата була вибрана
                    }
                    // Якщо користувач вибирає "No", цикл продовжиться для повторного відкриття календаря
                }
            }
        }

        private void ElementIllumination_MouseEnter(object sender, EventArgs e)
        {
            // Приведення sender до типу Control
            Control control = (sender as Control)!;
            if (control != null)
            {
                control.BackColor = Color.LightGray; // Використовуйте світло-сірий колір для підсвічування
            }
        }

        private void ElementIllumination_MouseLeave(object sender, EventArgs e)
        {
            // Приведення sender до типу Control
            Control control = (sender as Control)!;
            if (control != null)
            {
                control.BackColor = Color.FromArgb(30,28,42); // Поверніть до стандартного кольору фону контролів
            }
        }

    }
}
