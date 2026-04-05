using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.Factory
{
	public interface IpaymentCard
	{
		string GetName();
		string GetProviderInfo();
	}

	public class VisaCard : IpaymentCard
	{
		public string GetName()
		{
			return "Visa Card";
		}
		public string GetProviderInfo()
		{
			return "Visa is a global payments technology company that connects consumers, businesses, financial institutions, and governments to fast, secure and reliable electronic payments.";
		}
	}

	public class MasterCard : IpaymentCard
	{
		public string GetName()
		{
			return "Master Card";
		}
		public string GetProviderInfo()
		{
			return "Mastercard is a global technology company in the payments industry. Our mission is to connect and power an inclusive, digital economy that benefits everyone, everywhere by making transactions safe, simple, smart and accessible.";
		}
	}
}
