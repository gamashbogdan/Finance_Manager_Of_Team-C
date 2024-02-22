namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    partial class UC_Source
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddFundsBtn = new Button();
            textBoxAmountOfMoney = new TextBox();
            label2 = new Label();
            comboBoxWallet = new ComboBox();
            label1 = new Label();
            comboBoxCategory = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBoxDescription = new TextBox();
            SuspendLayout();
            // 
            // AddFundsBtn
            // 
            AddFundsBtn.BackColor = Color.FromArgb(37, 40, 55);
            AddFundsBtn.FlatAppearance.BorderSize = 0;
            AddFundsBtn.FlatStyle = FlatStyle.Flat;
            AddFundsBtn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddFundsBtn.ForeColor = Color.White;
            AddFundsBtn.Location = new Point(115, 296);
            AddFundsBtn.Name = "AddFundsBtn";
            AddFundsBtn.Size = new Size(611, 47);
            AddFundsBtn.TabIndex = 0;
            AddFundsBtn.Text = "ADD FUNDS";
            AddFundsBtn.UseVisualStyleBackColor = false;
            AddFundsBtn.Click += AddFundsBtn_Click;
            // 
            // textBoxAmountOfMoney
            // 
            textBoxAmountOfMoney.Location = new Point(493, 216);
            textBoxAmountOfMoney.Name = "textBoxAmountOfMoney";
            textBoxAmountOfMoney.Size = new Size(229, 23);
            textBoxAmountOfMoney.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(493, 60);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 0;
            label2.Text = "Wallet";
            // 
            // comboBoxWallet
            // 
            comboBoxWallet.BackColor = Color.White;
            comboBoxWallet.FormattingEnabled = true;
            comboBoxWallet.Location = new Point(493, 102);
            comboBoxWallet.Name = "comboBoxWallet";
            comboBoxWallet.Size = new Size(229, 23);
            comboBoxWallet.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(115, 60);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.BackColor = Color.White;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(115, 102);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(229, 23);
            comboBoxCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(493, 176);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 0;
            label3.Text = "Amount Of Money";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(115, 176);
            label4.Name = "label4";
            label4.Size = new Size(98, 21);
            label4.TabIndex = 0;
            label4.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(115, 216);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(229, 23);
            textBoxDescription.TabIndex = 2;
            // 
            // UC_Source
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 42);
            Controls.Add(label4);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Controls.Add(label3);
            Controls.Add(textBoxAmountOfMoney);
            Controls.Add(label2);
            Controls.Add(comboBoxWallet);
            Controls.Add(AddFundsBtn);
            Name = "UC_Source";
            Size = new Size(887, 425);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddFundsBtn;
        private TextBox textBoxAmountOfMoney;
        private Label label2;
        private ComboBox comboBoxWallet;
        private Label label1;
        private ComboBox comboBoxCategory;
        private Label label3;
        private Label label4;
        private TextBox textBoxDescription;
    }
}
