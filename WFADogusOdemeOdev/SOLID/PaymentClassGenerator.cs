using Microsoft.Data.SqlClient;

namespace WFADogusOdemeOdev.SOLID
{
	public static class PaymentClassGenerator
	{
		private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DogusPaymentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";
		private static string namespaceName = "WFADogusOdemeOdev.SOLID";
		private static string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\SOLID");

		public static void GeneratePaymentClasses()
		{
			var paymentTypes = GetPaymentTypesFromDatabase();
			var existingClasses = GetExistingPaymentClasses();

			foreach (var paymentType in paymentTypes)
			{
				if (!existingClasses.Contains(paymentType))
				{
					CreatePaymentClass(paymentType);
				}
			}
		}

		private static List<string> GetPaymentTypesFromDatabase()
		{
			List<string> paymentTypes = new List<string>();

			using (SqlConnection sqlConnection = new SqlConnection(connectionString))
			{
				sqlConnection.Open();
				SqlCommand command = new SqlCommand("SELECT Display_value FROM Combobox", sqlConnection);

				using (SqlDataReader reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						paymentTypes.Add(reader["Display_value"].ToString());
					}
				}
			}

			return paymentTypes;
		}

		private static List<string> GetExistingPaymentClasses()
		{
			List<string> existingClasses = new List<string>();

			if (!Directory.Exists(directoryPath))
			{
				Directory.CreateDirectory(directoryPath);
			}

			var files = Directory.GetFiles(directoryPath, "*.cs");
			foreach (var file in files)
			{
				var className = Path.GetFileNameWithoutExtension(file);
				existingClasses.Add(className);
			}

			return existingClasses;
		}

		private static void CreatePaymentClass(string className)
		{
			string classContent = $@"
    namespace {namespaceName};

    public class {className} : IPayment
    {{
        public string Pay(string message)
        {{
            return "" {className} ile "" + message + "" ödeme yapıldı."";
        }}
    }}
    ";
			try
			{
				File.WriteAllText(Path.Combine(directoryPath, $"{className}.cs"), classContent);
				Console.WriteLine($"Class {className} created successfully at {Path.Combine(directoryPath, $"{className}.cs")}");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error creating class {className}: {ex.Message}");
			}
		}
	}
}
