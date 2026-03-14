using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Builder
{
	public class Part
	{
		public string Name { get; }
		public int Quantity { get; }
		public decimal UnitPrice { get; }

		public Part(string name, int quantity, decimal unitPrice)
		{
			Name = name;
			Quantity = quantity;
			UnitPrice = unitPrice;
		}

		public decimal TotalPrice => Quantity * UnitPrice;

		public override string ToString()
			=> $"{Name} x{Quantity} @ {UnitPrice:C} = {TotalPrice:C}";
	}

}
