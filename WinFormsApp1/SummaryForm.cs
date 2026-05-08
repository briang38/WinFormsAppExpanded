#nullable disable
namespace WinFormsApp1
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            // Assign values from BillingForm to text boxes
            if (BillingForm.customerCountInteger > 0)
            {
                TotalSalesTextBox.Text = BillingForm.grandTotalDecimal.ToString("c");
                AverageSalesTextBox.Text = BillingForm.averageDecimal.ToString("c");
                NumberCustomersTextBox.Text = BillingForm.customerCountInteger.ToString();
            }
            else
            {
                TotalSalesTextBox.Text = "$0.00";
                AverageSalesTextBox.Text = "$0.00";
                NumberCustomersTextBox.Text = "0";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}