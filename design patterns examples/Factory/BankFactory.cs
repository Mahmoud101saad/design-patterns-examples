using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Factory
{
	public class BankFactory:IBankFactory
	{
		public IBank createBanck(string banckCode)
		{
			switch ( banckCode )
			{
				case "111111":
					return new BankA();
				case "222222":
					return new BankB();
				default:
					return null;
			}
		}

		public IpaymentCard GetpaymentCard(string cardNumber)
		{
			switch (cardNumber)
			{
				case "11":
					return new VisaCard();
				case "22":
					return new MasterCard();
				default:
					return null;
			}
		}
	}
}
