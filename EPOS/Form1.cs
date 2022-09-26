using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace EPOS
{
    public partial class Form1 : Form
    {
        const string OrderInfoFileName = "BookOrders.txt";
        const string PizzaStock_FileName = "PizzaStock_File.txt";
        // { "VEG-A-ROMA", "Mighty Meaty", "Pepperoni Passion", "Texas BBQ", "Vegi Supreme", "Buffalo Chicken", "Deluxe", "Hawaiian    ", "Meateor"... };
        string[] PizzaName;
        readonly static decimal[] PriceForSize7 = { 6m, 7m, 8m, 9m, 10m, 11m, 12m, 13m };
        //= { "Personal 7''", "Small 9.5''", "Medium 11.5''", "Large 13.5'',"Super Large 14.5''" };
        string[] PizzaSize;
        //declare orderPrice, subTotalOrderPrice to show selected pizza price after dispaly
        decimal orderPrice, subTotalOrderPrice;
        //declare the orderQuantity input in the OrderQuantityTextBox
        int orderQuantity;
        //declear the selected variables in list box
        string orderPizzaName, orderPizzaSize;
        int summaryTransactionQty = 0;
        decimal summaryAmount = 0;

        //PizzaName as rows, PizzaSize as cols
        readonly static decimal[,] PizzaSizeFee = { {5m, 10m, 15m, 20m, 25m},
                                                    {6m, 11m, 16m, 21m, 26m },
                                                    {7m, 12m, 17m, 22m,27m },
                                                    {8m, 13m, 18m, 23m,28m },
                                                    {9m, 14m, 19m, 24m, 29m},
                                                    {10m, 15m, 20m, 25m, 30m },
                                                    {11m, 16m, 21m, 26m, 31m },
                                                    {12m, 17m, 22m, 27m, 32m },
                                                    {13m, 18m, 23m, 28m, 33m },
                                                    {14m, 19m, 24m, 29m, 34m },
                                                    {15m, 20m, 25m, 30m, 35m },
                                                    {16m, 21m, 26m, 31m, 36m },
                                                    {17m, 22m, 27m, 32m, 37m }};

        //declear pizza stock 2D array
        int[,] pizzastock;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //read pizza name from listbox and declear as array
            PizzaName = new string[PizzaListBox.Items.Count];
            for (int i = 0; i < PizzaListBox.Items.Count; i++)
            {
                string item = PizzaListBox.Items[i].ToString();
                PizzaName[i] = item.Substring(0, item.IndexOf("\t"));
            }
            //read pizza size from listbox and declear as array
            PizzaSize = new string[SizeListBox.Items.Count];
            for (int i = 0; i < SizeListBox.Items.Count; i++)
            {
                string item = SizeListBox.Items[i].ToString();
                PizzaSize[i] = item.Substring(0, item.IndexOf("\t"));
            }

            //Declear pizzastock 2D array
            pizzastock = new int[PizzaName.Length, PizzaSize.Length];

            //use method GetPizzaStock
            GetPizzaStock();


            //redraw the color of selected element in listbox
            SizeListBox.DrawItem += new DrawItemEventHandler(drawLog);


        }
        private void drawLog(Object sender, DrawItemEventArgs e)
        {
            //if sizeListBox and SizeListBox are both selected
            if (SizeListBox.Items.Count > 0 && SizeListBox.Items.Count > e.Index)
            {

                if (e.Index < 0)
                { return; }
                Color foreColor = Color.Black;
                string str = SizeListBox.Items[e.Index].ToString();
                int nameIndex = PizzaListBox.SelectedIndex;
                if (nameIndex < 0)
                {//show default style when element is not selected.
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                    e.Graphics.DrawString(str, e.Font, new SolidBrush(foreColor), e.Bounds);
                    return;
                };
               
                if (pizzastock[nameIndex, e.Index] == 0)
                {//When stock is 0, set the forecolor to grey
                    foreColor = Color.Gray; }
                if (e.Index == SizeListBox.SelectedIndex)
                {//draw selected style
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 0, 120, 215)), e.Bounds);
                    e.Graphics.DrawString(str, e.Font, new SolidBrush(Color.White), e.Bounds);
                }
                else
                {//draw unselected style
                    e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Bounds);
                    e.Graphics.DrawString(str, e.Font, new SolidBrush(foreColor), e.Bounds);
                }
            }
        }

        private string GetPizzaStock()
        {
            string fileStr = "";
            try
            {
                //Declare a variable to hold stock info
                string stockInfo;

                //Declare a StreamReader variable
                StreamReader inputFile;
                //Open the file and get a StreamReader subject
                inputFile = File.OpenText(PizzaStock_FileName);
                int row = 0;
                int colum = 0;
                //Read file contents
                while (!inputFile.EndOfStream)
                {
                    colum = 0;
                    stockInfo = inputFile.ReadLine();
                    string[] rows = stockInfo.Split(',');
                    foreach (var item in rows)
                    {
                        pizzastock[row, colum] = int.Parse(item);
                        colum++;
                    }
                    row++;
                }
                //Close the file
                inputFile.Close();
            }
            catch (Exception)
            {
                //Dispaly an error message
                MessageBox.Show("Error occured");

            }
            return fileStr;
        }

        //delear PizzaNameIndex,SizeIndex
        int PizzaNameIndex = -1;
        int SizeIndex = -1;
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            this.Text = "Display selected pizza details";
            PizzaNameIndex = PizzaListBox.SelectedIndex;
            SizeIndex = SizeListBox.SelectedIndex;
            OrderQuantityTextBox.Text = "";
            SubTotalOrderTextBox.Text = "";

            
            if (PizzaNameIndex != -1)
            {
                if (SizeIndex != -1)
                {
                    //if all listboxes has been selected, excute below
                    orderPizzaName = PizzaName[PizzaNameIndex];
                    orderPizzaSize = PizzaSize[SizeIndex];
                    PizzaNameTextBox.Text = orderPizzaName;
                    PizzaSizeTextBox.Text = orderPizzaSize;


                    //locate the price in PizzaSizeFee 2D array and assign it to orderPrice
                    orderPrice = PizzaSizeFee[PizzaNameIndex, SizeIndex];

                    //display the orderPrice
                    OrderPriceTextBox.Text = Math.Round(orderPrice, 2).ToString("C", new CultureInfo("en-ie")); ;


                }
                else
                {
                    MessageBox.Show("Please select the size",
                            "Data select Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );
                }


            }
            else
            {
                MessageBox.Show("Please select the Pizza Name",
                                            "Data select Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
            }
        }



        private void OrderQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            //when numberic price input in the textbox, the sub-total price will be caculated and showed immediately.
            if (OrderQuantityTextBox.Text.Trim().Length == 0)
                return;

            try
            {
                orderQuantity = int.Parse(OrderQuantityTextBox.Text);
                if (orderQuantity == 0)
                {
                    MessageBox.Show("Please input the quantity greater than 0",
                    "Data input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                    return;
                }
                int currStock = pizzastock[PizzaNameIndex, SizeIndex];
                if (currStock < orderQuantity)
                {
                    MessageBox.Show("Please input the quantity greater than 0, the max stock is " + currStock,
                       "Data input Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                       );
                    OrderQuantityTextBox.Text = currStock.ToString();
                    orderQuantity = currStock;
                }

                //calculate the subTotalOrderPrice and show it in SubTotalOrderTextBox.
                subTotalOrderPrice = orderQuantity * orderPrice;
                SubTotalOrderTextBox.Text = Math.Round(subTotalOrderPrice, 2).ToString("C", new CultureInfo("en-ie"));
            }
            catch (Exception)
            {

                MessageBox.Show("Please input the numberic data of quantity",
                 "Data input Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error
                 );
                orderQuantity = 0;
                OrderQuantityTextBox.Text = "0";
                OrderQuantityTextBox.Focus();
                OrderQuantityTextBox.SelectAll();

            }

        }

        //declear a dictionary array named dicOrders
        Dictionary<string, string[]> dicOrders = new Dictionary<string, string[]>();

        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            this.Text = "Add to basket";
            //if orderQuantity>0, show the dialogBox and dispaly order details
            if (orderQuantity > 0)
            {
                DialogResult showSelection = MessageBox.Show("The Pizza you ordered is: " + orderPizzaName
                  + "\nThe Size is: " + orderPizzaSize
                  + "\nThe price is: " + OrderPriceTextBox.Text
                  + "\nThe quantity is: " + orderQuantity
                  + "\nThe Sub-total price is: " + SubTotalOrderTextBox.Text
                  + "\n\nPlease click OK to continue adding to order, or click Cancel to go back.",
                       "Order details",
                       MessageBoxButtons.OKCancel,
                       MessageBoxIcon.None);

                //if click "ok" in dialogBox, the order detals will be stored in array dicOrders 
                if (showSelection == DialogResult.OK)
                {
                    string key = Guid.NewGuid().ToString();
                    string[] orderInfo = new string[] { orderPizzaName, orderPizzaSize, orderPrice.ToString(), orderQuantity.ToString(), subTotalOrderPrice.ToString() };
                    dicOrders.Add(key, orderInfo);
                    DoClear();
                }

                //if click "cancel" , excute the method DoClear.
                else
                {
                    DoClear();
                }
            }
            else
            {
                MessageBox.Show("Please input a numberic quantity greater than 0",
                   "Data input Error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
            }


        }
        private void BookButton_Click(object sender, EventArgs e)
        {
            this.Text = "Booking details";
            //if there are order(s) in array dicOrders, excute below
            if (dicOrders.Count > 0)
            {
                string id = CreateID();
                string msg = "Transaction No.:"+id+"\n\n";
                decimal amount = 0;
                foreach (var item in dicOrders)
                {
                    //amout+=subTotalOrderPrice
                    amount += decimal.Parse(item.Value[4]);
                    //meg+= orderPizzaName + orderPizzaSize + orderPrice + orderQuantity + subTotalOrderPrice
                    msg += "" + item.Value[0] + " " + item.Value[1] + ":  " + "€" + item.Value[2] + "*" + item.Value[3] + " = €" + item.Value[4] + "\n";
                }

                //line feed , add "Total Price:€ amount"
                msg += "\nTotal Price: " + "€" + amount;
                DialogResult bookDetails = MessageBox.Show(msg,
                      "Book details",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.None);

                if (bookDetails == DialogResult.OK)
                {
                    //declear list bookOrderInfos, orderInfo
                    List<string> bookOrderInfos = new List<string>();
                    string orderInfo = "";
                    //if click "ok" in dialog, add transaction ID, date time, transaction longth in bookOrderInfos
                    bookOrderInfos.Add(id + "," + DateTime.Now.ToString("dd/MM/yyyy") + "," + dicOrders.Count+",(pizza type in one transaction)");
                    foreach (var item in dicOrders)
                    {
                        //convert pizzaName to index
                        int nameindex = Array.IndexOf(PizzaName, item.Value[0]);
                        //convert size to index
                        int sizeindex = Array.IndexOf(PizzaSize, item.Value[1]);
                        pizzastock[nameindex, sizeindex] -= int.Parse(item.Value[3]);
                        orderInfo = item.Value[0] + ", " + item.Value[1]+", €" + item.Value[2]+ ", " + item.Value[3] + ", €" + item.Value[4];
                        bookOrderInfos.Add(orderInfo);

                    }
                    summaryTransactionQty++;
                    summaryAmount += amount;
                    SaveOrderInfo(bookOrderInfos);
                    dicOrders.Clear();
                    DoClear();
                }
            }
            else
            {
                MessageBox.Show("Please add the selected pizza to basket first",
                  "Data process Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                  );
            }
        }
        private void SaveOrderInfo(List<string> bookOrderInfos)
        {
            StreamWriter outputFile;
            //Create a file
            outputFile = File.AppendText(OrderInfoFileName);

            //write the stock value to PizzaStock_File
            foreach (var item in bookOrderInfos)
            {
                outputFile.WriteLine(item);
            }

            //close the file
            outputFile.Close();
        }
        private string CreateID()
        {
            string UniqueTransactionNo = "";
            bool unique = false;
            Random TransactionRandom = new Random();
            do
            {
                //get an eight-character transaction number range from 10000000 to 99999999
                UniqueTransactionNo = TransactionRandom.Next(10000000, 99999999).ToString();

                string fileStr = GetFileStr();

                //If new tranction number is not conntains in "I4U_TransactionFile.txt", then unique is true
                if (!fileStr.Contains(UniqueTransactionNo + " "))
                {
                    unique = true;
                }


            } while (!unique);
            return UniqueTransactionNo;
        }
        private string GetFileStr()
        {
            string fileStr = "";
            try
            {
                //Declare a StreamReader variable
                StreamReader inputFile;
                //Open the file and get a StreamReader subject
                inputFile = File.OpenText(OrderInfoFileName);
                
                while (!inputFile.EndOfStream)
                {
                    fileStr += inputFile.ReadLine();
                }
                //Close the file
                inputFile.Close();
            }
            catch (Exception)
            {
                //Dispaly an error message
                MessageBox.Show("Error occured");

            }
            return fileStr;
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TransactionIdRadioButton.Checked == true)
                {
                    int code = 0;
                    if (!int.TryParse(SearchTextBox.Text, out code))
                    {
                        MessageBox.Show("Please input number transaction ID",
                           "Data input Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                           ); 
                        return;
                    }
                }
                else if(DataRadioButton.Checked == true)
                {
                    DateTime date = DateTime.MinValue;
                    if (!DateTime.TryParse(SearchTextBox.Text, out date))
                    {
                       
                        MessageBox.Show("Please input correct data type: DD/MM/YY ",
                           "Data input Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error
                           ); 
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a search type ",
                         "Data select Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error
                         );

                    return;
                }




                SearchListBox.Items.Clear();
                //Declare a StreamReader variable
                StreamReader inputFile;
                //Open the file and get a StreamReader subject
                inputFile = File.OpenText(OrderInfoFileName);
                
                bool hasFound = false;
                while (!inputFile.EndOfStream)
                {
                    string fileStr = inputFile.ReadLine();
                    string[] items = fileStr.Split(",");
                    if (TransactionIdRadioButton.Checked == true)
                    {
                        if (items[0].Contains(SearchTextBox.Text))
                        {
                            //if searchTextBox.text match with the Transaction ID, add below items in searchbox
                            hasFound = true;
                            SearchListBox.Items.Add("Transaction No.: " + items[0]);
                            SearchListBox.Items.Add("Date: " + items[1]);
                            int length = int.Parse(items[2]);
                            for (int i = 0; i < length; i++)
                            {
                                SearchListBox.Items.Add(inputFile.ReadLine());
                            }
                            SearchListBox.Items.Add("");

                        }
                    }
                    else
                    {
                        if (items[1].Contains(SearchTextBox.Text))
                        {
                            hasFound = true;
                            SearchListBox.Items.Add("Transaction No.: " + items[0]);
                            SearchListBox.Items.Add("Date: " + items[1]);
                            int length = int.Parse(items[2]);
                            for (int i = 0; i < length; i++)
                            {
                                SearchListBox.Items.Add(inputFile.ReadLine());
                            }
                            SearchListBox.Items.Add("");
                        }
                    }
                }
                //Close the file
                inputFile.Close();
                if (!hasFound)
                {
                    MessageBox.Show("Please input a valid value ",
                         "Not found",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information
                         );
                }
            }
            catch (Exception)
            {
                //Dispaly an error message
               
                MessageBox.Show("Please select the Transaction ID or Date first!",
                            "Data select Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                            );

            }
        }

        private void StockReportButton_Click(object sender, EventArgs e)
        {
            this.Text = "Show Stock Report";
            string[] pizzaStockReport = new string[PizzaName.Length * PizzaSize.Length + 1];
            pizzaStockReport[0] = "Name            \tSize           \tStock";
            int pizzaIndex = 1;
            for (int row = 0; row < pizzastock.GetLength(0); row++)
            {
                for (int col = 0; col < pizzastock.GetLength(1); col++)
                {
                    //add pizza name, size, stock into pizzaStockReport
                    pizzaStockReport[pizzaIndex] = PizzaName[row].PadRight(15, ' ') + "\t" + PizzaSize[col].PadRight(15, ' ') + "\t" + pizzastock[row, col];
                    pizzaIndex++;
                }

            }

            StockReportForm form = new StockReportForm();
            form.ShowStock(pizzaStockReport);
            form.ShowDialog();
        }

        private void CreateDailyReport()
        {
            if (!File.Exists(OrderInfoFileName)) return;
            //Declare a StreamReader variable
            StreamReader inputFile;
            //Open the file and get a StreamReader subject
            inputFile = File.OpenText(OrderInfoFileName);
            
            int totalQty = 0;
            decimal totalPrice = 0;
            Dictionary<string, decimal[]> reports = new Dictionary<string, decimal[]>();
            while (!inputFile.EndOfStream)
            {
                //declear fileStr,items
                string fileStr = inputFile.ReadLine();
                string[] items = fileStr.Split(",");

                if (items[1] == (DateTime.Now.ToString("dd/MM/yyyy")))
                {
                    int length = int.Parse(items[2]);
                    for (int i = 0; i < length; i++)
                    {
                        string[] tempInfos = inputFile.ReadLine().Split(",");
                        string goodsName = tempInfos[0] + " " + tempInfos[1];
                        decimal qty = decimal.Parse(tempInfos[3]);
                        //remove the currency symol for more convinient to calculate.
                        decimal price = decimal.Parse(tempInfos[2].Substring(2, tempInfos[2].Length - 2));
                        decimal amount = decimal.Parse(tempInfos[4].Substring(2, tempInfos[4].Length - 2));
                        if (reports.ContainsKey(goodsName))
                        {
                            reports[goodsName][0] += qty;
                            reports[goodsName][2] += amount;
                        }
                        else
                        {
                            reports.Add(goodsName, new decimal[] { qty, price, amount });
                        }
                        totalQty += (int)qty;
                        totalPrice += amount;
                    }
                }

            }
            //Close the file
            inputFile.Close();
            string fileNmae = "DailySalesReport" + DateTime.Now.ToString("ddMMyyyy") + ".txt";
            if (File.Exists(fileNmae))
                File.Delete(fileNmae);

            StreamWriter outputFile;
            //Create a file
            outputFile = File.AppendText(fileNmae);
            outputFile.WriteLine("Name".PadRight(48, ' ') + "\tQty\tPrice\tAmount");
            foreach (var item in reports)
            {
                outputFile.WriteLine(item.Key.PadRight(38, ' ') + "\t" + item.Value[0] + "\t€" + item.Value[1] + "\t€" + item.Value[2]);
            }
            foreach (var name in PizzaName)
            {
                foreach (var size in PizzaSize)
                {
                    string goodsName = name + " " + size;
                    if (reports.ContainsKey(name + " " + size))
                        continue;
                    outputFile.WriteLine(goodsName.PadRight(38, ' ') + "\t0\t0\t0");
                }
            }
            outputFile.WriteLine("\ntotalQty: " + totalQty);
            outputFile.WriteLine("totalAmount: " + totalPrice);
            //close the file
            outputFile.Close();
        }

        private void savePizzastock()
        {
            if (File.Exists(PizzaStock_FileName))
                File.Delete(PizzaStock_FileName);

            StreamWriter outputFile;
            //Create a file
            outputFile = File.AppendText(PizzaStock_FileName);

            //write the stock value to PizzaStock_File
            for (int row = 0; row < pizzastock.GetLength(0); row++)
            {
                string rowstr = "";
                for (int col = 0; col < pizzastock.GetLength(1); col++)
                {
                    rowstr += pizzastock[row, col] + ",";
                }
                outputFile.WriteLine(rowstr.TrimEnd(','));
            }

            //close the file
            outputFile.Close();

        }




        private void SizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SizeListBox.Refresh();
            PizzaNameIndex = PizzaListBox.SelectedIndex;
            SizeIndex = SizeListBox.SelectedIndex;
            if (PizzaNameIndex >= 0 && SizeIndex >= 0)
            {
                if (pizzastock[PizzaNameIndex, SizeIndex] == 0)
                    SizeListBox.SelectedIndex = -1;
            }

        }

        private void PizzaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SizeListBox.Refresh();
        }

        private void DoClear()
        {
            PizzaListBox.SelectedIndex = -1;
            SizeListBox.SelectedIndex = -1;
            orderQuantity = 0;
            foreach (var item in ProcessOrderGroupBox.Controls)
            {
                if (item is TextBox txt)
                {
                    txt.Text = "";
                }
            }

            foreach (Control ctr in SearchGroupBox.Controls)
            {
                if (ctr is ListBox list)
                {
                    list.Text = "";
                }
                if (ctr is TextBox txt)
                {
                    txt.Text = "";
                }
                if (ctr is RadioButton o)
                {
                    o.Checked = false;
                }
            }
        }

        private void SummaryButton_Click(object sender, EventArgs e)
        {
            this.Text = "Show Summary";
            if (summaryTransactionQty == 0)
            {
                MessageBox.Show("There is no Transaction right now, please make a booking first!",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information
                         );
                return;
            }
            SummaryForm form = new SummaryForm();
            form.ShowSummary(summaryTransactionQty, summaryAmount);
            form.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Text = "Clear data";
            DoClear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            CreateDailyReport();
            savePizzastock();
            this.Close();
        }
    }
}




