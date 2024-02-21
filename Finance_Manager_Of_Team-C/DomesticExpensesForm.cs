using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finance_Manager_Of_Team_C
{
    public partial class DomesticExpensesForm : Form
    {
        int suma = 0; // для їжі
        public DomesticExpensesForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ///////////////////
        }
        /// <summary>////////////////////////////////////////////////////////////
        /// //
        private void FruitCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = FruitCheck.Checked;
            if (isChecked == true)
            {
                FruitBox.Enabled = true;
            }
            if (isChecked == false)
            {
                FruitBox.Enabled = false;
                FruitBox.Text = " ";
            }
        }

        private void VegCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = VegCheck.Checked;
            if (isChecked == true)
            {
                VegBox.Enabled = true;
            }
            if (isChecked == false)
            {
                VegBox.Enabled = false;
                VegBox.Text = " ";
            }
        }

        private void DrinkCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = DrinkCheck.Checked;
            if (isChecked == true)
            {
                DrinkBox.Enabled = true;
            }
            if (isChecked == false)
            {
                DrinkBox.Enabled = false;
                DrinkBox.Text = " ";
            }
        }

        private void DessertCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = DessertCheck.Checked;
            if (isChecked == true)
            {
                DessertBox.Enabled = true;
            }
            if (isChecked == false)
            {
                DessertBox.Enabled = false;
                DessertBox.Text = " ";
            }
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////
        //









        private void FruitBox_TextChanged(object sender, EventArgs e)
        {
            // Отримання тексту з TextBox
            string userInput = FruitBox.Text;

            // Конвертація тексту у тип int
            if (int.TryParse(userInput, out int result))
            {
                // Використання значення 'result', яке тепер є int
                // Наприклад, вивести у консоль або зробити щось інше з отриманим значенням

                suma += result * 100;
                string sumaAsString = suma.ToString();

            }
        }

        private void VegBox_TextChanged(object sender, EventArgs e)
        {
            // Отримання тексту з TextBox
            string userInput = VegBox.Text;

            // Конвертація тексту у тип int
            if (int.TryParse(userInput, out int result))
            {
                // Використання значення 'result', яке тепер є int
                // Наприклад, вивести у консоль або зробити щось інше з отриманим значенням

                suma += result * 120;
                string sumaAsString = suma.ToString();

            }
        }

        private void DrinkBox_TextChanged(object sender, EventArgs e)
        {
            // Отримання тексту з TextBox
            string userInput = DrinkBox.Text;

            // Конвертація тексту у тип int
            if (int.TryParse(userInput, out int result))
            {
                // Використання значення 'result', яке тепер є int
                // Наприклад, вивести у консоль або зробити щось інше з отриманим значенням

                suma += result * 50;
                string sumaAsString = suma.ToString();

            }
        }

        private void DessertBox_TextChanged(object sender, EventArgs e)
        {
            // Отримання тексту з TextBox
            string userInput = DessertBox.Text;

            // Конвертація тексту у тип int
            if (int.TryParse(userInput, out int result))
            {
                // Використання значення 'result', яке тепер є int
                // Наприклад, вивести у консоль або зробити щось інше з отриманим значенням

                suma += result * 150;
                string sumaAsString = suma.ToString();

            }
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            // Перетворення int в string
            string sumaAsString = suma.ToString();
            FoodSum.Text = sumaAsString + " грн";
            suma = 0;
            DrinkBox.Enabled = false;
            FruitBox.Enabled = false;
            VegBox.Enabled = false;
            DessertBox.Enabled = false;
            DessertBox.Text = " ";
            VegBox.Text = " ";
            FruitBox.Text = " ";
            DrinkBox.Text = " ";

        }

       
    }
}
