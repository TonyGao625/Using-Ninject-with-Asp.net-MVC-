using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWithNinject
{
	public class DataBaseLogger:ILogger
	{
		public void LogData(string content)
		{
			// insert error in database
		}
	}
}