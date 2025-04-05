namespace WFADogusOdemeOdev
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
			lblPaymentType = new Label();
			lblAmount = new Label();
			lblResult = new Label();
			cmbPaymentType = new ComboBox();
			txtAmount = new TextBox();
			btnPay = new Button();
			SuspendLayout();
			// 
			// lblPaymentType
			// 
			lblPaymentType.AutoSize = true;
			lblPaymentType.Location = new Point(70, 48);
			lblPaymentType.Name = "lblPaymentType";
			lblPaymentType.Size = new Size(74, 15);
			lblPaymentType.TabIndex = 0;
			lblPaymentType.Text = "Ödeme Tipi :";
			// 
			// lblAmount
			// 
			lblAmount.AutoSize = true;
			lblAmount.Location = new Point(70, 91);
			lblAmount.Name = "lblAmount";
			lblAmount.Size = new Size(47, 15);
			lblAmount.TabIndex = 1;
			lblAmount.Text = "Miktar :";
			// 
			// lblResult
			// 
			lblResult.AutoSize = true;
			lblResult.Location = new Point(70, 359);
			lblResult.Name = "lblResult";
			lblResult.Size = new Size(46, 15);
			lblResult.TabIndex = 2;
			lblResult.Text = "Sonuç :";
			// 
			// cmbPaymentType
			// 
			cmbPaymentType.FormattingEnabled = true;
			cmbPaymentType.Items.AddRange(new object[] { "Seçiniz", "Cash", "CreditCard", "DebitCard", "Paypal" });
			cmbPaymentType.Location = new Point(186, 48);
			cmbPaymentType.Name = "cmbPaymentType";
			cmbPaymentType.Size = new Size(182, 23);
			cmbPaymentType.TabIndex = 3;
			cmbPaymentType.SelectedIndexChanged += cmbPaymentType_SelectedIndexChanged;
			// 
			// txtAmount
			// 
			txtAmount.Location = new Point(186, 91);
			txtAmount.Name = "txtAmount";
			txtAmount.Size = new Size(182, 23);
			txtAmount.TabIndex = 4;
			// 
			// btnPay
			// 
			btnPay.Location = new Point(186, 158);
			btnPay.Name = "btnPay";
			btnPay.Size = new Size(182, 49);
			btnPay.TabIndex = 5;
			btnPay.Text = "ÖDEME YAP";
			btnPay.UseVisualStyleBackColor = true;
			btnPay.Click += btnPay_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnPay);
			Controls.Add(txtAmount);
			Controls.Add(cmbPaymentType);
			Controls.Add(lblResult);
			Controls.Add(lblAmount);
			Controls.Add(lblPaymentType);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblPaymentType;
		private Label lblAmount;
		private Label lblResult;
		private ComboBox cmbPaymentType;
		private TextBox txtAmount;
		private Button btnPay;
	}
}
