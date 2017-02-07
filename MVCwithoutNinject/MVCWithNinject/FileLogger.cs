using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MVCWithNinject
{
	public class FileLogger:ILogger
	{
		public void LogData(string content)
		{
			using (StreamWriter sw = new StreamWriter("C:\Log.txt"))
			{
				sw.Write(content);
			}
		}
	}
}