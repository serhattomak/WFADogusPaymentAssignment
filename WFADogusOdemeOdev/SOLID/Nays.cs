namespace WFADogusOdemeOdev.SOLID;

public class Nays : IPayment
{
	public string Pay(string message)
	{
		return " Nays ile " + message + " ödeme yapıldı.";
	}
}
