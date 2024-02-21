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
            btnHome = new PictureBox();
            iconButtonIncome = new FontAwesome.Sharp.IconButton();
            iconButtonDomesticExpenses = new FontAwesome.Sharp.IconButton();
            iconButtonSocialCosts = new FontAwesome.Sharp.IconButton();
            iconButtonUnplannedExpenses = new FontAwesome.Sharp.IconButton();
            labelTime = new Label();
            panelTitleBar = new Panel();
            btnMaximize = new PictureBox();
            btnMinimize = new PictureBox();
            btnExit = new PictureBox();
            label = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            labelFinanceManager = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
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
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(iconButtonIncome);
            panelMenu.Controls.Add(iconButtonDomesticExpenses);
            panelMenu.Controls.Add(iconButtonSocialCosts);
            panelMenu.Controls.Add(iconButtonUnplannedExpenses);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(226, 648);
            panelMenu.TabIndex = 4;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(32, 9);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(142, 111);
            btnHome.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // iconButtonIncome
            // 
            iconButtonIncome.Dock = DockStyle.Top;
            iconButtonIncome.FlatAppearance.BorderSize = 0;
            iconButtonIncome.FlatStyle = FlatStyle.Flat;
            iconButtonIncome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            iconButtonIncome.ForeColor = SystemColors.ButtonHighlight;
            iconButtonIncome.IconChar = FontAwesome.Sharp.IconChar.I;
            iconButtonIncome.IconColor = Color.White;
            iconButtonIncome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonIncome.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonIncome.Location = new Point(3, 149);
            iconButtonIncome.Name = "iconButtonIncome";
            iconButtonIncome.Padding = new Padding(10, 0, 20, 0);
            iconButtonIncome.Size = new Size(240, 60);
            iconButtonIncome.TabIndex = 1;
            iconButtonIncome.Text = "Income";
            iconButtonIncome.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonIncome.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonIncome.UseVisualStyleBackColor = true;
            iconButtonIncome.Click += iconButtonIncome_Click;
            // 
            // iconButtonDomesticExpenses
            // 
            iconButtonDomesticExpenses.Dock = DockStyle.Top;
            iconButtonDomesticExpenses.FlatAppearance.BorderSize = 0;
            iconButtonDomesticExpenses.FlatStyle = FlatStyle.Flat;
            iconButtonDomesticExpenses.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            iconButtonDomesticExpenses.ForeColor = SystemColors.ButtonHighlight;
            iconButtonDomesticExpenses.IconChar = FontAwesome.Sharp.IconChar.D;
            iconButtonDomesticExpenses.IconColor = Color.White;
            iconButtonDomesticExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDomesticExpenses.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonDomesticExpenses.Location = new Point(3, 215);
            iconButtonDomesticExpenses.Name = "iconButtonDomesticExpenses";
            iconButtonDomesticExpenses.Padding = new Padding(10, 0, 20, 0);
            iconButtonDomesticExpenses.Size = new Size(240, 60);
            iconButtonDomesticExpenses.TabIndex = 2;
            iconButtonDomesticExpenses.Text = "Domestic Expenses";
            iconButtonDomesticExpenses.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonDomesticExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonDomesticExpenses.UseVisualStyleBackColor = true;
            iconButtonDomesticExpenses.Click += iconButtonDomesticExpenses_Click;
            // 
            // iconButtonSocialCosts
            // 
            iconButtonSocialCosts.Dock = DockStyle.Top;
            iconButtonSocialCosts.FlatAppearance.BorderSize = 0;
            iconButtonSocialCosts.FlatStyle = FlatStyle.Flat;
            iconButtonSocialCosts.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            iconButtonSocialCosts.ForeColor = SystemColors.ButtonHighlight;
            iconButtonSocialCosts.IconChar = FontAwesome.Sharp.IconChar.S;
            iconButtonSocialCosts.IconColor = Color.White;
            iconButtonSocialCosts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSocialCosts.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSocialCosts.Location = new Point(3, 281);
            iconButtonSocialCosts.Name = "iconButtonSocialCosts";
            iconButtonSocialCosts.Padding = new Padding(10, 0, 20, 0);
            iconButtonSocialCosts.Size = new Size(240, 60);
            iconButtonSocialCosts.TabIndex = 3;
            iconButtonSocialCosts.Text = "Social Costs";
            iconButtonSocialCosts.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonSocialCosts.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSocialCosts.UseVisualStyleBackColor = true;
            iconButtonSocialCosts.Click += iconButtonSocialCosts_Click;
            // 
            // iconButtonUnplannedExpenses
            // 
            iconButtonUnplannedExpenses.Dock = DockStyle.Top;
            iconButtonUnplannedExpenses.FlatAppearance.BorderSize = 0;
            iconButtonUnplannedExpenses.FlatStyle = FlatStyle.Flat;
            iconButtonUnplannedExpenses.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            iconButtonUnplannedExpenses.ForeColor = SystemColors.ButtonHighlight;
            iconButtonUnplannedExpenses.IconChar = FontAwesome.Sharp.IconChar.U;
            iconButtonUnplannedExpenses.IconColor = Color.White;
            iconButtonUnplannedExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUnplannedExpenses.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonUnplannedExpenses.Location = new Point(3, 347);
            iconButtonUnplannedExpenses.Name = "iconButtonUnplannedExpenses";
            iconButtonUnplannedExpenses.Padding = new Padding(10, 0, 20, 0);
            iconButtonUnplannedExpenses.Size = new Size(240, 60);
            iconButtonUnplannedExpenses.TabIndex = 4;
            iconButtonUnplannedExpenses.Text = "Unplanned Expenses";
            iconButtonUnplannedExpenses.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonUnplannedExpenses.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonUnplannedExpenses.UseVisualStyleBackColor = true;
            iconButtonUnplannedExpenses.Click += iconButtonUnplannedExpenses_Click;
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTime.ForeColor = SystemColors.ButtonHighlight;
            labelTime.Location = new Point(904, 504);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(86, 41);
            labelTime.TabIndex = 1;
            labelTime.Text = "Time";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(label);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(226, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1016, 75);
            panelTitleBar.TabIndex = 5;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(26, 25, 62);
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(934, 13);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(23, 23);
            btnMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(26, 25, 62);
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(885, 10);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 32);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(26, 25, 62);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(976, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(24, 24);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 1;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.ForeColor = Color.White;
            label.Location = new Point(56, 36);
            label.Name = "label";
            label.Size = new Size(50, 20);
            label.TabIndex = 1;
            label.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildForm.ForeColor = Color.MediumPurple;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 40;
            iconCurrentChildForm.Location = new Point(9, 22);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(40, 40);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(226, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1016, 9);
            panelShadow.TabIndex = 6;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 33, 74);
            panelDesktop.Controls.Add(labelFinanceManager);
            panelDesktop.Controls.Add(labelTime);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(226, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1016, 564);
            panelDesktop.TabIndex = 7;
            // 
            // labelFinanceManager
            // 
            labelFinanceManager.Anchor = AnchorStyles.Top;
            labelFinanceManager.Font = new Font("Segoe UI Emoji", 22F, FontStyle.Bold);
            labelFinanceManager.ForeColor = SystemColors.ControlLightLight;
            labelFinanceManager.Location = new Point(365, 5);
            labelFinanceManager.Name = "labelFinanceManager";
            labelFinanceManager.Size = new Size(330, 54);
            labelFinanceManager.TabIndex = 0;
            labelFinanceManager.Text = "Finance Manager";
            // 
            SuspendLayout();
            // 
            // FormFinance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 648);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            ClientSize = new Size(800, 450);
            Name = "FormFinance";
            Text = "Finance Manager";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
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
        private PictureBox btnHome;
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
    }
}
