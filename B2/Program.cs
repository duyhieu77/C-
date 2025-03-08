using B2;

internal class Program
{
	static void Main(string[] args)
	{
		List<Product> products = new List<Product>();
		bool isRunning = true;

		while (isRunning)
		{
			Console.WriteLine("1. Add Product");
			Console.WriteLine("2. Display Added Products");
			Console.WriteLine("3. Exit");
			Console.Write("Select an option: ");

			string choiceInput = Console.ReadLine();
			if (Validator.IsValidMenuChoice(choiceInput, out int choice))
			{
				switch (choice)
				{
					case 1:
						Product.AddProduct(products);
						break;
					case 2:
						Product.DisplayProducts(products);
						break;
					case 3:
						isRunning = false;
						break;
				}
			}
		}
	}
}