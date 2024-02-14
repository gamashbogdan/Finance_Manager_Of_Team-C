using System;
using System.Collections.Generic;

namespace Finance_Manager_Of_Team_C
{
    public class WalletData
    {
        public string Name { get; set; }
        public string Balance { get; set; }

        // Define a property to store income data
        public List<IncomeData> Incomes { get; set; }

        // Constructor to initialize the Incomes list
        public WalletData()
        {
            Incomes = new List<IncomeData>();
        }
    }

    // Define the class for income data
    public class IncomeData
    {
        public DateTime Date { get; set; } // Date of income
        public string Category { get; set; } // Category of income
        public string Description { get; set; } // Description of the income
        public string MoneySource { get; set; } // Source of money
        public decimal Amount { get; set; } // Amount of money
    }
}
