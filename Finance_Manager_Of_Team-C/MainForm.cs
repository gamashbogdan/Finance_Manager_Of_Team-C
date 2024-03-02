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
using System.Windows.Forms.DataVisualization.Charting;

namespace Finance_Manager_Of_Team_C
{
    public partial class MainForm : Form
    {
        public Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            labelTime.Text = DateTime.Now.ToString("HH : mm : ss");
            labelDate.Text = DateTime.Now.ToString("dd. MM. yyyy");
            labelDateRange.Text = $"Expenses {DateTime.Now.ToString("dd. MM. yyyy")}";
            DiagramIncome();
            DiagramSocial();
            DiagramDomestic();
            DiagramUnplanned();
        }
        private void DiagramUnplanned()
        {
            // Створення нового екземпляру контролу Chart
            Chart chart = new Chart
            {
                // Налаштування розміру та положення діаграми відповідно до розміру панелі
                Dock = DockStyle.Fill
            };

            // Налаштування області діаграми
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Створення серії даних
            Series series = new Series("Витрати")
            {
                ChartType = SeriesChartType.Column// Тип діаграми - стовпчикова
            };
            // Додавання даних до серії (приклад)
            series.Points.AddXY("Січень", 100);
            series.Points.AddXY("Лютий", 300);
            series.Points.AddXY("Березень", 150);
            series.Points.AddXY("Березень", 450);
            series.Points.AddXY("Січень", 100);
            series.Points.AddXY("Лютий", 300);
            series.Points.AddXY("Березень", 150);
            series.Points.AddXY("Березень", 450);
            series.Points.AddXY("Січень", 100);
            series.Points.AddXY("Лютий", 300);
            series.Points.AddXY("Березень", 150);
            series.Points.AddXY("Березень", -450);
            // Продовжуйте додавати дані за потребою

            // Додавання серії даних до діаграми
            chart.Series.Add(series);

            // Додавання діаграми до панелі
            UnplannedExpensesPanelDiagram.Controls.Add(chart);
            // Зміна кольору фону діаграми
            chart.ChartAreas[0].BackColor = Color.FromArgb(30, 28, 42);
            // Зміна кольору ліній сітки на білий (якщо потрібно)
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;


        }
        private void DiagramDomestic()
        {
            // Створення нового екземпляру контролу Chart
            Chart chart = new Chart
            {
                // Налаштування розміру та положення діаграми відповідно до розміру панелі
                Dock = DockStyle.Fill
            };

            // Налаштування області діаграми
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Створення серії даних
            Series series = new Series("Витрати")
            {
                ChartType = SeriesChartType.Column // Тип діаграми - стовпчикова
            };
            // Додавання даних до серії (приклад)
            series.Points.AddXY("Січень", 1000);
            series.Points.AddXY("Лютий", 800);
            series.Points.AddXY("Березень", 28000);
            // Продовжуйте додавати дані за потребою

            // Додавання серії даних до діаграми
            chart.Series.Add(series);

            // Додавання діаграми до панелі
            DomesticExpensesPanelDiagram.Controls.Add(chart);
            // Зміна кольору фону діаграми
            chart.ChartAreas[0].BackColor = Color.FromArgb(30, 28, 42);
            // Зміна кольору ліній сітки на білий (якщо потрібно)
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;


        }
        private void DiagramSocial()
        {
            // Створення нового екземпляру контролу Chart
            Chart chart = new Chart
            {
                // Налаштування розміру та положення діаграми відповідно до розміру панелі
                Dock = DockStyle.Fill
            };

            // Налаштування області діаграми
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Створення серії даних
            Series series = new Series("Витрати")
            {
                ChartType = SeriesChartType.Column // Тип діаграми - стовпчикова
            };
            // Додавання даних до серії (приклад)
            series.Points.AddXY("Січень", 1000);
            series.Points.AddXY("Лютий", 800);
            series.Points.AddXY("Березень", 28000);
            // Продовжуйте додавати дані за потребою

            // Додавання серії даних до діаграми
            chart.Series.Add(series);

            // Додавання діаграми до панелі
            SocialExpensesPanelDiagram.Controls.Add(chart);
            // Зміна кольору фону діаграми
            chart.ChartAreas[0].BackColor = Color.FromArgb(30, 28, 42);
            // Зміна кольору ліній сітки на білий (якщо потрібно)
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;


        }
        private void DiagramIncome()
        {
            // Створення нового екземпляру контролу Chart
            Chart chart = new Chart
            {
                // Налаштування розміру та положення діаграми відповідно до розміру панелі
                Dock = DockStyle.Fill
            };

            // Налаштування області діаграми
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Створення серії даних
            Series series = new Series("Витрати")
            {
                ChartType = SeriesChartType.Column // Тип діаграми - стовпчикова
            };
            // Додавання даних до серії (приклад)
            series.Points.AddXY("Січень", 1000);
            series.Points.AddXY("Лютий", 800);
            series.Points.AddXY("Березень", 28000);
            // Продовжуйте додавати дані за потребою

            // Додавання серії даних до діаграми
            chart.Series.Add(series);

            // Додавання діаграми до панелі
            IncomePanelDiagram.Controls.Add(chart);
            // Зміна кольору фону діаграми
            chart.ChartAreas[0].BackColor = Color.FromArgb(30, 28, 42);
            // Зміна кольору ліній сітки на білий (якщо потрібно)
            chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;


        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateTime();
        }
        private void UpdateTime()
        {
            labelTime.Text = DateTime.Now.ToString("HH : mm : ss");
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
                control.BackColor = Color.FromArgb(30, 28, 42); // Поверніть до стандартного кольору фону контролів
            }
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
                        labelDateRange.Text = $"Expenses {calendar.StartDate.ToString("dd. MM. yyyy")} - {calendar.EndDate.ToString("dd. MM. yyyy")}";
                    }
                    else
                    {
                        labelDateRange.Text = $"Expenses {calendar.StartDate.ToString("dd. MM. yyyy")}";
                    }
                    dateSelected = true; // Встановлюємо флаг, що дата була вибрана
                }
                else
                {
                    if (MessageBox.Show("Select today's date?", "No Date Set", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        labelDateRange.Text = $"Expenses {DateTime.Now.ToString("dd. MM. yyyy")}";
                        dateSelected = true; // Встановлюємо флаг, що дата була вибрана
                    }
                    // Якщо користувач вибирає "No", цикл продовжиться для повторного відкриття календаря
                }
            }
        }

       
    }
}
