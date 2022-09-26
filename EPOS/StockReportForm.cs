using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EPOS
{
    public partial class StockReportForm : Form
    {
        public StockReportForm()
        {
           
            InitializeComponent();
        }
        public void ShowStock(string[] pizzaStock)
        {
            foreach (var item in pizzaStock)
            {
                listBoxPizzaStock.Items.Add(item);
            }
            listBoxPizzaStock.SelectedIndex = 0;
          
        }
    }
}
