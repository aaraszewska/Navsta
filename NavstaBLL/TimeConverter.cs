using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
	public static class TimeConverter
	{
		public static string MptTime()
		{
			TimeSpan time = TimeSpan.FromSeconds(54243.23);
            string str = time.ToString(@"hh\:mm\:ss");
			return str;

			

		}
	}
		

	
}


