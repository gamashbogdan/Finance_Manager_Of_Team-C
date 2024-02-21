namespace Finance_Manager_Of_Team_C
{
    partial class DomesticExpensesForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            FruitCheck = new CheckBox();
            VegCheck = new CheckBox();
            DrinkCheck = new CheckBox();
            DessertCheck = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            FruitBox = new TextBox();
            VegBox = new TextBox();
            DrinkBox = new TextBox();
            DessertBox = new TextBox();
            FoodButton = new Button();
            MoneyLabel = new Label();
            backBtn = new Button();
            FoodSum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(384, 64);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 0;
            label1.Text = "Побутові витрати";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(161, 147);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Food";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(340, 146);
            label3.Name = "label3";
            label3.Size = new Size(266, 25);
            label3.TabIndex = 2;
            label3.Text = "Personal hygiene products:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(708, 146);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 3;
            label4.Text = "Sanitation:";
            // 
            // FruitCheck
            // 
            FruitCheck.AutoSize = true;
            FruitCheck.BackColor = Color.Transparent;
            FruitCheck.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            FruitCheck.ForeColor = Color.White;
            FruitCheck.Location = new Point(108, 201);
            FruitCheck.Margin = new Padding(3, 2, 3, 2);
            FruitCheck.Name = "FruitCheck";
            FruitCheck.Size = new Size(82, 21);
            FruitCheck.TabIndex = 4;
            FruitCheck.Text = "Фрукти";
            FruitCheck.UseVisualStyleBackColor = false;
            FruitCheck.CheckedChanged += FruitCheck_CheckedChanged;
            // 
            // VegCheck
            // 
            VegCheck.AutoSize = true;
            VegCheck.BackColor = Color.Transparent;
            VegCheck.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            VegCheck.ForeColor = Color.White;
            VegCheck.Location = new Point(108, 229);
            VegCheck.Margin = new Padding(3, 2, 3, 2);
            VegCheck.Name = "VegCheck";
            VegCheck.Size = new Size(69, 21);
            VegCheck.TabIndex = 5;
            VegCheck.Text = "Овочі";
            VegCheck.UseVisualStyleBackColor = false;
            VegCheck.CheckedChanged += VegCheck_CheckedChanged;
            // 
            // DrinkCheck
            // 
            DrinkCheck.AutoSize = true;
            DrinkCheck.BackColor = Color.Transparent;
            DrinkCheck.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            DrinkCheck.ForeColor = Color.White;
            DrinkCheck.Location = new Point(108, 255);
            DrinkCheck.Margin = new Padding(3, 2, 3, 2);
            DrinkCheck.Name = "DrinkCheck";
            DrinkCheck.Size = new Size(69, 21);
            DrinkCheck.TabIndex = 6;
            DrinkCheck.Text = "Напої";
            DrinkCheck.UseVisualStyleBackColor = false;
            DrinkCheck.CheckedChanged += DrinkCheck_CheckedChanged;
            // 
            // DessertCheck
            // 
            DessertCheck.AutoSize = true;
            DessertCheck.BackColor = Color.Transparent;
            DessertCheck.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            DessertCheck.ForeColor = Color.White;
            DessertCheck.Location = new Point(108, 281);
            DessertCheck.Margin = new Padding(3, 2, 3, 2);
            DessertCheck.Name = "DessertCheck";
            DessertCheck.Size = new Size(89, 21);
            DessertCheck.TabIndex = 7;
            DessertCheck.Text = "Десерти";
            DessertCheck.UseVisualStyleBackColor = false;
            DessertCheck.CheckedChanged += DessertCheck_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(197, 204);
            label5.Name = "label5";
            label5.Size = new Size(58, 17);
            label5.TabIndex = 8;
            label5.Text = "100 грн";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(197, 230);
            label6.Name = "label6";
            label6.Size = new Size(58, 17);
            label6.TabIndex = 9;
            label6.Text = "120 грн";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(197, 256);
            label7.Name = "label7";
            label7.Size = new Size(51, 17);
            label7.TabIndex = 10;
            label7.Text = "50 грн";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(197, 283);
            label8.Name = "label8";
            label8.Size = new Size(58, 17);
            label8.TabIndex = 11;
            label8.Text = "150 грн";
            // 
            // FruitBox
            // 
            FruitBox.Enabled = false;
            FruitBox.Location = new Point(264, 200);
            FruitBox.Margin = new Padding(3, 2, 3, 2);
            FruitBox.Name = "FruitBox";
            FruitBox.Size = new Size(54, 25);
            FruitBox.TabIndex = 12;
            FruitBox.TextChanged += FruitBox_TextChanged;
            // 
            // VegBox
            // 
            VegBox.Enabled = false;
            VegBox.Location = new Point(264, 229);
            VegBox.Margin = new Padding(3, 2, 3, 2);
            VegBox.Name = "VegBox";
            VegBox.Size = new Size(54, 25);
            VegBox.TabIndex = 13;
            VegBox.TextChanged += VegBox_TextChanged;
            // 
            // DrinkBox
            // 
            DrinkBox.Enabled = false;
            DrinkBox.Location = new Point(264, 256);
            DrinkBox.Margin = new Padding(3, 2, 3, 2);
            DrinkBox.Name = "DrinkBox";
            DrinkBox.Size = new Size(54, 25);
            DrinkBox.TabIndex = 14;
            DrinkBox.TextChanged += DrinkBox_TextChanged;
            // 
            // DessertBox
            // 
            DessertBox.Enabled = false;
            DessertBox.Location = new Point(264, 284);
            DessertBox.Margin = new Padding(3, 2, 3, 2);
            DessertBox.Name = "DessertBox";
            DessertBox.Size = new Size(54, 25);
            DessertBox.TabIndex = 15;
            DessertBox.TextChanged += DessertBox_TextChanged;
            // 
            // FoodButton
            // 
            FoodButton.BackColor = Color.FromArgb(37, 40, 55);
            FoodButton.FlatStyle = FlatStyle.Flat;
            FoodButton.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            FoodButton.ForeColor = Color.White;
            FoodButton.Location = new Point(351, 339);
            FoodButton.Margin = new Padding(3, 2, 3, 2);
            FoodButton.Name = "FoodButton";
            FoodButton.Size = new Size(255, 40);
            FoodButton.TabIndex = 16;
            FoodButton.Text = "Calculate";
            FoodButton.UseVisualStyleBackColor = false;
            FoodButton.Click += FoodButton_Click;
            // 
            // MoneyLabel
            // 
            MoneyLabel.AutoSize = true;
            MoneyLabel.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MoneyLabel.ForeColor = Color.FromArgb(0, 192, 0);
            MoneyLabel.Location = new Point(104, 64);
            MoneyLabel.Name = "MoneyLabel";
            MoneyLabel.Size = new Size(144, 18);
            MoneyLabel.TabIndex = 18;
            MoneyLabel.Text = "Доступні кошти: -";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(36, 39, 54);
            backBtn.Dock = DockStyle.Bottom;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.White;
            backBtn.Location = new Point(0, 426);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(984, 35);
            backBtn.TabIndex = 19;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // FoodSum
            // 
            FoodSum.AutoSize = true;
            FoodSum.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            FoodSum.Location = new Point(634, 345);
            FoodSum.Name = "FoodSum";
            FoodSum.Size = new Size(64, 25);
            FoodSum.TabIndex = 20;
            FoodSum.Text = "Sum: ";
            // 
            // DomesticExpensesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 42);
            ClientSize = new Size(984, 461);
            Controls.Add(FoodSum);
            Controls.Add(backBtn);
            Controls.Add(MoneyLabel);
            Controls.Add(FoodButton);
            Controls.Add(DessertBox);
            Controls.Add(DrinkBox);
            Controls.Add(VegBox);
            Controls.Add(FruitBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DessertCheck);
            Controls.Add(DrinkCheck);
            Controls.Add(VegCheck);
            Controls.Add(FruitCheck);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "DomesticExpensesForm";
            Text = "Побутові витрати";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox FruitCheck;
        private CheckBox VegCheck;
        private CheckBox DrinkCheck;
        private CheckBox DessertCheck;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox FruitBox;
        private TextBox VegBox;
        private TextBox DrinkBox;
        private TextBox DessertBox;
        private Button FoodButton;
        private Label MoneyLabel;
        private Button backBtn;
        private Label FoodSum;
    }
}