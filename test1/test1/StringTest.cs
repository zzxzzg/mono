using System;

namespace test1
{
	public class StringTest
	{
		public StringTest ()
		{
			//初始化方式
			//字符串，字符串连接
			string fname, lname;
			fname = "Rowan";
			lname = "Atkinson";

			string fullname = fname + lname;

			Console.WriteLine("Full Name: {0}", fullname);

			//通过使用 string 构造函数
			char[] letters = { 'H', 'e', 'l', 'l','o' };
			string greetings = new string(letters);
			Console.WriteLine("Greetings: {0}", greetings);

			//方法返回字符串
			string[] sarray = { "Hello", "From", "Tutorials", "Point" };
			string message = String.Join(" ", sarray);
			Console.WriteLine("Message: {0}", message);

			//用于转化值的格式化方法
			DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
			string chat = String.Format("Message sent at {0:t} on {0:D}", 
				waiting);
			Console.WriteLine("Message: {0}", chat);
		}

		public void methods(){
			string str1 = "test1";
			string str2 = "test2";

			string.Compare (str1, str2);//compare
			string.Compare (str1, str2,true);//compare ignore Up-low-case

			string str3 = string.Concat (str1, str2);//连接两个字符串

			str1.Contains ("test");// is contains

			string str4 = string.Copy (str1);

			char[] ch = new char[10];
			str3.CopyTo (0,ch,0,5);//拷贝2

			//str3.EndsWith()
			str3.Equals(str1);
			string.Equals (str3, str1);
			//indexOf //返回指定 Unicode 字符在当前字符串中第一次出现的索引，索引从 0 开始。
			//lastIndexOf
			//indexOfAny //返回某一个指定的 Unicode 字符数组中任意字符在该实例中第一次出现的索引，索引从 0 开始。
			//remove
			//replace
			//Split
			//StartsWith
			//ToCharArray
			//ToLower
			//ToUpper
			//Trim


			string str5 = str1.Insert (2,"haha");
			string.IsNullOrEmpty (str1); //是否为空或者null


			string.Join ("/", new string[]{ str1, str2 });//连接一个字符串数组中的所有元素，使用指定的分隔符分隔每个元素。





		}


	}
}

