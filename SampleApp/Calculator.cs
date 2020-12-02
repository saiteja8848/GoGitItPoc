using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{

	/// <summary>
	///  Sample Calculator App
	/// </summary>
    public class Calculator
    {
		int a;
		int b;

		/// <summary>
		/// Constructor for creating calculator
		/// </summary>
		/// <param name="a">first param</param>
		/// <param name="b">second param</param>
		public Calculator(int a, int b)
		{
			this.a = a;
			this.b = b;
		}

		public int Add()
		{
			return a + b;
		}

		public int Subtract()
		{
			return a - b;
		}

		public int Multiply()
		{
			return a * b;
		}

		public int Divide()
		{
			return a / b;
		}
    }
}
