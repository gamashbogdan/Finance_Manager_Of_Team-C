using Finance_Manager_Of_Team_C.Income_User_Control;


namespace Finance_Manager_Of_Team_C
{
    public partial class Income : Form
    {
        private UC_Wallet uc_Wallet;

        public Income()
        {
            InitializeComponent();
            InitializeComponents();

            // Open the wallet window automatically when the form is created
            OpenWalletWindow();
        }

        private void InitializeComponents()
        {
            SetFormRoundedBorders();
        }

        private void SetFormRoundedBorders()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private void ChangeButtonProperties(Button btn)
        {
            navPln.Location = btn.Location;
            btn.BackColor = Color.FromArgb(40, 50, 71);

            Button[] buttons = { WalletBtn, SourceBtn, exitBtn, backBtn };
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


        private void WalletBtn_Click(object sender, EventArgs e) => ChangeButtonAndAddUserControl<UC_Wallet>(WalletBtn);

        private void SourceBtn_Click(object sender, EventArgs e) => ChangeButtonAndAddUserControl<UC_Source>(SourceBtn);



        private void AddUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Method to open the wallet window
        private void OpenWalletWindow()
        {
            WalletBtn_Click(WalletBtn, EventArgs.Empty);
        }
    }
}
