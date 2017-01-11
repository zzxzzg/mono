using System;

namespace test1
{
	public class TypeTest
	{

		//如果没有指定访问修饰符，则使用类成员的默认访问修饰符，即为 private。
		internal int internal_a;// 允许该应用程序中的所有类访问
		protected internal 	int proint;//同一应用程序内的子类访问

		public TypeTest ()
		{
			
		}

		public void valueType(){
//			值类型（Value types）
//			值类型变量可以直接分配给一个值。它们是从类 System.ValueType 中派生的。
			bool a;
			byte b;// 8 bit unsigned
			sbyte c; // 8bit signed
			char d;// 16 bit Unicode
			decimal e; //128 bit
			double f; //64 bit
			float g; //32 bit;
			int h; //32 bit
			long i; //64 bit
			short j; // 16 bit
			uint k; // 32 bit unsigned
			ulong l; // 64 bit unsigned
			ushort m;// 16 bit unsigned

			Console.WriteLine (sizeof(bool));
			Console.WriteLine (sizeof(byte));
			Console.WriteLine (sizeof(sbyte));
			Console.WriteLine (sizeof(char));
			Console.WriteLine (sizeof(decimal));
			Console.WriteLine (sizeof(double));
			Console.WriteLine (sizeof(float));
			Console.WriteLine (sizeof(int));
			Console.WriteLine (sizeof(long));
			Console.WriteLine (sizeof(short));
			Console.WriteLine (sizeof(uint));
			Console.WriteLine (sizeof(ulong));
			Console.WriteLine (sizeof(ushort));
		}

		public void reference(){
			//引用类型不包含存储在变量中的实际数据，但它们包含对变量的引用。它们指的是一个内存位置
			//内置的 引用类型有：object、dynamic 和 string

			//对象（Object）类型 ,所有数据类型的终极基类
			//当一个值类型转换为对象类型时，则被称为 装箱；另一方面，当一个对象类型转换为值类型时，则被称为 拆箱。
			object obj;
			obj = 100; // 这是装箱


			//动态（Dynamic）类型  您可以存储任何类型的值在动态数据类型变量中。
			dynamic d = 20;
			//动态类型与对象类型相似，但是对象类型变量的类型检查是在编译时发生的，而动态类型变量的类型检查是在运行时发生的。

			//字符串（String）类型  允许您给变量分配任何字符串值
			//C# string 字符串的前面可以加 @（称作"逐字字符串"）将转义字符（\）当作普通字符对待，比如
			string str = @"C:\Windows";
			//等价于：
			string str2 = "C:\\Windows";
			//和 Python 中的 r".." 一样嘛

		}

		public void pointer(){
			//指针类型（Pointer types） 和 c c++中的一样
		
		}

		public void cast(){
			// 类型转换分为 隐式转换（从小的整数类型转换为大的整数类型，从派生类转换为基类）和显示转换
			double d = 5673.74;
			int i;
			i = (int)d;

			//C# 提供了很多内置的类型转换方法 在Convert中
			//Convert.ToByte()
		}

		public void constTest(){
			const int a =10; //a is const

		}

		//值参数  复制参数的实际值给函数的形式参数，实参和形参使用的是两个不同内存中的值 

		public void paramTest(int a,int b){
		}

		//引用参数 这种方式复制参数的内存位置的引用给形式参数
		public void refParamTest(ref int a,ref int b){
		}

		//按输出传递参数  return 语句可用于只从函数中返回一个值。
		//但是，可以使用 输出参数 来从函数中返回两个值。输出参数会把方法输出的数据赋给自己，其他方面与引用参数相似。
		//当调用getValue(a,b) 返回之后， a b 的值会被改写
		public int getValue(out int x ,out int y)
		{
			int temp = 5;
			x = temp;
			y = 6;
			return 10;
		}

		public void nullable(){
			//nullable 类型（可空类型），可空类型可以表示其基础值类型正常范围内的值，再加上一个 null 值。
			int? a = null;
			double? b = 3.14;


			//Null 合并运算符(??)用于定义可空类型和引用类型的默认值
			//如果第一个操作数的值为 null，则运算符返回第二个操作数的值，否则返回第一个操作数的值。
			double? num1 = null;
			double? num2 = 3.14157;
			double num3;
			num3 = num1 ?? 5.34;
		}

	}
}

