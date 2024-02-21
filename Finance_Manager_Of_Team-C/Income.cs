using Finance_Manager_Of_Team_C.Income_User_Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            OpenWalletWindow();
        }

      

        private void ChangeButtonProperties(Button btn)
        {
            navPln.Location = btn.Location;
            btn.BackColor = Color.FromArgb(40, 50, 71);

            Button[] buttons = { WalletBtn, SourceBtn, backBtn };
            foreach (Button button in buttons)
            {
                if (button != btn)
                    button.BackColor = Color.FromArgb(36, 39, 54);
            }
        }

        private void ChangeButtonAndAddUserControl<T>(Button btn) where T : UserControl, new()
        {
            ChangeButtonProperties(btn);
            T uc = new T();
            AddUserControl(uc);
        }

        private void SourceBtn_Click(object sender, EventArgs e) => ChangeButtonAndAddUserControl<UC_Source>((Button)sender);

        private void WalletBtn_Click(object sender, EventArgs e) => ChangeButtonAndAddUserControl<UC_Wallet>((Button)sender);

        private void AddUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
        }

       

        private void OpenWalletWindow()
        {
            WalletBtn_Click(WalletBtn, EventArgs.Empty);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormFinance form = new FormFinance();
            form.Show();
        }

       
    }
}
