using System;

namespace test1
{
	public class ArrayTest
	{
		public ArrayTest ()
		{
			//声明一个数组不会在内存中初始化数组
			double[] balance;
			balance = new double[10];


			double[] balance2 = { 2340.0, 4523.69, 3421.0};

			int [] marks = new int[]  { 99,  98, 92, 97, 95};

			//forreach循环
			foreach (int j in marks )
			{
				int i = j-100;
				Console.WriteLine("Element[{0}] = {1}", i, j);
			}

			//多维数组定义
			int[,] a = new int[5, 2] {{0,0}, {1,2}, {2,4}, {3,6}, {4,8} };


			//交错数组 交错数组是数组的数组。
			int[][] scores = new int[5][];
			for (int i = 0; i < scores.Length; i++) {
				scores [i] = new int[4];
			}

			Console.WriteLine (marks [marks.Length - 1]);
			getAverage (marks, marks.Length);
			Console.WriteLine (marks [marks.Length - 1]);

		}

		//参数传递数组的方法
		void getAverage(int[] arr, int size)
		{
			arr [size - 1] = 10;
		}
	}
}

