using System;

namespace test1
{
	//类的默认访问修辞符号是internal ，应用程序内可访问，类内部成员默认为private
	//通过在类定义前面放置关键字 sealed，可以将类声明为密封类。
	//当一个类被声明为 sealed 时，它不能被继承。抽象类不能被声明为 sealed。
	sealed public class ClassTest
	{
		//static 同java
		public static int num;
		//构造函数
		public ClassTest ()
		{
		}
		//析构函数它不返回值，也不带任何参数，不能继承或重载
		~ClassTest(){
			
		}
	}

	abstract class Rectangle
	{
		// 成员变量
		protected double length;
		protected double width;
		public Rectangle(double l, double w)
		{
			length = l;
			width = w;
		}
		public double GetArea()
		{
			return length * width;
		}
		public void Display()
		{
			Console.WriteLine("长度： {0}", length);
			Console.WriteLine("宽度： {0}", width);
			Console.WriteLine("面积： {0}", GetArea());
		}

		public abstract void test1();


	}//end class Rectangle

	//继承 C# 不支持多重继承。但是，您可以使用接口来实现多重继承（这个倒是和java一样 c++是怪胎！）
	class Tabletop : Rectangle
	{
		private double cost;
		//列表构造函数初始化
		public Tabletop(double l, double w) : base(l, w)
		{ 
		}
		public double GetCost()
		{
			double cost;
			cost = GetArea() * 70;
			return cost;
		}
		public void Display()
		{
			//使用base关键字而不是java 中的super
			base.Display();
			Console.WriteLine("成本： {0}", GetCost());
		}

		public override void test1(){
		}
	}

//	多态性意味着有多重形式。在面向对象编程范式中，多态性往往表现为"一个接口，多个功能"。
//	多态性可以是静态的或动态的。在静态多态性中，函数的响应是在编译时发生的。在动态多态性中，函数的响应是在运行时发生的。

//	静态多态性分别为：
//	函数重载
//	运算符重载

//	动态多态性  注意重写这两种函数的时候必须在前面加上override关键字
//	C# 允许您使用关键字 abstract 创建抽象类
//  虚方法 virtual 

	//运算符重载
	class Box
	{
		private double length;      // 长度
		private double breadth;     // 宽度
		private double height;      // 高度

		public double getVolume()
		{
			return length * breadth * height;
		}
		public void setLength( double len )
		{
			length = len;
		}

		public void setBreadth( double bre )
		{
			breadth = bre;
		}

		public void setHeight( double hei )
		{
			height = hei;
		}
		// 重载 + 运算符来把两个 Box 对象相加
		public static Box operator+ (Box b, Box c)
		{
			Box box = new Box();
			box.length = b.length + c.length;
			box.breadth = b.breadth + c.breadth;
			box.height = b.height + c.height;
			return box;
		}

	}
		
//	+, -, !, ~, ++, --	这些一元运算符只有一个操作数，且可以被重载。
//	+, -, *, /, %	这些二元运算符带有两个操作数，且可以被重载。
//	==, !=, <, >, <=, >=	这些比较运算符可以被重载。
//	&&, ||	这些条件逻辑运算符不能被直接重载。
//	+=, -=, *=, /=, %=	这些赋值运算符不能被重载。
//		=, ., ?:, ->, new, is, sizeof, typeof	这些运算符不能被重载。

}

