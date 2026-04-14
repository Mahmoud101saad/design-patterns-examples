using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.StructuralPatterns.ProxyPattern
{
	public class concretSMSservice : SMSservice
	{
		public override string SendSMS(string custId, string mobile, string sms)
		{
			return $"SMS sent to {mobile} for customer {custId} with message: {sms}";
		}
	}
}
