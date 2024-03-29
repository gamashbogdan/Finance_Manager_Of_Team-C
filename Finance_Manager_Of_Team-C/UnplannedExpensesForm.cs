using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 
 
 
namespace Finance_Manager_Of_Team_C 
{
    public partial class UnplannedExpensesForm : Form
    {
        private TextBox categoryTextBox;
        private TextBox descriptionTextBox;
        private TextBox amountTextBox;

        private List<Expense> unplannedExpenses = new List<Expense>();

        public UnplannedExpensesForm()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string category = categoryTextBox.Text;
            string description = descriptionTextBox.Text;
            decimal amount;

            if (decimal.TryParse(amountTextBox.Text, out amount))
            {
                Expense newExpense = new Expense(category, description, amount);
                unplannedExpenses.Add(newExpense);


                categoryTextBox.Clear();
                descriptionTextBox.Clear();
                amountTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Некоректна сума витрат. Будь ласка, введіть числове значення.");
            }
        }

        private void buttonDomesticExpenses_Click(object sender, EventArgs e)
        {

        }
    }

    public class Expense 
    { 
        public string Category { get; } 
        public string Description { get; } 
        public decimal Amount { get; } 
 
        public Expense(string category, string description, decimal amount) 
        { 
            Category = category; 
            Description = description; 
            Amount = amount; 
        } 
    } 
}
