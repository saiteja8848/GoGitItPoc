using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleApp.Test
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void CalclulatorOperations()
		{
			Calculator calc = new Calculator(5,4);
			Assert.AreEqual(9, calc.Add());
			Assert.AreEqual(1, calc.Subtract());
			Assert.AreEqual(20, calc.Multiply());
			Assert.AreEqual(1, calc.Divide());
		}

		[TestMethod]
		public void testOPeration()
		{
			Assert.IsTrue(true);
		}

		[TestMethod]
		public void TestAddOperation()
		{
			Calculator calc = new Calculator(1,1);
			Assert.AreEqual(2, calc.Add());
		}
	}
}
