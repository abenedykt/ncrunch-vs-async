using CodeUnderTest;
using NUnit.Framework;

namespace NUnit
{
	public class NUnitTests
	{
		[Test]
		public async void TestName()
		{
			var sut = new CodeToTest("you shall not PASS");
			var result = await sut.Execute();

			Assert.AreEqual("Hello world", result);
		}

	}

}
