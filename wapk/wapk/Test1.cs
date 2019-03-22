/*
 * Created by SharpDevelop.
 * User: Filip
 * Date: 22.03.2019
 * Time: 10:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;

namespace Hello_World
{
	[TestFixture]
	public class Test1
	{
		[Test]
		public void TestMethod()
		{
			Program obj = new Program();
			int sum = obj.add_number(20,22);
			Assert.AreEqual(42,sum);
		}
	}
}
