using System;
using System.Collections.Generic;

namespace B2
{
	internal class Product
	{
		public string ProductName { get; set; }
		public int Id { get; set; }
		public double Price { get; set; }

		public override string ToString()
		{
			return $"ID: {Id}, Product Name: {ProductName}, Price: {Price}";
		}


		public static void AddProduct(List<Product> products)
		{
			Product product = new Product();

			while (true)
			{
				Console.Write("Enter Product ID: ");
				string input = Console.ReadLine();
				if (Validator.IsValidId(input, out int id))
				{
					product.Id = id;
					break;
				}
			}

			Console.Write("Enter Product Name: ");
			product.ProductName = Console.ReadLine();

			while (true)
			{
				Console.Write("Enter Product Price: ");
				string input = Console.ReadLine();
				if (Validator.IsValidPrice(input, out double price))
				{
					product.Price = price;
					break;
				}
			}

			products.Add(product);
			Console.WriteLine("Product added successfully!\n");
		}

		public static void DisplayProducts(List<Product> products)
		{
			if (products.Count == 0)
			{
				Console.WriteLine("No products to display.\n");
				return;
			}

			Console.WriteLine("Product List:");
			foreach (var product in products)
			{
				Console.WriteLine(product);
			}
			Console.WriteLine();
		}
	}
}