namespace WinFormsApp1
{
    partial class SummaryForm
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
            TotalSalesTextBox = new TextBox();
            AverageSalesTextBox = new TextBox();
            NumberCustomersTextBox = new TextBox();
            CloseButton = new Button();
            Title = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 64);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Sales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 109);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Average Sales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 150);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 2;
            label3.Text = "Number of Customers";
            // 
            // TotalSalesTextBox
            // 
            TotalSalesTextBox.Location = new Point(201, 61);
            TotalSalesTextBox.Name = "TotalSalesTextBox";
            TotalSalesTextBox.ReadOnly = true;
            TotalSalesTextBox.Size = new Size(100, 23);
            TotalSalesTextBox.TabIndex = 3;
            TotalSalesTextBox.TabStop = false;
            // 
            // AverageSalesTextBox
            // 
            AverageSalesTextBox.Location = new Point(201, 106);
            AverageSalesTextBox.Name = "AverageSalesTextBox";
            AverageSalesTextBox.ReadOnly = true;
            AverageSalesTextBox.Size = new Size(100, 23);
            AverageSalesTextBox.TabIndex = 4;
            AverageSalesTextBox.TabStop = false;
            // 
            // NumberCustomersTextBox
            // 
            NumberCustomersTextBox.Location = new Point(201, 147);
            NumberCustomersTextBox.Name = "NumberCustomersTextBox";
            NumberCustomersTextBox.ReadOnly = true;
            NumberCustomersTextBox.Size = new Size(100, 23);
            NumberCustomersTextBox.TabIndex = 5;
            NumberCustomersTextBox.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(176, 211);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 6;
            CloseButton.Text = "&Close";
            CloseButton.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 18F);
            Title.Location = new Point(57, 9);
            Title.Name = "Title";
            Title.Size = new Size(257, 32);
            Title.TabIndex = 7;
            Title.Text = "R 'n R Billing Summary";
            // 
            // SummaryForm
            // 
            AcceptButton = CloseButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 259);
            Controls.Add(Title);
            Controls.Add(CloseButton);
            Controls.Add(NumberCustomersTextBox);
            Controls.Add(AverageSalesTextBox);
            Controls.Add(TotalSalesTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SummaryForm";
            Text = "R 'n R Billing Summary";
            Load += this.SummaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TotalSalesTextBox;
        private TextBox AverageSalesTextBox;
        private TextBox NumberCustomersTextBox;
        private Button CloseButton;
        private Label Title;
    }
}