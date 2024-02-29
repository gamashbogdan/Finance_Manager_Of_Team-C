using Finance_Manager_Of_Team_C.Income_User_Control;
using FontAwesome.Sharp;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Media;
using Color = System.Drawing.Color;
using Timer = System.Windows.Forms.Timer;
namespace Finance_Manager_Of_Team_C
{
    public partial class FormFinance : Form
    {
        private IconButton currentBtn;
        private Form currentChildForm;
        public FormFinance()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            OpenChildForm(new MainForm());

        }

        private void ElementIllumination_MouseEnter(object sender, EventArgs e)
        {
            // Приведення sender до типу Control
            Control control = (sender as Control)!;
            if (control != null)
            {
                control.BackColor = Color.LightGray; // Використовуйте світло-сірий колір для підсвічування
            }
        }

        private void ElementIllumination_MouseLeave(object sender, EventArgs e)
        {
            // Приведення sender до типу Control
            Control control = (sender as Control)!;
            if (control != null)
            {
                control.BackColor = Color.FromArgb(37, 40, 55); // Поверніть до стандартного кольору фону контролів
            }
        }

        

        private struct RGBColors
        {
            // icon color
            public static Color colorIcon = Color.FromArgb(24, 161, 251);

            // background button color
            public static Color colorBtnBg = Color.FromArgb(56, 60, 75);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.colorBtnBg;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                label.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 40, 55);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
            }
        }


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Event handler for the iconButtonIncome (presumably used to open UC_Source)
        private void iconButtonIncome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorIcon);
            UC_Source uc1 = new UC_Source();
            OpenChildForm(new Income(uc1));
        }

        // wallet
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorIcon);
            UC_Wallet uc1 = new UC_Wallet();
            OpenChildForm(new Income(uc1));
        }

        private void iconButtonDomesticExpenses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorIcon);
            OpenChildForm(new DomesticExpensesForm());

        }

        private void iconButtonSocialCosts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorIcon);
            OpenChildForm(new SocialCostsForm());

        }

        private void iconButtonUnplannedExpenses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorIcon);
            OpenChildForm(new UnplannedExpensesForm());

        }

        // home 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
            OpenChildForm(new MainForm());
        }


        private void Reset()
        {
            DisableButton();
            OpenChildForm(new MainForm());
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            label.Text = "HOME";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
