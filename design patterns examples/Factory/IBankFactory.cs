using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Factory
{
	public interface IBankFactory
	{
		IBank createBanck(string banckCode);
	}
}
