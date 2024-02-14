using System;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    public partial class UC_Source : UserControl
    {
        // Reference to the data class
        private WalletData walletData;

        public UC_Source(WalletData walletData)
        {
            InitializeComponent();
            this.walletData = walletData;
        }

        private void AddFundsBtn_Click(object sender, EventArgs e)
        {
            // Retrieve data from UI elements
            string category = comboBoxCategory.SelectedItem?.ToString();
            string wallet = comboBoxWallet.SelectedItem?.ToString();
            string description = textBoxDescription.Text;
            decimal amount;

            // Validate and parse the amount
            if (decimal.TryParse(textBoxAmountOfMoney.Text, out amount))
            {
                // Create a new income object
                IncomeData incomeData = new IncomeData
                {
                    Date = DateTime.Now, // You might want to allow the user to select the date
                    Category = category,
                    MoneySource = wallet,
                    Description = description,
                    Amount = amount
                };

                // Add the income data to the wallet
                if (walletData != null)
                {
                    if (walletData.Incomes == null)
                    {
                        walletData.Incomes = new List<IncomeData>();
                    }
                    walletData.Incomes.Add(incomeData);

                    // Update UI or perform any other necessary actions
                }
                else
                {
                    MessageBox.Show("Error: Wallet data is null.");
                }
            }
            else
            {
                MessageBox.Show("Invalid amount entered.");
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle category selection change
        }

        private void comboBoxWallet_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle wallet selection change
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            // Handle description text change
        }

        private void textBoxAmountOfMoney_TextChanged(object sender, EventArgs e)
        {
            // Handle amount text change
        }
    }
}
