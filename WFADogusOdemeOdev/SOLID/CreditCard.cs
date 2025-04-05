namespace WFADogusOdemeOdev.SOLID;

public class CreditCard : IPayment
{
	public string Pay(string message)
	{
		return " CreditCard ile " + message + " ödeme yapıldı.";
	}
}