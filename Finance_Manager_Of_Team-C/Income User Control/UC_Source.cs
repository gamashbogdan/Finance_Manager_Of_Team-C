using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    partial class UC_Source : UserControl
    {
        // Define file paths for saving and loading data
        private string dataFilePath = "finance_data.txt";

        // Constructor
        public UC_Source()
        {
            InitializeComponent();
            LoadData();
            LoadPresets(); // Load presets for categories, wallets, etc.
        }

        // Event handler for Add Funds button click
        private void AddFundsBtn_Click(object sender, EventArgs e)
        {
            // Get input values
            string amountOfMoney = textBoxAmountOfMoney.Text;
            string wallet = comboBoxWallet.SelectedItem?.ToString();
            string category = comboBoxCategory.SelectedItem?.ToString();
            string description = textBoxDescription.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(amountOfMoney) || string.IsNullOrWhiteSpace(wallet) ||
                string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save data
            SaveData(amountOfMoney, wallet, category, description);

            // Clear input fields
            textBoxAmountOfMoney.Clear();
            comboBoxWallet.SelectedIndex = -1;
            comboBoxCategory.SelectedIndex = -1;
            textBoxDescription.Clear();
        }

        // Save data to file
        private void SaveData(string amountOfMoney, string wallet, string category, string description)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(dataFilePath))
                {
                    writer.WriteLine($"Amount: {amountOfMoney}, Wallet: {wallet}, Category: {category}, Description: {description}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load data from file
        private void LoadData()
        {
            try
            {
                if (File.Exists(dataFilePath))
                {
                    string[] lines = File.ReadAllLines(dataFilePath);
                    // Display loaded data in your application as needed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load presets for categories, wallets, etc.
        private void LoadPresets()
        {
            // Add your code to load presets for categories, wallets, etc.
            // Example:
            comboBoxCategory.Items.AddRange(new object[] { "Groceries", "Utilities", "Rent", "Entertainment", "Transportation", "Healthcare" });
            comboBoxWallet.Items.AddRange(new object[] { "Cash","Card","Crypto" });
        }


        // Retrieve all data from the file
        public List<string> GetAllData()
        {
            List<string> allData = new List<string>();
            try
            {
                if (File.Exists(dataFilePath))
                {
                    allData.AddRange(File.ReadAllLines(dataFilePath));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return allData;
        }

        // Clear all saved data from the file
        public void ClearAllData()
        {
            try
            {
                File.Delete(dataFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while clearing data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
