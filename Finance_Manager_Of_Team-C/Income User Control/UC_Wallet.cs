using System;
using System.IO;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    public partial class UC_Wallet : UserControl
    {
        private WalletsManager walletsManager;
        private string projectDirectory;

        public UC_Wallet()
        {
            InitializeComponent();
            walletsManager = new WalletsManager();
            projectDirectory = Directory.GetCurrentDirectory();
        }

        public void SaveDataToCsv()
        {
            string filePath = Path.Combine(projectDirectory, "wallets.csv");
            walletsManager.SaveToCsv(filePath);
        }

        public void LoadDataFromCsv()
        {
            string filePath = Path.Combine(projectDirectory, "wallets.csv");
            walletsManager.LoadFromCsv(filePath);
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            dataGridViewWallets.Rows.Clear();
            var wallets = walletsManager.GetAllWallets();
            foreach (var wallet in wallets)
            {
                dataGridViewWallets.Rows.Add(wallet.WalletName, wallet.WalletMoney);
            }
        }
    }
}
