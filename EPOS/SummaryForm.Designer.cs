
namespace EPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.SummaryDataLabel = new System.Windows.Forms.Label();
            this.TotalTransactionsLabel = new System.Windows.Forms.Label();
            this.TotalPizzaFeeLabel = new System.Windows.Forms.Label();
            this.TotalAverageRevenueLabel = new System.Windows.Forms.Label();
            this.TotalTransactionsTextBox = new System.Windows.Forms.TextBox();
            this.TotalPizzaFeeTextBox = new System.Windows.Forms.TextBox();
            this.TotalAverageRevenueTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SummaryDataLabel
            // 
            this.SummaryDataLabel.AutoSize = true;
            this.SummaryDataLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SummaryDataLabel.Location = new System.Drawing.Point(244, 52);
            this.SummaryDataLabel.Name = "SummaryDataLabel";
            this.SummaryDataLabel.Size = new System.Drawing.Size(281, 48);
            this.SummaryDataLabel.TabIndex = 0;
            this.SummaryDataLabel.Text = "Summary Data";
            // 
            // TotalTransactionsLabel
            // 
            this.TotalTransactionsLabel.AutoSize = true;
            this.TotalTransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalTransactionsLabel.Location = new System.Drawing.Point(92, 166);
            this.TotalTransactionsLabel.Name = "TotalTransactionsLabel";
            this.TotalTransactionsLabel.Size = new System.Drawing.Size(204, 28);
            this.TotalTransactionsLabel.TabIndex = 1;
            this.TotalTransactionsLabel.Text = "Total Transactions：";
            // 
            // TotalPizzaFeeLabel
            // 
            this.TotalPizzaFeeLabel.AutoSize = true;
            this.TotalPizzaFeeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalPizzaFeeLabel.Location = new System.Drawing.Point(92, 229);
            this.TotalPizzaFeeLabel.Name = "TotalPizzaFeeLabel";
            this.TotalPizzaFeeLabel.Size = new System.Drawing.Size(173, 28);
            this.TotalPizzaFeeLabel.TabIndex = 2;
            this.TotalPizzaFeeLabel.Text = "Total Pizza Fee：";
            // 
            // TotalAverageRevenueLabel
            // 
            this.TotalAverageRevenueLabel.AutoSize = true;
            this.TotalAverageRevenueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalAverageRevenueLabel.Location = new System.Drawing.Point(92, 291);
            this.TotalAverageRevenueLabel.Name = "TotalAverageRevenueLabel";
            this.TotalAverageRevenueLabel.Size = new System.Drawing.Size(251, 28);
            this.TotalAverageRevenueLabel.TabIndex = 4;
            this.TotalAverageRevenueLabel.Text = "Total Average Revenue：";
            // 
            // TotalTransactionsTextBox
            // 
            this.TotalTransactionsTextBox.Location = new System.Drawing.Point(414, 166);
            this.TotalTransactionsTextBox.Name = "TotalTransactionsTextBox";
            this.TotalTransactionsTextBox.Size = new System.Drawing.Size(238, 31);
            this.TotalTransactionsTextBox.TabIndex = 6;
            // 
            // TotalPizzaFeeTextBox
            // 
            this.TotalPizzaFeeTextBox.Location = new System.Drawing.Point(414, 229);
            this.TotalPizzaFeeTextBox.Name = "TotalPizzaFeeTextBox";
            this.TotalPizzaFeeTextBox.Size = new System.Drawing.Size(238, 31);
            this.TotalPizzaFeeTextBox.TabIndex = 7;
            // 
            // TotalAverageRevenueTextBox
            // 
            this.TotalAverageRevenueTextBox.Location = new System.Drawing.Point(414, 291);
            this.TotalAverageRevenueTextBox.Name = "TotalAverageRevenueTextBox";
            this.TotalAverageRevenueTextBox.Size = new System.Drawing.Size(238, 31);
            this.TotalAverageRevenueTextBox.TabIndex = 9;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(145)))), ((int)(((byte)(59)))));
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.Location = new System.Drawing.Point(310, 425);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(165, 49);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "&Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(340, 548);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(390, 548);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(794, 626);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.TotalAverageRevenueTextBox);
            this.Controls.Add(this.TotalPizzaFeeTextBox);
            this.Controls.Add(this.TotalTransactionsTextBox);
            this.Controls.Add(this.TotalAverageRevenueLabel);
            this.Controls.Add(this.TotalPizzaFeeLabel);
            this.Controls.Add(this.TotalTransactionsLabel);
            this.Controls.Add(this.SummaryDataLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SummaryDataLabel;
        private System.Windows.Forms.Label TotalTransactionsLabel;
        private System.Windows.Forms.Label TotalPizzaFeeLabel;
        private System.Windows.Forms.Label TotalOptionsLabel;
        private System.Windows.Forms.Label TotalAverageRevenueLabel;
        private System.Windows.Forms.TextBox TotalTransactionsTextBox;
        private System.Windows.Forms.TextBox TotalPizzaFeeTextBox;
        private System.Windows.Forms.TextBox TotalOptionsTextBox;
        private System.Windows.Forms.TextBox TotalAverageRevenueTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}