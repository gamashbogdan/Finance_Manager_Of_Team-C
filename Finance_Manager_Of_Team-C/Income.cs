﻿using Finance_Manager_Of_Team_C.Income_User_Control;
using Finance_Manager_Of_Team_C.IncomeWindows;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C
{
    public partial class Income : Form
    {
        //private WalletDataHandler walletDataHandler;
        //private UC_Wallet uc_Wallet;

        public Income()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            SetFormRoundedBorders();

            // Display the wallet user control
            //uc_Wallet = new UC_Wallet();
            //AddUserControl(uc_Wallet);
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

            Button[] buttons = { WalletBtn, SourceBtn, DashboardBtn, settingBtn, exitBtn, backBtn };
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

        private void dashboardBtn_Click(object sender, EventArgs e) => ChangeButtonAndAddUserControl<UC_Dashboard>(DashboardBtn);

        private void settingBtn_Click(object sender, EventArgs e) => ChangeButtonAndAddUserControl<UC_Settings>(settingBtn);

        private void AddUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // sava data to file from  class
                Application.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving income data: {ex.Message}");
            }
        }
    }
}