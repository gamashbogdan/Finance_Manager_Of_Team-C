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
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Timer timer;

        public FormFinance()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            labelTime.Text = $"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}";
            timer.Start();

        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            labelTime.Text = $"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}";
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(95, 77, 221);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(3, currentBtn.Location.Y);
                leftBorderBtn.Visible = false;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                label.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
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
        private void iconButtonIncome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButtonDomesticExpenses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new DomesticExpensesForm());

        }

        private void iconButtonSocialCosts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new SocialCostsForm());

        }

        private void iconButtonUnplannedExpenses_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new UnplannedExpensesForm());

        }

        private void Reset()
        {
            DisableButton();
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            label.Text = "Home";
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            timer.Stop();
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
