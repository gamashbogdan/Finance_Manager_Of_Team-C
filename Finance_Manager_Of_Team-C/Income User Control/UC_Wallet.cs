using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    public partial class UC_Wallet : UserControl
    {
        private string csvFilePath = "wallet_data.csv";

        public UC_Wallet()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadDataFromCSV();
        }

        private void InitializeDataGridView()
        {
            // Set up the DataGridView properties
            dataGridViewWallets.AutoGenerateColumns = false;

            // Add columns to the DataGridView
            dataGridViewWallets.Columns.Add("Name", "Wallet Name");
            dataGridViewWallets.Columns.Add("Balance", "Balance");

            // Add an event handler for cell value changed
            dataGridViewWallets.CellValueChanged += DataGridViewWallets_CellValueChanged;
        }

        private void DataGridViewWallets_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if both the name and balance fields are empty after editing
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewWallets.ColumnCount)
            {
                string name = dataGridViewWallets.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                string balance = dataGridViewWallets.Rows[e.RowIndex].Cells["Balance"].Value?.ToString();

                if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(balance))
                {
                    dataGridViewWallets.Rows.RemoveAt(e.RowIndex);
                    SaveDataToCSV();
                }
            }
        }

        private void SaveDataToCSV()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(csvFilePath))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (DataGridViewRow row in dataGridViewWallets.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sb.AppendLine($"{row.Cells["Name"].Value},{row.Cells["Balance"].Value}");
                        }
                    }
                    sw.Write(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data to CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromCSV()
        {
            try
            {
                if (File.Exists(csvFilePath))
                {
                    using (StreamReader sr = new StreamReader(csvFilePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            dataGridViewWallets.Rows.Add(parts[0], parts[1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Allow adding rows programmatically
        public void AddRow(string walletName, string balance)
        {
            dataGridViewWallets.Rows.Add(walletName, balance);
            SaveDataToCSV();
        }

        // Allow deleting rows programmatically
        public void DeleteRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridViewWallets.Rows.Count)
            {
                dataGridViewWallets.Rows.RemoveAt(rowIndex);
                SaveDataToCSV();
            }
        }

        // You may add more methods to handle additional user interactions
    }
}
