namespace WFADogusOdemeOdev.SOLID;

public class Sipay : IPayment
{
	public string Pay(string message)
	{
		return " Sipay ile " + message + " ödeme yapıldı.";
	}
}
