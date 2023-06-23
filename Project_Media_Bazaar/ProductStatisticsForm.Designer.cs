namespace Project_Media_Bazaar
{
    partial class ProductStatisticsForm
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
            lTotalSales = new Label();
            label1 = new Label();
            lMostSoldProduct = new Label();
            label2 = new Label();
            label3 = new Label();
            lSalesToday = new Label();
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            from_lbl = new Label();
            dtpEndDate = new DateTimePicker();
            until_lbl = new Label();
            result_lbl = new Label();
            generate_btn = new Button();
            oneWeek_btn = new Button();
            oneMonth_btn = new Button();
            oneYear_btn = new Button();
            custom_btn = new Button();
            groupBox = new GroupBox();
            x_btn = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // lTotalSales
            // 
            lTotalSales.AutoSize = true;
            lTotalSales.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lTotalSales.Location = new Point(260, 9);
            lTotalSales.Margin = new Padding(2, 0, 2, 0);
            lTotalSales.Name = "lTotalSales";
            lTotalSales.Size = new Size(136, 37);
            lTotalSales.TabIndex = 0;
            lTotalSales.Text = "total sales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 1;
            label1.Text = "Total numer sales:";
            // 
            // lMostSoldProduct
            // 
            lMostSoldProduct.AutoSize = true;
            lMostSoldProduct.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lMostSoldProduct.Location = new Point(260, 46);
            lMostSoldProduct.Margin = new Padding(2, 0, 2, 0);
            lMostSoldProduct.Name = "lMostSoldProduct";
            lMostSoldProduct.Size = new Size(126, 37);
            lMostSoldProduct.TabIndex = 2;
            lMostSoldProduct.Text = "mostsold";
            lMostSoldProduct.Click += lMostSoldProduct_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 46);
            label2.Name = "label2";
            label2.Size = new Size(200, 37);
            label2.TabIndex = 3;
            label2.Text = "Most sold item:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 92);
            label3.Name = "label3";
            label3.Size = new Size(290, 37);
            label3.TabIndex = 4;
            label3.Text = "Number of sales today:";
            // 
            // lSalesToday
            // 
            lSalesToday.AutoSize = true;
            lSalesToday.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lSalesToday.Location = new Point(310, 92);
            lSalesToday.Margin = new Padding(2, 0, 2, 0);
            lSalesToday.Name = "lSalesToday";
            lSalesToday.Size = new Size(0, 37);
            lSalesToday.TabIndex = 5;
            lSalesToday.Click += label4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 26);
            label4.Name = "label4";
            label4.Size = new Size(362, 37);
            label4.TabIndex = 6;
            label4.Text = "Sales for specific time period:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarFont = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Location = new Point(95, 272);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 34);
            dtpStartDate.TabIndex = 7;
            // 
            // from_lbl
            // 
            from_lbl.AutoSize = true;
            from_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            from_lbl.Location = new Point(18, 275);
            from_lbl.Name = "from_lbl";
            from_lbl.Size = new Size(71, 31);
            from_lbl.TabIndex = 8;
            from_lbl.Text = "From:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Location = new Point(375, 275);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 34);
            dtpEndDate.TabIndex = 9;
            // 
            // until_lbl
            // 
            until_lbl.AutoSize = true;
            until_lbl.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            until_lbl.Location = new Point(301, 274);
            until_lbl.Name = "until_lbl";
            until_lbl.Size = new Size(68, 31);
            until_lbl.TabIndex = 10;
            until_lbl.Text = "Until:";
            // 
            // result_lbl
            // 
            result_lbl.AutoSize = true;
            result_lbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            result_lbl.Location = new Point(19, 320);
            result_lbl.Name = "result_lbl";
            result_lbl.Size = new Size(94, 37);
            result_lbl.TabIndex = 11;
            result_lbl.Text = "Result:";
            // 
            // generate_btn
            // 
            generate_btn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            generate_btn.Location = new Point(468, 314);
            generate_btn.Name = "generate_btn";
            generate_btn.Size = new Size(200, 48);
            generate_btn.TabIndex = 12;
            generate_btn.Text = "Generate";
            generate_btn.UseVisualStyleBackColor = true;
            generate_btn.Click += bCheckSales_Click;
            // 
            // oneWeek_btn
            // 
            oneWeek_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            oneWeek_btn.Location = new Point(8, 68);
            oneWeek_btn.Name = "oneWeek_btn";
            oneWeek_btn.Size = new Size(127, 43);
            oneWeek_btn.TabIndex = 13;
            oneWeek_btn.Text = "One Week";
            oneWeek_btn.UseVisualStyleBackColor = true;
            oneWeek_btn.Click += oneWeek_btn_Click;
            // 
            // oneMonth_btn
            // 
            oneMonth_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            oneMonth_btn.Location = new Point(141, 68);
            oneMonth_btn.Name = "oneMonth_btn";
            oneMonth_btn.Size = new Size(127, 43);
            oneMonth_btn.TabIndex = 14;
            oneMonth_btn.Text = "One Month";
            oneMonth_btn.UseVisualStyleBackColor = true;
            oneMonth_btn.Click += oneMonth_btn_Click;
            // 
            // oneYear_btn
            // 
            oneYear_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            oneYear_btn.Location = new Point(274, 68);
            oneYear_btn.Name = "oneYear_btn";
            oneYear_btn.Size = new Size(127, 43);
            oneYear_btn.TabIndex = 15;
            oneYear_btn.Text = "One Year";
            oneYear_btn.UseVisualStyleBackColor = true;
            oneYear_btn.Click += oneYear_btn_Click;
            // 
            // custom_btn
            // 
            custom_btn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            custom_btn.Location = new Point(407, 68);
            custom_btn.Name = "custom_btn";
            custom_btn.Size = new Size(127, 43);
            custom_btn.TabIndex = 16;
            custom_btn.Text = "Custom";
            custom_btn.UseVisualStyleBackColor = true;
            custom_btn.Click += custom_btn_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(oneWeek_btn);
            groupBox.Controls.Add(oneMonth_btn);
            groupBox.Controls.Add(oneYear_btn);
            groupBox.Controls.Add(custom_btn);
            groupBox.Location = new Point(15, 144);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(552, 122);
            groupBox.TabIndex = 17;
            groupBox.TabStop = false;
            groupBox.Text = "Search Options";
            // 
            // x_btn
            // 
            x_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            x_btn.Location = new Point(581, 278);
            x_btn.Name = "x_btn";
            x_btn.Size = new Size(23, 30);
            x_btn.TabIndex = 18;
            x_btn.Text = "X";
            x_btn.UseVisualStyleBackColor = true;
            x_btn.Click += x_btn_Click;
            // 
            // ProductStatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 369);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(x_btn);
            Controls.Add(from_lbl);
            Controls.Add(until_lbl);
            Controls.Add(generate_btn);
            Controls.Add(result_lbl);
            Controls.Add(lSalesToday);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lMostSoldProduct);
            Controls.Add(label1);
            Controls.Add(lTotalSales);
            Controls.Add(groupBox);
            Margin = new Padding(2);
            Name = "ProductStatisticsForm";
            Text = "ProductStatisticsForm";
            Load += ProductStatisticsForm_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTotalSales;
        private Label label1;
        private Label lMostSoldProduct;
        private Label label2;
        private Label label3;
        private Label lSalesToday;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private Label from_lbl;
        private DateTimePicker dtpEndDate;
        private Label until_lbl;
        private Label result_lbl;
        private Button generate_btn;
        private Button oneWeek_btn;
        private Button oneMonth_btn;
        private Button oneYear_btn;
        private Button custom_btn;
        private GroupBox groupBox;
        private Button x_btn;
    }
}