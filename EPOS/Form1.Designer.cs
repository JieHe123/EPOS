
namespace EPOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PizzaListBox = new System.Windows.Forms.ListBox();
            this.SizeListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.ProcessOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PizzaSizeTextBox = new System.Windows.Forms.TextBox();
            this.PizzaNameLabel = new System.Windows.Forms.Label();
            this.PizzaNameTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalOrderTextBox = new System.Windows.Forms.TextBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.OrderQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoOfItemsLabel = new System.Windows.Forms.Label();
            this.OrderPriceTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.StockReportButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchListBox = new System.Windows.Forms.ListBox();
            this.DataRadioButton = new System.Windows.Forms.RadioButton();
            this.TransactionIdRadioButton = new System.Windows.Forms.RadioButton();
            this.DisplayToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddToOrderToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BookToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.StockReportToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SummaryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ItemsPanel.SuspendLayout();
            this.ProcessOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PizzaListBox
            // 
            this.PizzaListBox.ForeColor = System.Drawing.Color.Black;
            this.PizzaListBox.FormattingEnabled = true;
            this.PizzaListBox.ItemHeight = 25;
            this.PizzaListBox.Items.AddRange(new object[] {
            "VEG-A-ROMA\t€5 for Size 7\'\'\t (Cheese, Mushrooms, Onions, Herbs)\t",
            "Mighty Meaty\t€6 for Size 7\'\'\t (Cheese, Pepperoni, Ham, Mushroom, Onions)",
            "Pepperoni Passion\t€7 for Size 7\'\'\t (Cheese, Pepperoni)",
            "Texas BBQ\t€8 for Size 7\'\'\t (Chicken, Bacon, Onions, peppers)",
            "Vegi Supreme\t€9 for Size 7\'\'\t (Sweetcorn, Mushroom, Tomato, Onions)",
            "Buffalo Chicken\t€10 for Size 7\'\'\t (Cheese, Chicken, Pppers, Onions)",
            "Deluxe\t\t€11 for Size 7\'\'\t (Pepperoni, Mushrooms, Onions, Sausage)",
            "Hawaiian\t\t€12 for Size 7\'\'\t (Cheese, Ham, Pinapple, Mushroom)",
            "Meateor\t\t€13 for Size 7\'\'\t (Cheese, Bacon, Pork Meatballs, Ground Beef)",
            "Original Tomato\t€14 for Size 7\'\'\t (Cheese, Tomato)",
            "Hot & Spicy\t€15 for Size 7\'\'\t (Cheese, Ground Beef, Onions, Peppers)",
            "DELIGHT VEGI\t€16 for Size 7\'\'\t (Sweetcorn, Mushrooms, Onions, Peppers)",
            "American Hot\t€17 for Size 7\'\'\t (Pepperoni, Onions, Peppers)"});
            this.PizzaListBox.Location = new System.Drawing.Point(48, 66);
            this.PizzaListBox.Name = "PizzaListBox";
            this.PizzaListBox.Size = new System.Drawing.Size(706, 354);
            this.PizzaListBox.TabIndex = 0;
            this.PizzaListBox.SelectedIndexChanged += new System.EventHandler(this.PizzaListBox_SelectedIndexChanged);
            // 
            // SizeListBox
            // 
            this.SizeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SizeListBox.FormattingEnabled = true;
            this.SizeListBox.ItemHeight = 25;
            this.SizeListBox.Items.AddRange(new object[] {
            "Personal 7\'\'\t+€0",
            "Small 9.5\'\'\t+€5",
            "Medium 11.5\'\'\t+€10",
            "Large 13.5\'\' \t+€15",
            "Super Large 14.5\'\' \t+€20"});
            this.SizeListBox.Location = new System.Drawing.Point(957, 66);
            this.SizeListBox.Name = "SizeListBox";
            this.SizeListBox.Size = new System.Drawing.Size(289, 204);
            this.SizeListBox.TabIndex = 1;
            this.SizeListBox.SelectedIndexChanged += new System.EventHandler(this.SizeListBox_SelectedIndexChanged);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(48, 23);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(58, 25);
            this.ItemsLabel.TabIndex = 2;
            this.ItemsLabel.Text = "Pizza";
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.AddToOrderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddToOrderButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddToOrderButton.Location = new System.Drawing.Point(262, 17);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(158, 53);
            this.AddToOrderButton.TabIndex = 4;
            this.AddToOrderButton.Text = "&Add to basket";
            this.AddToOrderToolTip.SetToolTip(this.AddToOrderButton, "Support adding multiple times to basket.");
            this.AddToOrderButton.UseVisualStyleBackColor = false;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemsPanel.Controls.Add(this.SizeLabel);
            this.ItemsPanel.Controls.Add(this.PizzaListBox);
            this.ItemsPanel.Controls.Add(this.SizeListBox);
            this.ItemsPanel.Controls.Add(this.ItemsLabel);
            this.ItemsPanel.Location = new System.Drawing.Point(91, 184);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(1554, 448);
            this.ItemsPanel.TabIndex = 5;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SizeLabel.Location = new System.Drawing.Point(957, 23);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(47, 25);
            this.SizeLabel.TabIndex = 8;
            this.SizeLabel.Text = "Size";
            // 
            // ProcessOrderGroupBox
            // 
            this.ProcessOrderGroupBox.Controls.Add(this.label3);
            this.ProcessOrderGroupBox.Controls.Add(this.PizzaSizeTextBox);
            this.ProcessOrderGroupBox.Controls.Add(this.PizzaNameLabel);
            this.ProcessOrderGroupBox.Controls.Add(this.PizzaNameTextBox);
            this.ProcessOrderGroupBox.Controls.Add(this.SubTotalOrderTextBox);
            this.ProcessOrderGroupBox.Controls.Add(this.TotalPriceLabel);
            this.ProcessOrderGroupBox.Controls.Add(this.OrderQuantityTextBox);
            this.ProcessOrderGroupBox.Controls.Add(this.label1);
            this.ProcessOrderGroupBox.Controls.Add(this.NoOfItemsLabel);
            this.ProcessOrderGroupBox.Controls.Add(this.OrderPriceTextBox);
            this.ProcessOrderGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ProcessOrderGroupBox.Location = new System.Drawing.Point(91, 769);
            this.ProcessOrderGroupBox.Name = "ProcessOrderGroupBox";
            this.ProcessOrderGroupBox.Size = new System.Drawing.Size(533, 383);
            this.ProcessOrderGroupBox.TabIndex = 12;
            this.ProcessOrderGroupBox.TabStop = false;
            this.ProcessOrderGroupBox.Text = "Dispaly of the order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Size:";
            // 
            // PizzaSizeTextBox
            // 
            this.PizzaSizeTextBox.Location = new System.Drawing.Point(184, 134);
            this.PizzaSizeTextBox.Name = "PizzaSizeTextBox";
            this.PizzaSizeTextBox.Size = new System.Drawing.Size(296, 31);
            this.PizzaSizeTextBox.TabIndex = 17;
            // 
            // PizzaNameLabel
            // 
            this.PizzaNameLabel.AutoSize = true;
            this.PizzaNameLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PizzaNameLabel.Location = new System.Drawing.Point(32, 85);
            this.PizzaNameLabel.Name = "PizzaNameLabel";
            this.PizzaNameLabel.Size = new System.Drawing.Size(109, 21);
            this.PizzaNameLabel.TabIndex = 14;
            this.PizzaNameLabel.Text = "Pizza Name:";
            // 
            // PizzaNameTextBox
            // 
            this.PizzaNameTextBox.Location = new System.Drawing.Point(184, 81);
            this.PizzaNameTextBox.Name = "PizzaNameTextBox";
            this.PizzaNameTextBox.Size = new System.Drawing.Size(296, 31);
            this.PizzaNameTextBox.TabIndex = 15;
            // 
            // SubTotalOrderTextBox
            // 
            this.SubTotalOrderTextBox.Location = new System.Drawing.Point(184, 293);
            this.SubTotalOrderTextBox.Name = "SubTotalOrderTextBox";
            this.SubTotalOrderTextBox.Size = new System.Drawing.Size(296, 31);
            this.SubTotalOrderTextBox.TabIndex = 13;
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceLabel.Location = new System.Drawing.Point(34, 293);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(133, 21);
            this.TotalPriceLabel.TabIndex = 12;
            this.TotalPriceLabel.Text = "Sub-total Price:";
            // 
            // OrderQuantityTextBox
            // 
            this.OrderQuantityTextBox.Location = new System.Drawing.Point(184, 240);
            this.OrderQuantityTextBox.Name = "OrderQuantityTextBox";
            this.OrderQuantityTextBox.Size = new System.Drawing.Size(296, 31);
            this.OrderQuantityTextBox.TabIndex = 11;
            this.OrderQuantityTextBox.TextChanged += new System.EventHandler(this.OrderQuantityTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity:";
            // 
            // NoOfItemsLabel
            // 
            this.NoOfItemsLabel.AutoSize = true;
            this.NoOfItemsLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NoOfItemsLabel.Location = new System.Drawing.Point(34, 189);
            this.NoOfItemsLabel.Name = "NoOfItemsLabel";
            this.NoOfItemsLabel.Size = new System.Drawing.Size(56, 21);
            this.NoOfItemsLabel.TabIndex = 6;
            this.NoOfItemsLabel.Text = "Price:";
            // 
            // OrderPriceTextBox
            // 
            this.OrderPriceTextBox.Location = new System.Drawing.Point(184, 187);
            this.OrderPriceTextBox.Name = "OrderPriceTextBox";
            this.OrderPriceTextBox.Size = new System.Drawing.Size(296, 31);
            this.OrderPriceTextBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(687, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(562, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(762, 1204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(688, 1204);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(68, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonPanel.Controls.Add(this.SummaryButton);
            this.ButtonPanel.Controls.Add(this.label6);
            this.ButtonPanel.Controls.Add(this.label5);
            this.ButtonPanel.Controls.Add(this.label2);
            this.ButtonPanel.Controls.Add(this.ExitButton);
            this.ButtonPanel.Controls.Add(this.DisplayButton);
            this.ButtonPanel.Controls.Add(this.AddToOrderButton);
            this.ButtonPanel.Controls.Add(this.ClearButton);
            this.ButtonPanel.Controls.Add(this.BookButton);
            this.ButtonPanel.Controls.Add(this.StockReportButton);
            this.ButtonPanel.Location = new System.Drawing.Point(91, 653);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(1554, 90);
            this.ButtonPanel.TabIndex = 10;
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.SummaryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SummaryButton.Location = new System.Drawing.Point(922, 17);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(158, 53);
            this.SummaryButton.TabIndex = 9;
            this.SummaryButton.Text = "S&ummary";
            this.SummaryToolTip.SetToolTip(this.SummaryButton, "Show summary details");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(458, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(234, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "1";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Location = new System.Drawing.Point(1359, 17);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(158, 53);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "&Exit";
            this.ExitToolTip.SetToolTip(this.ExitButton, "Close the app & Read out the stock for today .");
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DisplayButton
            // 
            this.DisplayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.DisplayButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisplayButton.Location = new System.Drawing.Point(48, 17);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(158, 53);
            this.DisplayButton.TabIndex = 0;
            this.DisplayButton.Text = "&Dispaly";
            this.DisplayToolTip.SetToolTip(this.DisplayButton, "Click it after selecting Pizza, Size above");
            this.DisplayButton.UseVisualStyleBackColor = false;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClearButton.Location = new System.Drawing.Point(1144, 17);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(158, 53);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "&Clear";
            this.ClearToolTip.SetToolTip(this.ClearButton, "Clear all text and selected  items.");
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.BookButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BookButton.Location = new System.Drawing.Point(487, 17);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(158, 53);
            this.BookButton.TabIndex = 1;
            this.BookButton.Text = "&Book";
            this.BookToolTip.SetToolTip(this.BookButton, "Book all pizza(s) stored in basket in one transaction");
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // StockReportButton
            // 
            this.StockReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.StockReportButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StockReportButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StockReportButton.Location = new System.Drawing.Point(703, 17);
            this.StockReportButton.Name = "StockReportButton";
            this.StockReportButton.Size = new System.Drawing.Size(158, 53);
            this.StockReportButton.TabIndex = 2;
            this.StockReportButton.Text = "S&tock Report";
            this.StockReportToolTip.SetToolTip(this.StockReportButton, "Show stock report");
            this.StockReportButton.UseVisualStyleBackColor = false;
            this.StockReportButton.Click += new System.EventHandler(this.StockReportButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchButton.Location = new System.Drawing.Point(91, 293);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(165, 49);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "&Search";
            this.SearchToolTip.SetToolTip(this.SearchButton, "Search the transaction by ID & Date");
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.textBox3.Location = new System.Drawing.Point(630, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(358, 32);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "We serve freshly baked dilicious Pizza!";
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.label7);
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchListBox);
            this.SearchGroupBox.Controls.Add(this.DataRadioButton);
            this.SearchGroupBox.Controls.Add(this.TransactionIdRadioButton);
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchGroupBox.Location = new System.Drawing.Point(671, 769);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(974, 383);
            this.SearchGroupBox.TabIndex = 13;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search for Transaction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(31, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 75);
            this.label7.TabIndex = 4;
            this.label7.Text = "Please choose ID or Date above and \r\ninput the corresponding values \r\nin below te" +
    "xt";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(32, 243);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(282, 31);
            this.SearchTextBox.TabIndex = 3;
            // 
            // SearchListBox
            // 
            this.SearchListBox.FormattingEnabled = true;
            this.SearchListBox.ItemHeight = 25;
            this.SearchListBox.Location = new System.Drawing.Point(366, 39);
            this.SearchListBox.Name = "SearchListBox";
            this.SearchListBox.Size = new System.Drawing.Size(584, 304);
            this.SearchListBox.TabIndex = 2;
            // 
            // DataRadioButton
            // 
            this.DataRadioButton.AutoSize = true;
            this.DataRadioButton.Location = new System.Drawing.Point(32, 99);
            this.DataRadioButton.Name = "DataRadioButton";
            this.DataRadioButton.Size = new System.Drawing.Size(201, 29);
            this.DataRadioButton.TabIndex = 1;
            this.DataRadioButton.TabStop = true;
            this.DataRadioButton.Text = "Date of transaction";
            this.DataRadioButton.UseVisualStyleBackColor = true;
            // 
            // TransactionIdRadioButton
            // 
            this.TransactionIdRadioButton.AutoSize = true;
            this.TransactionIdRadioButton.Location = new System.Drawing.Point(32, 50);
            this.TransactionIdRadioButton.Name = "TransactionIdRadioButton";
            this.TransactionIdRadioButton.Size = new System.Drawing.Size(160, 29);
            this.TransactionIdRadioButton.TabIndex = 0;
            this.TransactionIdRadioButton.TabStop = true;
            this.TransactionIdRadioButton.Text = "Transaction ID";
            this.TransactionIdRadioButton.UseVisualStyleBackColor = true;
            // 
            // DisplayToolTip
            // 
            this.DisplayToolTip.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1700, 1283);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.ProcessOrderGroupBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ItemsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Jie\'s Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.ProcessOrderGroupBox.ResumeLayout(false);
            this.ProcessOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ButtonPanel.PerformLayout();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PizzaListBox;
        private System.Windows.Forms.ListBox SizeListBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label NoOfItemsLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox CheeseTextBox;
        private System.Windows.Forms.CheckBox CheeseCheckBox;
        private System.Windows.Forms.TextBox OrderPriceTextBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button StockReportButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox ProcessOrderGroupBox;
        private System.Windows.Forms.TextBox SubTotalOrderTextBox;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.TextBox OrderQuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PizzaSizeTextBox;
        private System.Windows.Forms.Label PizzaNameLabel;
        private System.Windows.Forms.TextBox PizzaNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListBox SearchListBox;
        private System.Windows.Forms.RadioButton DataRadioButton;
        private System.Windows.Forms.RadioButton TransactionIdRadioButton;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.ToolTip DisplayToolTip;
        private System.Windows.Forms.ToolTip AddToOrderToolTip;
        private System.Windows.Forms.ToolTip SummaryToolTip;
        private System.Windows.Forms.ToolTip ExitToolTip;
        private System.Windows.Forms.ToolTip ClearToolTip;
        private System.Windows.Forms.ToolTip BookToolTip;
        private System.Windows.Forms.ToolTip StockReportToolTip;
        private System.Windows.Forms.ToolTip SearchToolTip;
    }
}

