using Finance_Manager_Of_Team_C.Income_User_Control;
using Finance_Manager_Of_Team_C.IncomeWindows;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C
{
    public partial class Income : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Income()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Income_Load(object sender, EventArgs e)
        {

        }

        private void ChangeButtonProperties(Button btn)
        {
            navPln.Location = btn.Location;
            DefaultButtonColor();
            btn.BackColor = Color.FromArgb(40, 50, 71);
        }

        private void DefaultButtonColor()
        {
            WalletBtn.BackColor = Color.FromArgb(36, 39, 54);
            SourceBtn.BackColor = Color.FromArgb(36, 39, 54);
            DashboardBtn.BackColor = Color.FromArgb(36, 39, 54);
            settingBtn.BackColor = Color.FromArgb(36, 39, 54);
            exitBtn.BackColor = Color.FromArgb(36, 39, 54);
            backBtn.BackColor = Color.FromArgb(36, 39, 54);
        }

        private void addUserControl(UserControl userControl)
        {
            //userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            //userControl.BringToFront();
        }

        private void WalletBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(WalletBtn);
            UC_Wallet uc = new UC_Wallet();
            addUserControl(uc);
        }

        private void SourceBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(SourceBtn);
            UC_Source uc = new UC_Source();
            addUserControl(uc);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(DashboardBtn);
            UC_Dashboard uc = new UC_Dashboard();
            addUserControl(uc);
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(settingBtn);
            UC_Settings uc = new UC_Settings();
            addUserControl(uc);
        }

        

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
