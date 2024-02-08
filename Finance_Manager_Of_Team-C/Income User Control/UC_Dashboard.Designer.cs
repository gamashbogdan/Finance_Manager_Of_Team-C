using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C.IncomeWindows
{
    partial class UC_Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 126, 255);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            panel1.Paint += new PaintEventHandler(panel1_Paint); // Handle the paint event to apply gradient
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Dashboard";
            Size = new Size(823, 500);
            ResumeLayout(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Apply gradient color to the panel
            Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);
            LinearGradientBrush brush = new LinearGradientBrush(rect, Color.FromArgb(1, 126, 255), Color.FromArgb(255, 255, 255), 45);
            e.Graphics.FillRectangle(brush, rect);
        }

        #endregion

        private Panel panel1;
    }
}
