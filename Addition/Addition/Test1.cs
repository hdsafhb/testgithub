/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 22.03.2019
 * Time: 10:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Addition
{
	[TestFixture]
	public class Test1
	{
		[Test]
		public void TestMethod()
		{
			MainForm obj = new MainForm();
			int sum = obj.sum(22,20);
			Assert.AreEqual(42,sum,"Summe");
		}
		[Test]
		public void TestMethod2()
		{
			MainForm obj = new MainForm();
			int sum = obj.sum(-2,-20);
			Assert.AreEqual(-42,sum,"Summe");
		}
	}
}
