using CodeUnderTest;
using Xunit;

namespace XUnit_19
{
    public class XUnit19Tests
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
