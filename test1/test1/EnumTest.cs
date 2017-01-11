using System;

namespace test1
{
	enum Days{
		Sun, Mon, tue, Wed, thu, Fri, Sat
	}
	public class EnumTest
	{
		public EnumTest ()
		{
			int WeekdayStart = (int)Days.Mon;
			int WeekdayEnd = (int)Days.Fri;
			Console.WriteLine("Monday: {0}", WeekdayStart);
			Console.WriteLine("Friday: {0}", WeekdayEnd);
		}
	}
}

