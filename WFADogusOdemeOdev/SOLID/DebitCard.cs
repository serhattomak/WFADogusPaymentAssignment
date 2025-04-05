namespace WFADogusOdemeOdev.SOLID;

public class DebitCard : IPayment
{
	public string Pay(string message)
	{
		return " DebitCard ile " + message + " ödeme yapıldı.";
	}
}