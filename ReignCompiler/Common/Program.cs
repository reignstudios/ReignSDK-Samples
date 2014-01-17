using System;
using Reign.Compiler;

namespace ReignCompiler
{
	class Program
	{
static string CsToCpp =
@"
using System;

namespace MyNamespace
{
	public class MyClass
	{
		private int index;

		public void Foo(int index)
		{
			this.index = index;
		}
	}
}
";

		static void Main(string[] args)
		{
			//if (args == null || args.Length == 0)
			//{
			//	Console.WriteLine("Program requires args...");
			//	return;
			//}

			var compiler = new CppCompiler(CsToCpp, CompilerInputTypes.CsCode, CompilerOutputTypes.Cpp);
			compiler.Compile("Output/");
			Console.WriteLine("Done");
			Console.ReadLine();
		}
	}
}
