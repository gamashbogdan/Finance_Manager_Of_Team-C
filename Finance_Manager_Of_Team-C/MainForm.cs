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
        public Calendar calendar;
        public Timer timer;
        public MainForm()
        {
            InitializeComponent();
            calendar = new Calendar();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            labelTime.Text = DateTime.Now.ToString("HH : mm : ss");
            labelDate.Text = DateTime.Now.ToString("dd. MM. yyyy");
            labelDateRange.Text = $"Expenses {DateTime.Now.ToString("dd. MM. yyyy")}";
            UpdateDiagram();
        }
        public void DiagramUnplanned()
        {
            if (UnplannedExpensesPanelDiagram.Controls.Count > 0)
            {
                // Припускаємо, що у панелі є тільки один контрол діаграми
                UnplannedExpensesPanelDiagram.Controls.Clear(); // Очищення панелі перед додаванням нової діаграми
            }
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

            if (calendar.StartDate > DateTime.MinValue && calendar.EndDate > DateTime.MinValue)
            {
                bool isDifferentYears = calendar.StartDate.Year != calendar.EndDate.Year;
                // Цикл для кожного дня у вибраному діапазоні
                for (DateTime date = calendar.StartDate; date <= calendar.EndDate; date = date.AddDays(1)) // Змінено на AddDays(1)
                {
                    // Форматування дати
                    string dateFormat = isDifferentYears ? "dd.MM.yyyy" : "dd.MM";
                    string formattedDate = date.ToString(dateFormat);
                    // Додавання точки до серії з форматованою датою як X і деяким значенням Y, наприклад, 1000
                    series.Points.AddXY(formattedDate, UnplannedData.Many);
                }
            }
            else
            {
                series.Points.AddXY(DateTime.Now.ToString("dd.MM"),0);
                labelUnplannedExpenses.Text = $"Unplanned Expenses : {UnplannedData.Many}";
            }

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
        public void DiagramDomestic()
        {
            if (DomesticExpensesPanelDiagram.Controls.Count > 0)
            {
                // Припускаємо, що у панелі є тільки один контрол діаграми
                DomesticExpensesPanelDiagram.Controls.Clear(); // Очищення панелі перед додаванням нової діаграми
            }
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
            if (calendar.StartDate > DateTime.MinValue && calendar.EndDate > DateTime.MinValue)
            {
                bool isDifferentYears = calendar.StartDate.Year != calendar.EndDate.Year;
                // Цикл для кожного дня у вибраному діапазоні
                for (DateTime date = calendar.StartDate; date <= calendar.EndDate; date = date.AddDays(1)) // Змінено на AddDays(1)
                {
                    // Форматування дати
                    string dateFormat = isDifferentYears ? "dd.MM.yyyy" : "dd.MM";
                    string formattedDate = date.ToString(dateFormat);
                    // Додавання точки до серії з форматованою датою як X і деяким значенням Y, наприклад, 1000
                    series.Points.AddXY(formattedDate, DomesticData.Many);
                }
            }
            else
            {
                series.Points.AddXY(DateTime.Now.ToString("dd.MM"), 0);
                labelDomesticExpenses.Text = $"Domestic Expenses : {DomesticData.Many}";
            }

            
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
        public void DiagramSocial()
        {
            if (SocialExpensesPanelDiagram.Controls.Count > 0)
            {
                // Припускаємо, що у панелі є тільки один контрол діаграми
                SocialExpensesPanelDiagram.Controls.Clear(); // Очищення панелі перед додаванням нової діаграми
            }
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
            // Перевірка, чи діапазон дат охоплює більше одного року
            if(calendar.StartDate > DateTime.MinValue && calendar.EndDate > DateTime.MinValue)
            {
                bool isDifferentYears = calendar.StartDate.Year != calendar.EndDate.Year;
                // Цикл для кожного дня у вибраному діапазоні
                for (DateTime date = calendar.StartDate; date <= calendar.EndDate; date = date.AddDays(1))
                {
                    // Форматування дати
                    string dateFormat = isDifferentYears ? "dd.MM.yyyy" : "dd.MM";
                    string formattedDate = date.ToString(dateFormat);
                    // Додавання точки до серії з форматованою датою як X і деяким значенням Y, наприклад, 1000
                    series.Points.AddXY(formattedDate, SocialData.Many);
                }
            }
            else
            {
                series.Points.AddXY(DateTime.Now.ToString("dd.MM"), SocialData.Many);
                labelSocialExpences.Text = $"Social Expenses : {SocialData.Many}"; 
            }
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
        public void DiagramIncome()
        {
            if (IncomePanelDiagram.Controls.Count > 0)
            {
                // Припускаємо, що у панелі є тільки один контрол діаграми
                IncomePanelDiagram.Controls.Clear(); // Очищення панелі перед додаванням нової діаграми
            }
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
            IncomeData incomeData = new IncomeData();
            if (calendar.StartDate > DateTime.MinValue && calendar.EndDate > DateTime.MinValue)
            {
                bool isDifferentYears = calendar.StartDate.Year != calendar.EndDate.Year;
                // Цикл для кожного дня у вибраному діапазоні
                for (DateTime date = calendar.StartDate; date <= calendar.EndDate; date = date.AddDays(1)) // Змінено на AddDays(1)
                {
                    // Форматування дати
                    string dateFormat = isDifferentYears ? "dd.MM.yyyy" : "dd.MM";
                    string formattedDate = date.ToString(dateFormat);
                    // Додавання точки до серії з форматованою датою як X і деяким значенням Y, наприклад, 1000
                    series.Points.AddXY(formattedDate, incomeData.Amount);
                }
            }
            else
            {
                series.Points.AddXY(DateTime.Now.ToString("dd.MM"), 0);
                labelIncome.Text = $"Income : {incomeData.Amount}";
            }

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
        public void Timer_Tick(object? sender, EventArgs e)
        {
            UpdateTime();
        }
        public void UpdateTime()
        {
            labelTime.Text = DateTime.Now.ToString("HH : mm : ss");
        }

        public void ElementIllumination_MouseEnter(object sender, EventArgs e)
        {
            // Приведення sender до типу Control
            Control control = (sender as Control)!;
            if (control != null)
            {
                control.BackColor = Color.LightGray; // Використовуйте світло-сірий колір для підсвічування
            }
        }

        public void ElementIllumination_MouseLeave(object sender, EventArgs e)
        {
            // Приведення sender до типу Control
            Control control = (sender as Control)!;
            if (control != null)
            {
                control.BackColor = Color.FromArgb(30, 28, 42); // Поверніть до стандартного кольору фону контролів
            }
        }
        public void UpdateDiagram()
        {
            DiagramIncome();
            DiagramSocial();
            DiagramDomestic();
            DiagramUnplanned();
        }
        public void labelDate_Click(object sender, EventArgs e)
        {
            
            calendar.ShowDialog();
            if (calendar.StartDate > DateTime.MinValue && calendar.EndDate > DateTime.MinValue)
            {
                if (calendar.StartDate.Day != calendar.EndDate.Day)
                {
                    labelDateRange.Text = $"Expenses {calendar.StartDate.ToString("dd. MM. yyyy")} - {calendar.EndDate.ToString("dd. MM. yyyy")}";
                    UpdateDiagram();
                }
                else
                {
                    labelDateRange.Text = $"Expenses {calendar.StartDate.ToString("dd. MM. yyyy")}";
                    UpdateDiagram();
                }
            }
            else
            {
                labelDateRange.Text = $"Expenses {DateTime.Now.ToString("dd. MM. yyyy")}";
                UpdateDiagram();
            }
        }

       
    }
}
