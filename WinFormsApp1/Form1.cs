#nullable disable
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class BillingForm : Form
    {
        // Declare module level variables for summary information
        private decimal subtotalDecimal, totalDecimal;

        // Global variables accessible by SummaryForm
        public static decimal grandTotalDecimal;
        public static decimal averageDecimal;
        public static int customerCountInteger;

        // Declare Constants
        const decimal TAX_RATE_Decimal = 0.08m;
        const decimal CAPPUCCINO_PRICE_Decimal = 2.00m;
        const decimal ESPRESSO_PRICE_Decimal = 2.25m;
        const decimal LATTE_PRICE_Decimal = 1.75m;
        const decimal ICED_PRICE_Decimal = 2.50m;

        public BillingForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal priceDecimal = 0, taxDecimal = 0, itemAmountDecimal = 0;
            int quantityInteger = 0;

            // Find the price
            if (CappuccinoRadioButton.Checked)
                priceDecimal = CAPPUCCINO_PRICE_Decimal;
            else if (EspressoRadioButton.Checked)
                priceDecimal = ESPRESSO_PRICE_Decimal;
            else if (LatteRadioButton.Checked)
                priceDecimal = LATTE_PRICE_Decimal;
            else if (IcedCappuccinoRadioButton.Checked || IcedLatteRadioButton.Checked)
                priceDecimal = ICED_PRICE_Decimal;

            try
            {
                quantityInteger = int.Parse(QuantityTextBox.Text);
                itemAmountDecimal = priceDecimal * quantityInteger;
                subtotalDecimal += itemAmountDecimal;

                if (TaxCheckBox.Checked)
                    taxDecimal = FindTax(subtotalDecimal);
                else
                    taxDecimal = 0;

                totalDecimal = subtotalDecimal + taxDecimal;

                // Display Text Boxes
                ItemAmountTextBox.Text = itemAmountDecimal.ToString("c");
                SubTotalTextBox.Text = subtotalDecimal.ToString("n");
                TaxTextBox.Text = taxDecimal.ToString("n");
                TotalTextBox.Text = totalDecimal.ToString("c");

                // Allow change for new order only
                TaxCheckBox.Enabled = false;

                // Allow Clear after an order is began
                ClearButton.Enabled = true;
                ClearItemToolStripMenuItem.Enabled = true;
                NewOrderToolStripMenuItem.Enabled = true;
            }
            catch (FormatException QuantityException)
            {
                MessageBox.Show("Quantity must be numeric.", "Data entry error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                QuantityTextBox.Focus();
                QuantityTextBox.SelectAll();
            }
        }

        // Function Calculate Tax
        private decimal FindTax(decimal amountDecimal)
        {
            return amountDecimal * TAX_RATE_Decimal;
        }

        // Clear Button Operations
        private void ClearButton_Click(object sender, EventArgs e)
        {
            CappuccinoRadioButton.Checked = true;
            ItemAmountTextBox.Clear();
            QuantityTextBox.Clear();
            QuantityTextBox.Focus();
        }

        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult responseDialogResult;
            string messageString;

            // Clear form of the current order
            messageString = "Clear the current order figures?";
            responseDialogResult = MessageBox.Show(messageString, "Clear Order",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            // If Yes, clear the input fields
            if (responseDialogResult == DialogResult.Yes)
            {
                ClearButton_Click(sender, e);
                SubTotalTextBox.Text = " ";
                TaxTextBox.Text = " ";
                TotalTextBox.Text = " ";

                // Add to the total only if not a new order/customer
                if (subtotalDecimal != 0)
                {
                    grandTotalDecimal += totalDecimal;
                    customerCountInteger += 1;

                    // Reset totals for the next customer
                    subtotalDecimal = 0;
                    totalDecimal = 0;
                }

                // Clear the appropriate display items and enable the check box
                TaxCheckBox.Enabled = true;
                TaxCheckBox.Checked = false;

                ClearButton.Enabled = false;
                ClearItemToolStripMenuItem.Enabled = false;
                NewOrderToolStripMenuItem.Enabled = false;
            }
        }

        // Calculate the average and display the totals
        private void SummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Make sure the last order is counted
            if (totalDecimal != 0)
                NewOrderToolStripMenuItem_Click(sender, e);

            // Calculate the average
            if (customerCountInteger > 0)
                averageDecimal = grandTotalDecimal / customerCountInteger;

            // Open the SummaryForm
            SummaryForm summaryForm = new SummaryForm();
            summaryForm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Terminate the Application
            this.Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the About Box form
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allow the user to select a new font for the summary totals
            fontDialog1.Font = SubTotalTextBox.Font;
            fontDialog1.ShowDialog();
            SubTotalTextBox.Font = fontDialog1.Font;
            TaxTextBox.Font = fontDialog1.Font;
            TotalTextBox.Font = fontDialog1.Font;
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allow the user to select a new color for the summary totals
            colorDialog1.Color = SubTotalTextBox.ForeColor;
            colorDialog1.ShowDialog();
            SubTotalTextBox.ForeColor = colorDialog1.Color;
            TaxTextBox.ForeColor = colorDialog1.Color;
            TotalTextBox.ForeColor = colorDialog1.Color;
        }

        private void CalculateSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateButton_Click(sender, e);
        }

        private void ClearItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearButton_Click(sender, e);
        }
    }
}