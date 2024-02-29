using System;
using System.Collections.Generic;

namespace Finance_Manager_Of_Team_C
{
    public class CostData
    {

    }
    public class WalletData
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public List<IncomeData> Incomes { get; set; }

        public WalletData()
        {
            Incomes = new List<IncomeData>();
        }
    }

    public class IncomeData
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MoneySource { get; set; }
        public decimal Amount { get; set; }
    }
}
