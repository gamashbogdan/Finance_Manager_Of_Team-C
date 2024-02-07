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

        private void ChangeButtonProperties(Button btn)
        {
            navPln.Location = btn.Location;
            DefaultButtonColor();
            btn.BackColor = Color.FromArgb(30, 36, 60);
        }

        private void DefaultButtonColor()
        {
            WalletBtn.BackColor = Color.FromArgb(24, 30, 54);
            SourceBtn.BackColor = Color.FromArgb(24, 30, 54);
            DashboardBtn.BackColor = Color.FromArgb(24, 30, 54);
            settingBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void WalletBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(WalletBtn);
        }

        private void SourceBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(SourceBtn);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(DashboardBtn);
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            ChangeButtonProperties(settingBtn);
        }

        private void Income_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
