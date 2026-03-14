using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Builder
{
	//Builder interface 
	public interface IBuilder
	{
		void StartUpOperations();
		void BuildBody();
		void InsertWheels();
		void AddHeadlights();
		void EndOperations();
		Product GetVehicle();
	}

}
