using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Builder
{

	public class Product
	{
		private readonly LinkedList<Part> parts;

		public Product()
		{
			parts = new LinkedList<Part>();
		}

		public void Add(Part part)
		{
			// Add parts
			parts.AddLast(part);
		}
		public decimal GetTotalCost()
		{
			decimal total = 0m;
			foreach (var p in parts)
				total += p.TotalPrice;

			return total;
		}

		public string Show()
		{
			StringBuilder result = new StringBuilder();
			result.AppendLine("Product components are:");
			foreach (Part part in parts)
				result.AppendLine(part.ToString());

			result.AppendLine($"Total cost: {GetTotalCost():C}");
			return result.ToString();
		}

	}

}
