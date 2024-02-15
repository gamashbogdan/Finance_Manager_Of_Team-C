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
            SourceBtn = new Button();
            WalletBtn = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            exitBtn = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 40, 55);
            panel1.Controls.Add(navPln);
            panel1.Controls.Add(SourceBtn);
            panel1.Controls.Add(WalletBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(exitBtn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 500);
            panel1.TabIndex = 6;
            // 
            // navPln
            // 
            navPln.BackColor = Color.White;
            navPln.Location = new Point(0, 92);
            navPln.Name = "navPln";
            navPln.Size = new Size(5, 35);
            navPln.TabIndex = 7;
            // 
            // SourceBtn
            // 
            SourceBtn.BackColor = Color.FromArgb(36, 39, 54);
            SourceBtn.Dock = DockStyle.Top;
            SourceBtn.FlatAppearance.BorderSize = 0;
            SourceBtn.FlatStyle = FlatStyle.Flat;
            SourceBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SourceBtn.ForeColor = Color.White;
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
            WalletBtn.BackColor = Color.FromArgb(36, 39, 54);
            WalletBtn.Dock = DockStyle.Top;
            WalletBtn.FlatAppearance.BorderSize = 0;
            WalletBtn.FlatStyle = FlatStyle.Flat;
            WalletBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WalletBtn.ForeColor = Color.White;
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
            label1.ForeColor = Color.White;
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
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(36, 39, 54);
            backBtn.Dock = DockStyle.Bottom;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.White;
            backBtn.Location = new Point(0, 430);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(177, 35);
            backBtn.TabIndex = 9;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.FromArgb(36, 39, 54);
            exitBtn.Dock = DockStyle.Bottom;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(0, 465);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(177, 35);
            exitBtn.TabIndex = 10;
            exitBtn.Text = "EXIT";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += ExitBtn_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(30, 28, 42);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(177, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(823, 500);
            panelContainer.TabIndex = 8;
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1000, 500);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Income";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income";
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
        private Panel navPln;
        private Button backBtn;
        private Button exitBtn;
        private Panel panelContainer;
    }
}