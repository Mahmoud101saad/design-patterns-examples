using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace design_patterns_examples.Singelton
{
	public class Counter
	{
		public int count = 0;
		private Counter() { }
		private static Counter instance=null;
		private static object lockObj=new object();
		public static Counter GetInstance() {
			if (instance == null)
			{
				lock (lockObj)
				{

					if (instance == null)
					{
						instance = new Counter();
					}
				}
			}

			return instance;
		}
		public void AddOne()
		{
			count++;
		}
	}
}
