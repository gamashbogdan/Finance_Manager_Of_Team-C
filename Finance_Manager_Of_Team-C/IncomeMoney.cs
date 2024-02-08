using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;

namespace Finance_Manager_Of_Team_C
{
    internal class IncomeMoney
    {
        public IncomeMoney()
        {
            Load();
        }

        // Method to add income
        public void AddIncome(DateTime date, double amount, string wallet, string category, string currency)
        {
            // Logic to add income to the list
            Array income = new Array(date, amount, wallet, category, currency);
            MoneyArr.Add(income);
        }

        // Method to delete income
        public void DeleteIncome(Array income)
        {
            // Logic to delete income from the list
            MoneyArr.Remove(income);
        }

        // Method to edit income
        public void EditIncome(Array income, DateTime newDate, double newAmount, string newWallet, string newCategory, string newCurrency)
        {
            // Logic to edit income in the list
            income.Date = newDate;
            income.Amount = newAmount;
            income.Wallet = newWallet;
            income.Category = newCategory;
            income.Currency = newCurrency;
        }

        // Method to retrieve income data within specified days
        public List<Array> GetMoneyWithinDays(DateTime day1, DateTime day2)
        {
            List<Array> result = MoneyArr.Where(income => income.Date >= day1 && income.Date <= day2).ToList();
            return result;
        }

        // Method to search for income by category
        public List<Array> SearchIncomeByCategory(string category)
        {
            List<Array> result = MoneyArr.Where(income => income.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            return result;
        }

        // List to store income data
        private List<Array> MoneyArr = new List<Array>();

        internal class Array
        {
            // Properties of income
            public DateTime Date { get; set; }
            public double Amount { get; set; }
            public string Wallet { get; set; }
            public string Category { get; set; }
            public string Currency { get; set; }

            // Constructor for income
            public Array(DateTime date, double amount, string wallet, string category, string currency)
            {
                Date = date;
                Amount = amount;
                Wallet = wallet;
                Category = category;
                Currency = currency;
            }
        }

        private void Load()
        {
            try
            {
                string filePath = "income_data.csv";

                if (File.Exists(filePath))
                {
                    using (var reader = new StreamReader(filePath))
                    using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
                    {
                        MoneyArr = csv.GetRecords<Array>().ToList();
                    }

                    Console.WriteLine("Data loaded successfully.");
                }
                else
                {
                    Console.WriteLine("No existing data found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }

        private void Save()
        {
            try
            {
                string filePath = "income_data.csv";
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
                {
                    csv.WriteRecords(MoneyArr);
                }

                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }
    }
}
