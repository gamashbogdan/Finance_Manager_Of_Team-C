using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Custom panel class with rounded corners and configurable gradient background
public class RoundedPanel : Panel
{
    // Properties for colors and angle
    public Color StartColor { get; set; }
    public Color EndColor { get; set; }
    public float Angle { get; set; }
    public int CornerRadius { get; set; }

    // Constructor to initialize properties
    public RoundedPanel()
    {
        // Set default values
        StartColor = Color.FromArgb(40, 50, 71);
        EndColor = Color.FromArgb(16, 110, 211);
        Angle = 230f;
        CornerRadius = 20;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Draw gradient background
        Rectangle gradientRect = new Rectangle(0, 0, this.Width, this.Height);
        using (LinearGradientBrush brush = new LinearGradientBrush(gradientRect, StartColor, EndColor, Angle))
        {
            e.Graphics.FillRectangle(brush, gradientRect);
        }

        // Draw rounded corners
        using (GraphicsPath path = new GraphicsPath())
        {
            int radius = CornerRadius; // Adjust the radius to change the roundness
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
