// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;

class Program
{
	[DllImport("libexample.so")]
	public static extern void example_function();

	static void Main(string[] args)
	{
		Console.WriteLine("We are in C# code");
		example_function();
	}
}


