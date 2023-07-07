namespace ExchangeRate.Winform
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
            components = new System.ComponentModel.Container();
            labelBinance = new Label();
            labelBybit = new Label();
            labelKucoin = new Label();
            labelBtcUsdt = new Label();
            labelBinanceRate = new Label();
            labelBybitRate = new Label();
            labelKucoinRate = new Label();
            timerRefresh = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelBinance
            // 
            labelBinance.AutoSize = true;
            labelBinance.Location = new Point(12, 41);
            labelBinance.Name = "labelBinance";
            labelBinance.Size = new Size(61, 20);
            labelBinance.TabIndex = 0;
            labelBinance.Text = "Binance";
            // 
            // labelBybit
            // 
            labelBybit.AutoSize = true;
            labelBybit.Location = new Point(12, 73);
            labelBybit.Name = "labelBybit";
            labelBybit.Size = new Size(43, 20);
            labelBybit.TabIndex = 1;
            labelBybit.Text = "Bybit";
            // 
            // labelKucoin
            // 
            labelKucoin.AutoSize = true;
            labelKucoin.Location = new Point(12, 105);
            labelKucoin.Name = "labelKucoin";
            labelKucoin.Size = new Size(54, 20);
            labelKucoin.TabIndex = 2;
            labelKucoin.Text = "Kucoin";
            // 
            // labelBtcUsdt
            // 
            labelBtcUsdt.AutoSize = true;
            labelBtcUsdt.Location = new Point(96, 9);
            labelBtcUsdt.Name = "labelBtcUsdt";
            labelBtcUsdt.Size = new Size(69, 20);
            labelBtcUsdt.TabIndex = 3;
            labelBtcUsdt.Text = "BTCUSDT";
            // 
            // labelBinanceRate
            // 
            labelBinanceRate.AutoSize = true;
            labelBinanceRate.Location = new Point(96, 41);
            labelBinanceRate.Name = "labelBinanceRate";
            labelBinanceRate.Size = new Size(17, 20);
            labelBinanceRate.TabIndex = 4;
            labelBinanceRate.Text = "0";
            // 
            // labelBybitRate
            // 
            labelBybitRate.AutoSize = true;
            labelBybitRate.Location = new Point(96, 73);
            labelBybitRate.Name = "labelBybitRate";
            labelBybitRate.Size = new Size(17, 20);
            labelBybitRate.TabIndex = 5;
            labelBybitRate.Text = "0";
            // 
            // labelKucoinRate
            // 
            labelKucoinRate.AutoSize = true;
            labelKucoinRate.Location = new Point(96, 105);
            labelKucoinRate.Name = "labelKucoinRate";
            labelKucoinRate.Size = new Size(17, 20);
            labelKucoinRate.TabIndex = 6;
            labelKucoinRate.Text = "0";
            // 
            // timerRefresh
            // 
            timerRefresh.Enabled = true;
            timerRefresh.Interval = 4000;
            timerRefresh.Tick += timerRefresh_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 151);
            Controls.Add(labelKucoinRate);
            Controls.Add(labelBybitRate);
            Controls.Add(labelBinanceRate);
            Controls.Add(labelBtcUsdt);
            Controls.Add(labelKucoin);
            Controls.Add(labelBybit);
            Controls.Add(labelBinance);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBinance;
        private Label labelBybit;
        private Label labelKucoin;
        private Label labelBtcUsdt;
        private Label labelBinanceRate;
        private Label labelBybitRate;
        private Label labelKucoinRate;
        private System.Windows.Forms.Timer timerRefresh;
    }
}