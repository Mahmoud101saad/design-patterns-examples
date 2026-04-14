using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.StructuralPatterns.ProxyPattern
{
	public abstract class SMSservice
	{
		public abstract string SendSMS(string custId,string mobile ,string sms);
	}
}
