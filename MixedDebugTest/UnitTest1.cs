namespace MixedDebugTest;
using System.Runtime.InteropServices;
using System.Diagnostics;

[TestClass]
public class UnitTest1
{
    [DllImport("libexample.so")]
	public static extern void example_function();

    [TestMethod]
    public void TestMethod1()
    {        
        Console.WriteLine($"This is a C# unit test: {Process.GetCurrentProcess().Id}");
        System.Threading.Thread.Sleep(50000);
        example_function();
    }
}
