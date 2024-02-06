using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C
{
    public partial class Income : Form
    {
        private readonly IncomeData incomeData;

        public Income()
        {
            InitializeComponent();
            incomeData = new IncomeData();
        }

        private void AddIncomeSourceBtn_Click(object sender, EventArgs e)
        {
            string newSourceName = Microsoft.VisualBasic.Interaction.InputBox("Enter new income source name:", "New Income Source");
            if (!string.IsNullOrEmpty(newSourceName))
            {
                incomeData.AddIncomeSource(newSourceName);
                IncomeSourceCmb.Items.Add(newSourceName);
                MessageBox.Show($"Income source '{newSourceName}' added successfully.");
            }
        }

        private void EditIncomeSourceBtn_Click(object sender, EventArgs e)
        {
            string selectedSource = IncomeSourceCmb.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedSource))
            {
                string newName = Microsoft.VisualBasic.Interaction.InputBox($"Enter new name for '{selectedSource}':", "Edit Income Source", selectedSource);
                if (!string.IsNullOrEmpty(newName) && newName != selectedSource)
                {
                    incomeData.ChangeIncomeSourceName(selectedSource, newName);
                    IncomeSourceCmb.Items[IncomeSourceCmb.SelectedIndex] = newName;
                    MessageBox.Show($"Income source '{selectedSource}' renamed to '{newName}' successfully.");
                }
            }
        }

        private void DeleteIncomeSourceBtn_Click(object sender, EventArgs e)
        {
            string selectedSource = IncomeSourceCmb.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedSource))
            {
                IncomeSourceCmb.Items.RemoveAt(IncomeSourceCmb.SelectedIndex);
                incomeData.RemoveIncomeSource(selectedSource);
                MessageBox.Show($"Income source '{selectedSource}' deleted successfully.");
            }
        }

        private void IncomeSourceCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Implement functionality to show income data for the selected source
            string selectedSource = IncomeSourceCmb.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedSource))
            {
                List<IncomeData.IncomeEntry> incomeEntries = incomeData.GetIncomeData(selectedSource);
                // Use the data to populate your UI elements or show in a grid
                // For example:
                // dataGridView.DataSource = incomeEntries;
            }
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
