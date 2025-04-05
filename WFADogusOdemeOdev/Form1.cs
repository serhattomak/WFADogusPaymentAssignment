using Microsoft.Data.SqlClient;
using System.Data;
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

		SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DogusPaymentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False");

		private void btnPay_Click(object sender, EventArgs e)
		{
			PaymentFactory paymentFactory = new PaymentFactory();
			payment = paymentFactory.CreateNewObject(selectedPaymentType);
			if (payment != null)
			{
				Payment paymentObj = new Payment(payment);
				lblResult.Text = paymentObj.Pay(txtAmount.Text);
			}
			else
			{
				lblResult.Text = "Ödeme yöntemi bulunamadý.";
			}
		}

		private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedPaymentType = cmbPaymentType.SelectedValue.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			PaymentClassGenerator.GeneratePaymentClasses();

			sqlConnection.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM Combobox", sqlConnection);

			using (SqlDataReader reader = command.ExecuteReader())
			{
				DataTable dataTable = new DataTable();
				dataTable.Load(reader);

				cmbPaymentType.DisplayMember = "Display_member";
				cmbPaymentType.ValueMember = "Display_value";
				cmbPaymentType.DataSource = dataTable;
			}

			sqlConnection.Close();
		}
	}
}
