using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Builder
{
	public class Director
	{
		IBuilder builder;

		// steps to create complex object
		public void Construct(IBuilder builder)
		{
			this.builder = builder;
			builder.StartUpOperations();
			builder.BuildBody();
			builder.InsertWheels();
			builder.AddHeadlights();
			builder.EndOperations();
		}
	}
}
