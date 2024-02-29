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
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButtonIncome = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            labelTime = new Label();
            panelTitleBar = new Panel();
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
            panelMenu.BackColor = Color.FromArgb(38, 41, 56);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(226, 651);
            panelMenu.TabIndex = 4;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 81);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += ElementIllumination_MouseEnter;
            pictureBox1.MouseLeave += ElementIllumination_MouseLeave;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButtonDomesticExpenses);
            panel2.Controls.Add(iconButtonUnplannedExpenses);
            panel2.Controls.Add(iconButtonSocialCosts);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 91);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 207);
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
            iconButtonDomesticExpenses.Location = new Point(0, 143);
            iconButtonDomesticExpenses.Name = "iconButtonDomesticExpenses";
            iconButtonDomesticExpenses.Padding = new Padding(10, 0, 21, 0);
            iconButtonDomesticExpenses.Size = new Size(231, 60);
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
            iconButtonUnplannedExpenses.Location = new Point(0, 83);
            iconButtonUnplannedExpenses.Name = "iconButtonUnplannedExpenses";
            iconButtonUnplannedExpenses.Padding = new Padding(10, 0, 21, 0);
            iconButtonUnplannedExpenses.Size = new Size(231, 60);
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
            iconButtonSocialCosts.Location = new Point(0, 23);
            iconButtonSocialCosts.Name = "iconButtonSocialCosts";
            iconButtonSocialCosts.Padding = new Padding(10, 0, 21, 0);
            iconButtonSocialCosts.Size = new Size(231, 60);
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
            label2.Size = new Size(92, 23);
            label2.TabIndex = 0;
            label2.Text = "EXPENCES";
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButtonIncome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 306);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 149);
            panel1.TabIndex = 1;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            iconButton2.ForeColor = SystemColors.ButtonHighlight;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 36;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 83);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 21, 0);
            iconButton2.Size = new Size(229, 60);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "WALLET";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
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
            iconButtonIncome.Location = new Point(0, 23);
            iconButtonIncome.Name = "iconButtonIncome";
            iconButtonIncome.Padding = new Padding(10, 0, 21, 0);
            iconButtonIncome.Size = new Size(229, 60);
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
            label1.Size = new Size(77, 23);
            label1.TabIndex = 0;
            label1.Text = "INCOME";
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTime.ForeColor = SystemColors.ButtonHighlight;
            labelTime.Location = new Point(1687, 940);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(86, 41);
            labelTime.TabIndex = 1;
            labelTime.Text = "Time";
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(38, 41, 56);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnExit);
            panelTitleBar.Controls.Add(label);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(226, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1014, 75);
            panelTitleBar.TabIndex = 5;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.FromArgb(37, 40, 55);
            btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
            btnMaximize.Location = new Point(931, 13);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(25, 26);
            btnMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMaximize.TabIndex = 3;
            btnMaximize.TabStop = false;
            btnMaximize.Click += btnMaximize_Click;
            btnMaximize.MouseEnter += ElementIllumination_MouseEnter;
            btnMaximize.MouseLeave += ElementIllumination_MouseLeave;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(37, 40, 55);
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(882, 11);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(29, 30);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 2;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            btnMinimize.MouseEnter += ElementIllumination_MouseEnter;
            btnMinimize.MouseLeave += ElementIllumination_MouseLeave;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(37, 40, 55);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(974, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(27, 28);
            btnExit.SizeMode = PictureBoxSizeMode.StretchImage;
            btnExit.TabIndex = 1;
            btnExit.TabStop = false;
            btnExit.Click += btnExit_Click;
            btnExit.MouseEnter += ElementIllumination_MouseEnter;
            btnExit.MouseLeave += ElementIllumination_MouseLeave;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.Location = new Point(56, 32);
            label.Name = "label";
            label.Size = new Size(61, 23);
            label.TabIndex = 1;
            label.Text = "HOME";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(37, 40, 55);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconCurrentChildForm.IconColor = Color.White;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 40;
            iconCurrentChildForm.Location = new Point(9, 21);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(40, 40);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(37, 40, 55);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(226, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1014, 9);
            panelShadow.TabIndex = 6;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(30, 28, 42);
            panelDesktop.Controls.Add(labelTime);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(226, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1014, 567);
            panelDesktop.TabIndex = 7;
            // 
            // FormFinance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 651);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private PictureBox btnMaximize;
        private PictureBox btnMinimize;
        private PictureBox btnExit;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label labelTime;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
