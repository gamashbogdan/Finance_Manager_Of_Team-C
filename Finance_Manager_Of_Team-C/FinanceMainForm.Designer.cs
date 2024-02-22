namespace Finance_Manager_Of_Team_C
{
    partial class FormFinance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinance));
            panelMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            iconButtonDomesticExpenses = new FontAwesome.Sharp.IconButton();
            iconButtonUnplannedExpenses = new FontAwesome.Sharp.IconButton();
            iconButtonSocialCosts = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButtonIncome = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            labelTime = new Label();
            panelTitleBar = new Panel();
            labelFinanceManager = new Label();
            btnMaximize = new PictureBox();
            btnMinimize = new PictureBox();
            btnExit = new PictureBox();
            label = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 40, 55);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(198, 488);
            panelMenu.TabIndex = 4;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(3, 2);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(192, 61);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButtonDomesticExpenses);
            panel2.Controls.Add(iconButtonUnplannedExpenses);
            panel2.Controls.Add(iconButtonSocialCosts);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 155);
            panel2.TabIndex = 6;
            // 
            // iconButtonDomesticExpenses
            // 
            iconButtonDomesticExpenses.Dock = DockStyle.Top;
            iconButtonDomesticExpenses.FlatAppearance.BorderSize = 0;
            iconButtonDomesticExpenses.FlatStyle = FlatStyle.Flat;
            iconButtonDomesticExpenses.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            iconButtonDomesticExpenses.ForeColor = SystemColors.ButtonHighlight;
            iconButtonDomesticExpenses.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            iconButtonDomesticExpenses.IconColor = Color.White;
            iconButtonDomesticExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDomesticExpenses.IconSize = 36;
            iconButtonDomesticExpenses.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDomesticExpenses.Location = new Point(0, 107);
            iconButtonDomesticExpenses.Margin = new Padding(3, 2, 3, 2);
            iconButtonDomesticExpenses.Name = "iconButtonDomesticExpenses";
            iconButtonDomesticExpenses.Padding = new Padding(9, 0, 18, 0);
            iconButtonDomesticExpenses.Size = new Size(202, 45);
            iconButtonDomesticExpenses.TabIndex = 2;
            iconButtonDomesticExpenses.Text = "DOMESTIC";
            iconButtonDomesticExpenses.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDomesticExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDomesticExpenses.UseVisualStyleBackColor = true;
            iconButtonDomesticExpenses.Click += iconButtonDomesticExpenses_Click;
            // 
            // iconButtonUnplannedExpenses
            // 
            iconButtonUnplannedExpenses.Dock = DockStyle.Top;
            iconButtonUnplannedExpenses.FlatAppearance.BorderSize = 0;
            iconButtonUnplannedExpenses.FlatStyle = FlatStyle.Flat;
            iconButtonUnplannedExpenses.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            iconButtonUnplannedExpenses.ForeColor = SystemColors.ButtonHighlight;
            iconButtonUnplannedExpenses.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            iconButtonUnplannedExpenses.IconColor = Color.White;
            iconButtonUnplannedExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUnplannedExpenses.IconSize = 36;
            iconButtonUnplannedExpenses.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonUnplannedExpenses.Location = new Point(0, 62);
            iconButtonUnplannedExpenses.Margin = new Padding(3, 2, 3, 2);
            iconButtonUnplannedExpenses.Name = "iconButtonUnplannedExpenses";
            iconButtonUnplannedExpenses.Padding = new Padding(9, 0, 18, 0);
            iconButtonUnplannedExpenses.Size = new Size(202, 45);
            iconButtonUnplannedExpenses.TabIndex = 4;
            iconButtonUnplannedExpenses.Text = "UNPLANNED";
            iconButtonUnplannedExpenses.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonUnplannedExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonUnplannedExpenses.UseVisualStyleBackColor = true;
            iconButtonUnplannedExpenses.Click += iconButtonUnplannedExpenses_Click;
            // 
            // iconButtonSocialCosts
            // 
            iconButtonSocialCosts.Dock = DockStyle.Top;
            iconButtonSocialCosts.FlatAppearance.BorderSize = 0;
            iconButtonSocialCosts.FlatStyle = FlatStyle.Flat;
            iconButtonSocialCosts.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            iconButtonSocialCosts.ForeColor = SystemColors.ButtonHighlight;
            iconButtonSocialCosts.IconChar = FontAwesome.Sharp.IconChar.GroupArrowsRotate;
            iconButtonSocialCosts.IconColor = Color.White;
            iconButtonSocialCosts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSocialCosts.IconSize = 36;
            iconButtonSocialCosts.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSocialCosts.Location = new Point(0, 17);
            iconButtonSocialCosts.Margin = new Padding(3, 2, 3, 2);
            iconButtonSocialCosts.Name = "iconButtonSocialCosts";
            iconButtonSocialCosts.Padding = new Padding(9, 0, 18, 0);
            iconButtonSocialCosts.Size = new Size(202, 45);
            iconButtonSocialCosts.TabIndex = 3;
            iconButtonSocialCosts.Text = "SOCIAL";
            iconButtonSocialCosts.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonSocialCosts.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSocialCosts.UseVisualStyleBackColor = true;
            iconButtonSocialCosts.Click += iconButtonSocialCosts_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 17);
            label2.TabIndex = 0;
            label2.Text = "EXPENCES";
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(iconButtonIncome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 229);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 112);
            panel1.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            iconButton1.ForeColor = SystemColors.ButtonHighlight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Microsoft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 36;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 62);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(9, 0, 18, 0);
            iconButton1.Size = new Size(200, 45);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "WALLETS";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButtonIncome
            // 
            iconButtonIncome.Dock = DockStyle.Top;
            iconButtonIncome.FlatAppearance.BorderSize = 0;
            iconButtonIncome.FlatStyle = FlatStyle.Flat;
            iconButtonIncome.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            iconButtonIncome.ForeColor = SystemColors.ButtonHighlight;
            iconButtonIncome.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconButtonIncome.IconColor = Color.White;
            iconButtonIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonIncome.IconSize = 36;
            iconButtonIncome.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonIncome.Location = new Point(0, 17);
            iconButtonIncome.Margin = new Padding(3, 2, 3, 2);
            iconButtonIncome.Name = "iconButtonIncome";
            iconButtonIncome.Padding = new Padding(9, 0, 18, 0);
            iconButtonIncome.Size = new Size(200, 45);
            iconButtonIncome.TabIndex = 1;
            iconButtonIncome.Text = "SOURCE";
            iconButtonIncome.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonIncome.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonIncome.UseVisualStyleBackColor = true;
            iconButtonIncome.Click += iconButtonIncome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 0;
            label1.Text = "INCOME";
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTime.ForeColor = SystemColors.ButtonHighlight;
            labelTime.Location = new Point(789, 380);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(67, 32);
            labelTime.TabIndex = 1;
            labelTime.Text = "Time";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(37, 40, 55);
            panelTitleBar.Controls.Add(labelFinanceManager);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(label);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(198, 0);
            panelTitleBar.Margin = new Padding(3, 2, 3, 2);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(887, 56);
            panelTitleBar.TabIndex = 5;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // labelFinanceManager
            // 
            labelFinanceManager.Anchor = AnchorStyles.Top;
            labelFinanceManager.Font = new Font("Nirmala UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFinanceManager.ForeColor = SystemColors.ControlLightLight;
            labelFinanceManager.Location = new Point(286, 9);
            labelFinanceManager.Name = "labelFinanceManager";
            labelFinanceManager.Size = new Size(306, 40);
            labelFinanceManager.TabIndex = 0;
            labelFinanceManager.Text = "FINANCE MANAGER";
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(37, 40, 55);
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(815, 10);
            btnMaximize.Margin = new Padding(3, 2, 3, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(20, 21);
            btnMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(37, 40, 55);
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(772, 8);
            btnMinimize.Margin = new Padding(3, 2, 3, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(28, 28);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(37, 40, 55);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(852, 9);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(21, 22);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 1;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Location = new Point(49, 27);
            label.Name = "label";
            label.Size = new Size(45, 17);
            label.TabIndex = 1;
            label.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(37, 40, 55);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 30;
            iconCurrentChildForm.Location = new Point(8, 16);
            iconCurrentChildForm.Margin = new Padding(3, 2, 3, 2);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(35, 30);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(37, 40, 55);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(198, 56);
            panelShadow.Margin = new Padding(3, 2, 3, 2);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(887, 7);
            panelShadow.TabIndex = 6;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(30, 28, 42);
            panelDesktop.Controls.Add(labelTime);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(198, 63);
            panelDesktop.Margin = new Padding(3, 2, 3, 2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(887, 425);
            panelDesktop.TabIndex = 7;
            // 
            // FormFinance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 488);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormFinance";
            Text = "Finance Manager";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonIncome;
        private FontAwesome.Sharp.IconButton iconButtonDomesticExpenses;
        private FontAwesome.Sharp.IconButton iconButtonSocialCosts;
        private FontAwesome.Sharp.IconButton iconButtonUnplannedExpenses;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label label;
        private Panel panelShadow;
        private Panel panelDesktop;
        private Label labelFinanceManager;
        private PictureBox btnMaximize;
        private PictureBox btnMinimize;
        private PictureBox btnExit;
        private Label labelTime;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
    }
}
