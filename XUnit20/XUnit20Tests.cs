using CodeUnderTest;
using Xunit;

namespace XUnit20
{
	public class XUnit20Tests
	{
		[Fact]
		public async void TestName()
		{
			var sut = new CodeToTest("you shall not PASS");
			var result = await sut.Execute();

			Assert.Equal("Hello world", result);
		}

	}
}
