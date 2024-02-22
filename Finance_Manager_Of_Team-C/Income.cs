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
            SetFormRoundedBorders();
        }

        private void SetFormRoundedBorders()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


    
        private void AddUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
        }


    }
}
