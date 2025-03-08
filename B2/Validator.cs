using System;

namespace B2
{
	internal static class Validator
	{
		public static bool IsValidId(string input, out int id)
		{
			bool isValid = int.TryParse(input, out id);
			if (!isValid)
			{
				Console.WriteLine("Invalid ID. Please enter again.");
			}
			return isValid;
		}

		public static bool IsValidPrice(string input, out double price)
		{
			bool isValid = double.TryParse(input, out price);
			if (!isValid)
			{
				Console.WriteLine("Invalid price. Please enter again.");
			}
			return isValid;
		}

		public static bool IsValidMenuChoice(string input, out int choice)
		{
			bool isValid = int.TryParse(input, out choice) && (choice >= 1 && choice <= 3);
			if (!isValid)
			{
				Console.WriteLine("Invalid choice. Please select between 1 and 3.");
			}
			return isValid;
		}
	}
}