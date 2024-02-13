using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Finance_Manager_Of_Team_C.Income_User_Control
{
    partial class UC_Wallet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            roundedPanel1 = new RoundedPanel();
            label3 = new Label();
            label4 = new Label();
            dataGridViewWallets = new DataGridView();
            roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWallets).BeginInit();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.Angle = 230F;
            roundedPanel1.BackColor = Color.FromArgb(16, 110, 211);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.EndColor = Color.FromArgb(16, 110, 211);
            roundedPanel1.Location = new Point(20, 20);
            roundedPanel1.Margin = new Padding(0);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(780, 99);
            roundedPanel1.StartColor = Color.FromArgb(40, 50, 71);
            roundedPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(20, 41);
            label3.Name = "label3";
            label3.Size = new Size(143, 37);
            label3.TabIndex = 1;
            label3.Text = "$ 1488.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 0;
            label4.Text = "Total Balance";
            // 
            // dataGridViewWallets
            // 
            dataGridViewWallets.AllowUserToResizeColumns = false;
            dataGridViewWallets.AllowUserToResizeRows = false;
            dataGridViewWallets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWallets.BackgroundColor = Color.FromArgb(37, 40, 55);
            dataGridViewWallets.BorderStyle = BorderStyle.None;
            dataGridViewWallets.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 110, 211);
            dataGridViewCellStyle1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewWallets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewWallets.ColumnHeadersHeight = 40;
            dataGridViewWallets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewWallets.EnableHeadersVisualStyles = false;
            dataGridViewWallets.GridColor = Color.Black;
            dataGridViewWallets.Location = new Point(20, 146);
            dataGridViewWallets.Name = "dataGridViewWallets";
            dataGridViewWallets.RowHeadersVisible = false;
            dataGridViewWallets.Size = new Size(780, 331);
            dataGridViewWallets.TabIndex = 3;
            // 
            // UC_Wallet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 28, 42);
            Controls.Add(dataGridViewWallets);
            Controls.Add(roundedPanel1);
            Margin = new Padding(0);
            Name = "UC_Wallet";
            Padding = new Padding(20);
            Size = new Size(823, 500);
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWallets).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RoundedPanel roundedPanel1;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewWallets;
    }

}
