namespace Finance_Manager_Of_Team_C
{
    partial class Income
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            navPln = new Panel();
            DashboardBtn = new Button();
            settingBtn = new Button();
            SourceBtn = new Button();
            WalletBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            exitBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(navPln);
            panel1.Controls.Add(DashboardBtn);
            panel1.Controls.Add(settingBtn);
            panel1.Controls.Add(SourceBtn);
            panel1.Controls.Add(WalletBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 500);
            panel1.TabIndex = 6;
            // 
            // navPln
            // 
            navPln.BackColor = Color.MediumPurple;
            navPln.Location = new Point(0, 92);
            navPln.Name = "navPln";
            navPln.Size = new Size(5, 35);
            navPln.TabIndex = 7;
            // 
            // DashboardBtn
            // 
            DashboardBtn.BackColor = Color.FromArgb(24, 30, 54);
            DashboardBtn.Dock = DockStyle.Top;
            DashboardBtn.FlatAppearance.BorderSize = 0;
            DashboardBtn.FlatStyle = FlatStyle.Flat;
            DashboardBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardBtn.ForeColor = Color.MediumPurple;
            DashboardBtn.Location = new Point(0, 162);
            DashboardBtn.Name = "DashboardBtn";
            DashboardBtn.Size = new Size(177, 35);
            DashboardBtn.TabIndex = 8;
            DashboardBtn.Text = "DASHBOARD";
            DashboardBtn.UseVisualStyleBackColor = false;
            DashboardBtn.Click += dashboardBtn_Click;
            // 
            // settingBtn
            // 
            settingBtn.BackColor = Color.FromArgb(24, 30, 54);
            settingBtn.Dock = DockStyle.Bottom;
            settingBtn.FlatAppearance.BorderSize = 0;
            settingBtn.FlatStyle = FlatStyle.Flat;
            settingBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingBtn.ForeColor = Color.MediumPurple;
            settingBtn.Location = new Point(0, 465);
            settingBtn.Name = "settingBtn";
            settingBtn.Size = new Size(177, 35);
            settingBtn.TabIndex = 6;
            settingBtn.Text = "SETTINGS";
            settingBtn.UseVisualStyleBackColor = false;
            settingBtn.Click += settingBtn_Click;
            // 
            // SourceBtn
            // 
            SourceBtn.BackColor = Color.FromArgb(24, 30, 54);
            SourceBtn.Dock = DockStyle.Top;
            SourceBtn.FlatAppearance.BorderSize = 0;
            SourceBtn.FlatStyle = FlatStyle.Flat;
            SourceBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SourceBtn.ForeColor = Color.MediumPurple;
            SourceBtn.Location = new Point(0, 127);
            SourceBtn.Name = "SourceBtn";
            SourceBtn.Size = new Size(177, 35);
            SourceBtn.TabIndex = 5;
            SourceBtn.Text = "SOURCES";
            SourceBtn.UseVisualStyleBackColor = false;
            SourceBtn.Click += SourceBtn_Click;
            // 
            // WalletBtn
            // 
            WalletBtn.BackColor = Color.FromArgb(24, 30, 54);
            WalletBtn.Dock = DockStyle.Top;
            WalletBtn.FlatAppearance.BorderSize = 0;
            WalletBtn.FlatStyle = FlatStyle.Flat;
            WalletBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WalletBtn.ForeColor = Color.MediumPurple;
            WalletBtn.Location = new Point(0, 92);
            WalletBtn.Name = "WalletBtn";
            WalletBtn.Size = new Size(177, 35);
            WalletBtn.TabIndex = 4;
            WalletBtn.Text = "WALLET";
            WalletBtn.UseVisualStyleBackColor = false;
            WalletBtn.Click += WalletBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 34);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(42, 3);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "INCOME";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources._12095821;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.MediumPurple;
            exitBtn.Location = new Point(973, 0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(30, 30);
            exitBtn.TabIndex = 7;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1000, 500);
            Controls.Add(exitBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Income";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income";
            Load += Income_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button WalletBtn;
        private Button SourceBtn;
        private Button settingBtn;
        private Panel navPln;
        private Button DashboardBtn;
        private Button exitBtn;
    }
}