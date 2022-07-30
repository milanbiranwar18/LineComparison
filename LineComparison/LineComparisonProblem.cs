using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineComparisonProblem
    {
		public static void LineComparisonUC1()
		{
			Console.WriteLine("**Welcome to The Line Comparison Computation Program**");

			int x1, y1, x2, y2;
			Console.WriteLine("Enter the value of x1: ");
			x1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of x2: ");
			x2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y1: ");
			y1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the value of y2: ");
			y2 = Convert.ToInt32(Console.ReadLine());

			double length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);

			Console.WriteLine("The length of line is: " + length);

		}
	}
}
