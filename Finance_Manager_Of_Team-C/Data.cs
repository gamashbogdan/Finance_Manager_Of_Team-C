using System;
using System.Collections.Generic;

namespace Finance_Manager_Of_Team_C
{
    public static class SocialData
    {
        private static double many;

        public static double Many
        {
            get { return many; }
            set { many += value; }
        }

        public static DateTime Date { get; set; }
    }
    public static class UnplannedData
    {
        public static double Many {  get; set; }
        public static DateTime Date { get; set; }
    }
    public static class DomesticData
    {
        public static double Many {  get; set; }
        public static DateTime Date { get; set; }
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
