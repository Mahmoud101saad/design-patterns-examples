using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Builder
{
	//concrete builder
	public class CarBuilder:IBuilder
	{
		private string brandName;
		private Product product ;
		public CarBuilder(string brand)
		{
			product= new Product();
			this.brandName = brand;
		}
		public void StartUpOperations()
		{
			
			product.Add(new Part($"Car Brand: {brandName}", 1, 0m));
		}

		public void BuildBody()
		{
			product.Add(new Part("Car Body", 1, 2500m));
		}

		public void InsertWheels()
		{
			product.Add(new Part("Wheel", 4, 150m));
		}

		public void AddHeadlights()
		{
			product.Add(new Part("Headlight", 2, 80m));
		}

		public void EndOperations()
		{
			// Any final operations
		}

		public Product GetVehicle()
		{
			return product;
		}


	}
}
