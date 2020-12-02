using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace SampleApp.Test
{
	[TestClass]
	public class ObjectConverterTest
	{
		[TestMethod]
		public void TestgetJson()
		{

			ObjectConverter oc = new ObjectConverter();
		 	JToken mval =oc.getJson();

			Assert.IsTrue(mval.ToString().Contains("FirstName"));
		}
	}
}
