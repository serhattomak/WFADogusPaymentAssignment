using WFADogusOdemeOdev.SOLID;

namespace WFADogusOdemeOdev
{
	public partial class Form1 : Form
	{
		private string selectedPaymentType;
		IPayment payment;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnPay_Click(object sender, EventArgs e)
		{
			PaymentFactory paymentFactory = new PaymentFactory();
			payment = paymentFactory.CreateNewObject(selectedPaymentType);
			Payment paymentObj = new Payment(payment);
			lblResult.Text = paymentObj.Pay(txtAmount.Text);
		}

		private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedPaymentType = cmbPaymentType.SelectedItem.ToString();
		}
	}
}
