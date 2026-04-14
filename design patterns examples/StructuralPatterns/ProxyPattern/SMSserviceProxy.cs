using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_examples.StructuralPatterns.ProxyPattern
{
	public class SMSserviceProxy
	{
		private SMSservice _sMSservice;
		Dictionary<string, int> sentCount = new Dictionary<string, int>();

		public string SendSMS(string custId, string mobile, string sms)
		{
			if (_sMSservice == null)
			{
				_sMSservice = new concretSMSservice();
			}
			if (!sentCount.ContainsKey(custId))
			{
				sentCount[custId] = 0;
			}
			if (sentCount[custId] < 3)
			{
				sentCount[custId]++;
				return _sMSservice.SendSMS(custId, mobile, sms);
			}
			else
			{
				return "SMS limit reached for customer " + custId;
			}
		}
	}
}
