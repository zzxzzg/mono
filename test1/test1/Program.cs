using System;//using 关键字用于在程序中包含 System 命名空间

namespace test1//一个 namespace 是一系列的类 一个命名空间
{
	class MainClass
	{
		public static void Main (string[] args)//是所有 C# 程序的 入口点
		{
			Console.WriteLine ("Hello World!");
			TypeTest test = new TypeTest ();
			ArrayTest at = new ArrayTest ();
			StructTest structTest = new StructTest ();
			EnumTest enumTest = new EnumTest ();
			Console.ReadKey(); //读取按键，防止直接退出
		}
	}
}
