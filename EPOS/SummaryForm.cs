using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EPOS
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }
        public void ShowSummary(int qty,decimal amount)
        {
            TotalTransactionsTextBox.Text = qty.ToString();
            TotalPizzaFeeTextBox.Text = amount.ToString();
            TotalAverageRevenueTextBox.Text = (amount / qty).ToString();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
