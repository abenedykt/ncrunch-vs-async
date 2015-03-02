using System.Threading.Tasks;

namespace CodeUnderTest
{
    public class CodeToTest
    {
	    private readonly string _message;

	    public CodeToTest(string message)
	    {
		    _message = message;
	    }

	    public async Task<string> Execute()
	    {
		    await Other();
		    var millisecondsDelay = await SomeLongOperation();

		    return await Task.Factory.StartNew(() =>
		    {
			    Task.Delay(millisecondsDelay);
			    return _message;
		    });
	    }

	    private static Task Other()
	    {
		    return Task.Factory.StartNew(() =>
		    {
			    Task.Delay(100);
		    });
	    }

	    private static async Task<int> SomeLongOperation()
	    {
		    var operation1 = await Task.Factory.StartNew(() =>
		    {
			    Task.Delay(100);
			    return 1000;
		    });
		    return operation1;
	    }
    }
}
