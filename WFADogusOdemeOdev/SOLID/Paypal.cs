namespace WFADogusOdemeOdev.SOLID;

public class Paypal : IPayment
{
	public string Pay(string message)
	{
		return " Paypal ile " + message + " ödeme yapıldı.";
	}
}