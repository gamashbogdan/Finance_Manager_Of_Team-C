using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C
{
    public partial class SocialCostsForm : Form
    {
        public SocialCostsForm()
        {
            InitializeComponent();
        }

        private void SocialCostsBtn_Click(object sender, EventArgs e)
        {
            double totalSum = 0;


            if (!string.IsNullOrWhiteSpace(PayInetTb.Text))
            {
                string inetCostText = PayInetTb.Text.Replace(".", ",");
                if (double.TryParse(inetCostText, out double inetCost))
                {
                    totalSum += inetCost;
                }
                else
                {
                    MessageBox.Show("Invalid input in Internet costs textbox.", "Error");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(PayTransportTb.Text))
            {
                string transportCostText = PayTransportTb.Text.Replace(".", ",");
                if (double.TryParse(transportCostText, out double transportCost))
                {
                    totalSum += transportCost;
                }
                else
                {
                    MessageBox.Show("Invalid input in Transport costs textbox.", "Error");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(PayCommunicatTb.Text))
            {
                string communicatCostText = PayCommunicatTb.Text.Replace(".", ",");
                if (double.TryParse(communicatCostText, out double communicatCost))
                {
                    totalSum += communicatCost;
                }
                else
                {
                    MessageBox.Show("Invalid input in Communication costs textbox.", "Error");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(PayEducationTb.Text))
            {
                string educationCostText = PayEducationTb.Text.Replace(".", ",");
                if (double.TryParse(educationCostText, out double educationCost))
                {
                    totalSum += educationCost;
                }
                else
                {
                    MessageBox.Show("Invalid input in Education costs textbox.", "Error");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(PayComunalTb.Text))
            {
                string comunalCostText = PayComunalTb.Text.Replace(".", ",");
                if (double.TryParse(comunalCostText, out double comunalCost))
                {
                    totalSum += comunalCost;
                }
                else
                {
                    MessageBox.Show("Invalid input in Utilities costs textbox.", "Error");
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(PayAnotherTb.Text))
            {
                string anotherCostText = PayAnotherTb.Text.Replace(".", ",");
                if (double.TryParse(anotherCostText, out double anotherCost))
                {
                    totalSum += anotherCost;
                }
                else
                {
                    MessageBox.Show("Invalid input in Other costs textbox.", "Error");
                    return;
                }
            }


            PayAllSocialTb.Text = totalSum.ToString();
            SocialData.Many = totalSum;
            SocialData.Date = DateTime.Now;
            MessageBox.Show($"Total sum Social Costs: {totalSum}", "Total Sum UAH");
        }

       
    }
}
