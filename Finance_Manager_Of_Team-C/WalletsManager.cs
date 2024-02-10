using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    internal class WalletsManager
    {
        private List<Wallet> wallets = new List<Wallet>();

        public void SaveToCsv(string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(wallets);
            }
        }

        public void LoadFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Wallet>();
                wallets.Clear();
                foreach (var record in records)
                {
                    wallets.Add(record);
                }
            }
        }

        public List<Wallet> GetAllWallets()
        {
            return wallets;
        }
    }

    internal class Wallet
    {
        public string WalletName { get; set; }
        public decimal WalletMoney { get; set; }
    }
}
