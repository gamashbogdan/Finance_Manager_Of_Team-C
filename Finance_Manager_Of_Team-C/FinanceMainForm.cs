namespace Finance_Manager_Of_Team_C
{
    public partial class FormFinance : Form
    {


       public FormFinance()
        {

            InitializeComponent();
        }

        private void buttonDomesticExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();

            DomesticExpensesForm domesticExpenses = new DomesticExpensesForm();
            domesticExpenses.Show();
        }

        private void buttonSocialCosts_Click(object sender, EventArgs e)
        {
            this.Hide();

            SocialCostsForm socialCosts = new SocialCostsForm();
            socialCosts.Show();
        }

        private void buttonUnplannedExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();

            UnplannedExpensesForm unplannedExpenses = new UnplannedExpensesForm();
            unplannedExpenses.Show();
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Income income = new Income();
            income.Show();
        }

       
    }
}
