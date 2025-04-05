namespace WFADogusOdemeOdev.SOLID;

public class Cash : IPayment
{
	public string Pay(string message)
	{
		return " Cash ile " + message + " ödeme yapıldı.";
	}
}