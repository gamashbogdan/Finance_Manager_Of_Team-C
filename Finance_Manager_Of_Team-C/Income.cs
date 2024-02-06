using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C
{
    public partial class Income : Form
    {

        public Income()
        {
            InitializeComponent();
        }

    }

    public class IncomeData
    {
        private readonly Dictionary<string, List<IncomeEntry>> incomeSources;

        public IncomeData()
        {
            incomeSources = new Dictionary<string, List<IncomeEntry>>();
        }

        public void AddIncomeSource(string sourceName)
        {
            if (!incomeSources.ContainsKey(sourceName))
            {
                incomeSources[sourceName] = new List<IncomeEntry>();
            }
            else
            {
                Console.WriteLine($"Income source '{sourceName}' already exists.");
            }
        }

        public void ChangeIncomeSourceName(string oldName, string newName)
        {
            if (incomeSources.ContainsKey(oldName))
            {
                incomeSources[newName] = incomeSources[oldName];
                incomeSources.Remove(oldName);
            }
            else
            {
                Console.WriteLine($"Income source '{oldName}' not found.");
            }
        }

        public void AddIncomeData(string sourceName, decimal amount, string description)
        {
            if (incomeSources.ContainsKey(sourceName))
            {
                incomeSources[sourceName].Add(new IncomeEntry(amount, description));
            }
            else
            {
                Console.WriteLine($"Income source '{sourceName}' not found.");
            }
        }

        public List<IncomeEntry> GetIncomeData(string sourceName)
        {
            if (incomeSources.ContainsKey(sourceName))
            {
                return incomeSources[sourceName];
            }
            else
            {
                Console.WriteLine($"Income source '{sourceName}' not found.");
                return null;
            }
        }

        public void RemoveIncomeSource(string sourceName)
        {
            if (incomeSources.ContainsKey(sourceName))
            {
                incomeSources.Remove(sourceName);
            }
            else
            {
                Console.WriteLine($"Income source '{sourceName}' not found.");
            }
        }

        public class IncomeEntry
        {
            public decimal Amount { get; }
            public string Description { get; }

            public IncomeEntry(decimal amount, string description)
            {
                Amount = amount;
                Description = description;
            }
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
