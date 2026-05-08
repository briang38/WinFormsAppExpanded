namespace WinFormsApp1
{
    partial class BillingForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewOrderToolStripMenuItem = new ToolStripMenuItem();
            SummaryToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            CalculateSelectionToolStripMenuItem = new ToolStripMenuItem();
            ClearItemToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            FontToolStripMenuItem = new ToolStripMenuItem();
            ColorToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            CappuccinoRadioButton = new RadioButton();
            EspressoRadioButton = new RadioButton();
            LatteRadioButton = new RadioButton();
            IcedLatteRadioButton = new RadioButton();
            IcedCappuccinoRadioButton = new RadioButton();
            label1 = new Label();
            QuantityTextBox = new TextBox();
            TaxCheckBox = new CheckBox();
            CalculateButton = new Button();
            ClearButton = new Button();
            label2 = new Label();
            ItemAmountTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SubTotalTextBox = new TextBox();
            TaxTextBox = new TextBox();
            TotalTextBox = new TextBox();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewOrderToolStripMenuItem, SummaryToolStripMenuItem, toolStripMenuItem1, ExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // NewOrderToolStripMenuItem
            // 
            NewOrderToolStripMenuItem.Name = "NewOrderToolStripMenuItem";
            NewOrderToolStripMenuItem.Size = new Size(131, 22);
            NewOrderToolStripMenuItem.Text = "&New Order";
            NewOrderToolStripMenuItem.Click += new EventHandler(this.NewOrderToolStripMenuItem_Click);
            // 
            // SummaryToolStripMenuItem
            // 
            SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem";
            SummaryToolStripMenuItem.Size = new Size(131, 22);
            SummaryToolStripMenuItem.Text = "&Summary";
            SummaryToolStripMenuItem.Click += new EventHandler(this.SummaryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(128, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(131, 22);
            ExitToolStripMenuItem.Text = "&Exit";
            ExitToolStripMenuItem.Click += new EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CalculateSelectionToolStripMenuItem, ClearItemToolStripMenuItem, toolStripMenuItem2, FontToolStripMenuItem, ColorToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // CalculateSelectionToolStripMenuItem
            // 
            CalculateSelectionToolStripMenuItem.Name = "CalculateSelectionToolStripMenuItem";
            CalculateSelectionToolStripMenuItem.Size = new Size(180, 22);
            CalculateSelectionToolStripMenuItem.Text = "&Calculate Selection";
            CalculateSelectionToolStripMenuItem.Click += new EventHandler(this.CalculateSelectionToolStripMenuItem_Click);
            // 
            // ClearItemToolStripMenuItem
            // 
            ClearItemToolStripMenuItem.Name = "ClearItemToolStripMenuItem";
            ClearItemToolStripMenuItem.Size = new Size(180, 22);
            ClearItemToolStripMenuItem.Text = "Clear &Item";
            ClearItemToolStripMenuItem.Click += new EventHandler(this.ClearItemToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 6);
            // 
            // FontToolStripMenuItem
            // 
            FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            FontToolStripMenuItem.Size = new Size(180, 22);
            FontToolStripMenuItem.Text = "&Font";
            FontToolStripMenuItem.Click += new EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // ColorToolStripMenuItem
            // 
            ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            ColorToolStripMenuItem.Size = new Size(180, 22);
            ColorToolStripMenuItem.Text = "C&olor";
            ColorToolStripMenuItem.Click += new EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(180, 22);
            AboutToolStripMenuItem.Text = "&About";
            AboutToolStripMenuItem.Click += new EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ItemAmountTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Controls.Add(CalculateButton);
            groupBox1.Controls.Add(TaxCheckBox);
            groupBox1.Controls.Add(QuantityTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 229);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(IcedCappuccinoRadioButton);
            groupBox2.Controls.Add(IcedLatteRadioButton);
            groupBox2.Controls.Add(LatteRadioButton);
            groupBox2.Controls.Add(EspressoRadioButton);
            groupBox2.Controls.Add(CappuccinoRadioButton);
            groupBox2.Location = new Point(431, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(339, 201);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Coffee Selections";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TotalTextBox);
            groupBox3.Controls.Add(TaxTextBox);
            groupBox3.Controls.Add(SubTotalTextBox);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(12, 262);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 163);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            // 
            // CappuccinoRadioButton
            // 
            CappuccinoRadioButton.AutoSize = true;
            CappuccinoRadioButton.Checked = true;
            CappuccinoRadioButton.Location = new Point(19, 22);
            CappuccinoRadioButton.Name = "CappuccinoRadioButton";
            CappuccinoRadioButton.Size = new Size(89, 19);
            CappuccinoRadioButton.TabIndex = 4;
            CappuccinoRadioButton.TabStop = true;
            CappuccinoRadioButton.Text = "C&appuccino";
            CappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // EspressoRadioButton
            // 
            EspressoRadioButton.AutoSize = true;
            EspressoRadioButton.Location = new Point(19, 47);
            EspressoRadioButton.Name = "EspressoRadioButton";
            EspressoRadioButton.Size = new Size(70, 19);
            EspressoRadioButton.TabIndex = 5;
            EspressoRadioButton.TabStop = true;
            EspressoRadioButton.Text = "Espress&o";
            EspressoRadioButton.UseVisualStyleBackColor = true;
            // 
            // LatteRadioButton
            // 
            LatteRadioButton.AutoSize = true;
            LatteRadioButton.Location = new Point(19, 72);
            LatteRadioButton.Name = "LatteRadioButton";
            LatteRadioButton.Size = new Size(51, 19);
            LatteRadioButton.TabIndex = 6;
            LatteRadioButton.TabStop = true;
            LatteRadioButton.Text = "La&tte";
            LatteRadioButton.UseVisualStyleBackColor = true;
            // 
            // IcedLatteRadioButton
            // 
            IcedLatteRadioButton.AutoSize = true;
            IcedLatteRadioButton.Location = new Point(19, 97);
            IcedLatteRadioButton.Name = "IcedLatteRadioButton";
            IcedLatteRadioButton.Size = new Size(79, 19);
            IcedLatteRadioButton.TabIndex = 7;
            IcedLatteRadioButton.TabStop = true;
            IcedLatteRadioButton.Text = "&Iced Latte";
            IcedLatteRadioButton.UseVisualStyleBackColor = true;
            // 
            // IcedCappuccinoRadioButton
            // 
            IcedCappuccinoRadioButton.AutoSize = true;
            IcedCappuccinoRadioButton.Location = new Point(19, 122);
            IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton";
            IcedCappuccinoRadioButton.Size = new Size(114, 19);
            IcedCappuccinoRadioButton.TabIndex = 8;
            IcedCappuccinoRadioButton.TabStop = true;
            IcedCappuccinoRadioButton.Text = "Iced Ca&ppuccino";
            IcedCappuccinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 4;
            label1.Text = "&Quantity";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(90, 21);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(100, 23);
            QuantityTextBox.TabIndex = 5;
            // 
            // TaxCheckBox
            // 
            TaxCheckBox.AutoSize = true;
            TaxCheckBox.Location = new Point(21, 59);
            TaxCheckBox.Name = "TaxCheckBox";
            TaxCheckBox.Size = new Size(73, 19);
            TaxCheckBox.TabIndex = 6;
            TaxCheckBox.Text = "Ta&keout?";
            TaxCheckBox.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(30, 94);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(96, 69);
            CalculateButton.TabIndex = 7;
            CalculateButton.Text = "&Calculate Selection";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += new EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            ClearButton.Enabled = false;
            ClearButton.Location = new Point(151, 94);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(106, 69);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "C&lear for Next Item";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += new EventHandler(this.ClearButton_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 186);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 9;
            label2.Text = "Item Amount";
            // 
            // ItemAmountTextBox
            // 
            ItemAmountTextBox.Location = new Point(109, 183);
            ItemAmountTextBox.Name = "ItemAmountTextBox";
            ItemAmountTextBox.ReadOnly = true;
            ItemAmountTextBox.Size = new Size(124, 23);
            ItemAmountTextBox.TabIndex = 10;
            ItemAmountTextBox.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 79);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 5;
            label3.Text = "Tax (if Takeout)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 125);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Total Due";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 34);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 7;
            label5.Text = "SubTotal";
            // 
            // SubTotalTextBox
            // 
            SubTotalTextBox.Location = new Point(114, 31);
            SubTotalTextBox.Name = "SubTotalTextBox";
            SubTotalTextBox.ReadOnly = true;
            SubTotalTextBox.Size = new Size(100, 23);
            SubTotalTextBox.TabIndex = 10;
            SubTotalTextBox.TabStop = false;
            // 
            // TaxTextBox
            // 
            TaxTextBox.Location = new Point(114, 76);
            TaxTextBox.Name = "TaxTextBox";
            TaxTextBox.ReadOnly = true;
            TaxTextBox.Size = new Size(100, 23);
            TaxTextBox.TabIndex = 11;
            TaxTextBox.TabStop = false;
            // 
            // TotalTextBox
            // 
            TotalTextBox.Location = new Point(114, 122);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.ReadOnly = true;
            TotalTextBox.Size = new Size(100, 23);
            TotalTextBox.TabIndex = 12;
            TotalTextBox.TabStop = false;
            // 
            // BillingForm
            // 
            AcceptButton = CalculateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BillingForm";
            Text = "R 'n R- Reading 'n Refreshment";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem NewOrderToolStripMenuItem;
        private ToolStripMenuItem SummaryToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem CalculateSelectionToolStripMenuItem;
        private ToolStripMenuItem ClearItemToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem FontToolStripMenuItem;
        private ToolStripMenuItem ColorToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton CappuccinoRadioButton;
        private RadioButton IcedCappuccinoRadioButton;
        private RadioButton IcedLatteRadioButton;
        private RadioButton LatteRadioButton;
        private RadioButton EspressoRadioButton;
        private Button ClearButton;
        private Button CalculateButton;
        private CheckBox TaxCheckBox;
        private TextBox QuantityTextBox;
        private Label label1;
        private Label label2;
        private TextBox ItemAmountTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TotalTextBox;
        private TextBox TaxTextBox;
        private TextBox SubTotalTextBox;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
    }
}