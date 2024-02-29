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
        int suma2 = 0; // для засобів гігієни
        int suma3 = 0; // для засобів гігієни

        int suma3_res = 0;
        int suma2_res = 0;
        int suma_res = 0;
        public DomesticExpensesForm()
        {
            InitializeComponent();
        }

        
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
            suma_res = suma;
            string sumaAsString_res = suma_res.ToString();
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
        /// <summary>
        //////////////////////////////////////////////// певний обрахунок 
        private void MoneyLabel_Click(object sender, EventArgs e)
        {

        }

        private void SumEq_Click(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////// певний обрахунок
        /// ЗАСОБИ ГІГІЄНИ НИЖЧЕ          ВИЩЕ ЇЖА

        private void spoo_check_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = spoo_check.Checked;
            if (isChecked == true)
            {
                spoo_box.Enabled = true;
            }
            if (isChecked == false)
            {
                spoo_box.Enabled = false;
                spoo_box.Text = " ";
            }
        }

        private void soap_check_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = soap_check.Checked;
            if (isChecked == true)
            {
                soap_box.Enabled = true;
            }
            if (isChecked == false)
            {
                soap_box.Enabled = false;
                soap_box.Text = " ";
            }
        }

        private void gel_check_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = gel_check.Checked;
            if (isChecked == true)
            {
                gel_box.Enabled = true;
            }
            if (isChecked == false)
            {
                gel_box.Enabled = false;
                gel_box.Text = " ";
            }
        }

        private void ear_check_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ear_check.Checked;
            if (isChecked == true)
            {
                ear_box.Enabled = true;
            }
            if (isChecked == false)
            {
                ear_box.Enabled = false;
                ear_box.Text = " ";
            }
        }

        ///////////////////////////// text boxes next
        ///
        private void spoo_box_TextChanged(object sender, EventArgs e)
        {

            string userInput = spoo_box.Text;


            if (int.TryParse(userInput, out int result))
            {


                suma2 += result * 100;
                string sumaAsString = suma2.ToString();

            }
        }

        private void soap_box_TextChanged(object sender, EventArgs e)
        {
            string userInput = soap_box.Text;


            if (int.TryParse(userInput, out int result))
            {


                suma2 += result * 30;
                string sumaAsString = suma2.ToString();

            }
        }

        private void gel_box_TextChanged(object sender, EventArgs e)
        {
            string userInput = gel_box.Text;


            if (int.TryParse(userInput, out int result))
            {


                suma2 += result * 70;
                string sumaAsString = suma2.ToString();

            }
        }

        private void ear_box_TextChanged(object sender, EventArgs e)
        {
            string userInput = ear_box.Text;


            if (int.TryParse(userInput, out int result))
            {


                suma2 += result * 25;
                string sumaAsString = suma2.ToString();

            }
        }
        ///////// кнопочка обрахування і вивід суми
        ///
        private void Gig_Suma_Click(object sender, EventArgs e)
        {
            string sumaAsString = suma2.ToString();
            Gig_LABEL_Sum.Text = sumaAsString + " грн";
            suma2_res = suma2;
            string suma2AsString_res = suma2_res.ToString();
            suma2 = 0;
            ear_box.Enabled = false;
            gel_box.Enabled = false;
            soap_box.Enabled = false;
            spoo_box.Enabled = false;
            spoo_box.Text = " ";
            soap_box.Text = " ";
            gel_box.Text = " ";
            ear_box.Text = " ";

        }
        ///////////////////////////////////////////////////////////////////////////////////////
        ///пішла санітарія         зверху гігієна
        ////////////////////











        /// <summary>
        /// Чек бокси
        private void PralCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = PralCheck.Checked;
            if (isChecked == true)
            {
                PralBox.Enabled = true;
            }
            if (isChecked == false)
            {
                PralBox.Enabled = false;
                PralBox.Text = " ";
            }
        }

        private void CapCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = CapCheck.Checked;
            if (isChecked == true)
            {
                CapBox.Enabled = true;
            }
            if (isChecked == false)
            {
                CapBox.Enabled = false;
                CapBox.Text = " ";
            }
        }

        private void polCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = polCheck.Checked;
            if (isChecked == true)
            {
                polBox.Enabled = true;
            }
            if (isChecked == false)
            {
                polBox.Enabled = false;
                polBox.Text = " ";
            }
        }

        private void GanCheck_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = GanCheck.Checked;
            if (isChecked == true)
            {
                GanBox.Enabled = true;
            }
            if (isChecked == false)
            {
                GanBox.Enabled = false;
                GanBox.Text = " ";
            }
        }
        /// <summary>
        /// Текст бокси
        private void PralBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = PralBox.Text;


            if (int.TryParse(userInput, out int result))
            {


                suma3 += result * 110;
                string sumaAsString = suma3.ToString();

            }
        }

        private void CapBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = CapBox.Text;


            if (int.TryParse(userInput, out int result))
            {


                suma3 += result * 20;
                string sumaAsString = suma3.ToString();

            }
        }

        private void polBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = polBox.Text;


            if (int.TryParse(userInput, out int result))
            {


                suma3 += result * 60;
                string sumaAsString = suma3.ToString();

            }
        }

        private void GanBox_TextChanged(object sender, EventArgs e)
        {
            string userInput = GanBox.Text;
            //Sanitary_Sum.Text = "...";

            if (int.TryParse(userInput, out int result))
            {


                suma3 += result * 40;
                string sumaAsString = suma3.ToString();

            }
        }
        /// button down
        private void Sanitary_Button_Click(object sender, EventArgs e)
        {
            string sumaAsString = suma3.ToString();
            Sanitary_Sum.Text = sumaAsString + " грн";
            suma3_res = suma3;
            string suma3AsString_res = suma3_res.ToString();
            suma3 = 0;
            PralBox.Enabled = false;
            GanBox.Enabled = false;
            polBox.Enabled = false;
            CapBox.Enabled = false;
            CapBox.Text = " ";
            polBox.Text = " ";
            GanBox.Text = " ";
            PralBox.Text = " ";
        }



        //////// скидання тексту для сум
        private void FruitBox_MouseClick(object sender, MouseEventArgs e)
        {
            FoodSum.Text = "...";
        }

        private void VegBox_MouseClick(object sender, MouseEventArgs e)
        {
            FoodSum.Text = "...";
        }

        private void DrinkBox_MouseClick(object sender, MouseEventArgs e)
        {
            FoodSum.Text = "...";
        }

        private void DessertBox_MouseClick(object sender, MouseEventArgs e)
        {
            FoodSum.Text = "...";
        }

        private void spoo_box_MouseClick(object sender, MouseEventArgs e)
        {
            Gig_LABEL_Sum.Text = "...";
        }

        private void soap_box_MouseClick(object sender, MouseEventArgs e)
        {
            Gig_LABEL_Sum.Text = "...";
        }

        private void gel_box_MouseClick(object sender, MouseEventArgs e)
        {
            Gig_LABEL_Sum.Text = "...";
        }

        private void ear_box_MouseClick(object sender, MouseEventArgs e)
        {
            Gig_LABEL_Sum.Text = "...";
        }

        private void PralBox_MouseClick(object sender, MouseEventArgs e)
        {
            Sanitary_Sum.Text = "...";
        }

        private void CapBox_MouseClick(object sender, MouseEventArgs e)
        {
            Sanitary_Sum.Text = "...";
        }

        private void polBox_MouseClick(object sender, MouseEventArgs e)
        {
            Sanitary_Sum.Text = "...";
        }

        private void GanBox_MouseClick(object sender, MouseEventArgs e)
        {
            Sanitary_Sum.Text = "...";
        }

        private void SumEq_Click_1(object sender, EventArgs e)
        {
            Desc_Label.Text = suma_res + suma2_res + suma3_res + " грн";
            Sanitary_Sum.Text = suma3_res + " грн";
            FoodSum.Text = suma_res + " грн";
            Gig_LABEL_Sum.Text = suma2_res + " грн";
        }
    }

}
