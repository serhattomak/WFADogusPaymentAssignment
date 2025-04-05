namespace WFADogusOdemeOdev.SOLID;

public class Payment
{
	public IPayment payment;

	public Payment(IPayment payment)
	{
		this.payment = payment;
	}

	public string Pay(string message)
	{
		if (payment == null)
		{
			return "Ödeme işlemi gerçekleştirilemedi. Geçersiz ödeme türü.";
		}
		return payment.Pay(message);
	}
}