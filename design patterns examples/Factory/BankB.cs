using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Factory
{
	public class BankB: IBank
	{
		public string withdraw()
		{
			return "Withdraw from Bank B";
		}
	}
}
