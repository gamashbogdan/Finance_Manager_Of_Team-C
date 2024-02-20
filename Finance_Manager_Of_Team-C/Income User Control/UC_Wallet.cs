using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    public partial class UC_Wallet : UserControl
    {
        private string txtFilePath = "wallet_data.txt";
        public List<WalletData> WalletDataList;

        public UC_Wallet()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadDataFromTxt();

            if (this.ParentForm != null)
            {
                this.ParentForm.FormClosing += ParentForm_FormClosing;
            }

            UpdateTotalBalanceLabel();
        }

        private void UpdateTotalBalanceLabel()
        {
            decimal totalBalance = 0;
            foreach (WalletData walletData in WalletDataList)
            {
                decimal balance;
                if (decimal.TryParse(walletData.Balance, out balance))
                {
                    totalBalance += balance;
                }
            }
            label3.Text = $"$ {totalBalance}";
        }

        private void InitializeDataGridView()
        {
            dataGridViewWallets.AutoGenerateColumns = false;
            dataGridViewWallets.Columns.Add("Name", "Wallet Name");
            dataGridViewWallets.Columns.Add("Balance", "Balance");
            dataGridViewWallets.CellValueChanged += DataGridViewWallets_CellValueChanged;
        }

        private void DataGridViewWallets_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < dataGridViewWallets.ColumnCount)
            {
                string name = dataGridViewWallets.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                string balance = dataGridViewWallets.Rows[e.RowIndex].Cells["Balance"].Value?.ToString();

                if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(balance))
                {
                    dataGridViewWallets.Rows.RemoveAt(e.RowIndex);
                    WalletDataList.RemoveAt(e.RowIndex);
                }
                else
                {
                    if (e.RowIndex < WalletDataList.Count)
                    {
                        WalletDataList[e.RowIndex].Name = name;
                        WalletDataList[e.RowIndex].Balance = balance;
                    }
                    else
                    {
                        WalletDataList.Add(new WalletData { Name = name, Balance = balance });
                    }
                }

                SaveDataToTxt();
            }
        }

        private void SaveDataToTxt()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(txtFilePath))
                {
                    foreach (WalletData walletData in WalletDataList)
                    {
                        sw.WriteLine($"{walletData.Name},{walletData.Balance}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data to TXT file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromTxt()
        {
            try
            {
                WalletDataList = new List<WalletData>();

                if (File.Exists(txtFilePath))
                {
                    string[] lines = File.ReadAllLines(txtFilePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            WalletDataList.Add(new WalletData { Name = parts[0], Balance = parts[1] });
                            dataGridViewWallets.Rows.Add(parts[0], parts[1]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data from TXT file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateTotalBalanceLabel();
            SaveDataToTxt();
        }

        public void AddRow(string walletName, string balance)
        {
            dataGridViewWallets.Rows.Add(walletName, balance);
            WalletDataList.Add(new WalletData { Name = walletName, Balance = balance });
            UpdateTotalBalanceLabel();
            SaveDataToTxt();
        }

        public void DeleteRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridViewWallets.Rows.Count)
            {
                dataGridViewWallets.Rows.RemoveAt(rowIndex);
                WalletDataList.RemoveAt(rowIndex);
                UpdateTotalBalanceLabel();
                SaveDataToTxt();
            }
        }
    }
}
