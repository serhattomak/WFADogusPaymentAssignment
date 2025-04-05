namespace WFADogusOdemeOdev.SOLID;

public class Papara : IPayment
{
	public string Pay(string message)
	{
		return " Papara ile " + message + " ödeme yapıldı.";
	}
}