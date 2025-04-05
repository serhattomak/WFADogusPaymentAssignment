using System.Reflection;

namespace WFADogusOdemeOdev.SOLID;

public class PaymentFactory
{
	public IPayment CreateNewObject(string className)
	{
		var newObject = Assembly.GetAssembly(typeof(IPayment)).CreateInstance("WFADogusOdemeOdev.SOLID." + className);

		if (newObject == null)
		{
			MessageBox.Show("Ödeme türü bulunamadı.");
			return null;
		}

		return (IPayment)newObject;
	}
}