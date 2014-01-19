using System;
using Reign.Compiler;

namespace ReignCompiler
{
	class Program
	{
static string CsToCpp =
@"
using System;

namespace MyNamespace.Test.Test2
{
	/*
	Test stuff...
	*/

	// This is a vector type
	struct Vector
	{
		public float X, Y, Z;
	}

	public class MyClass2
	{
		protected: int a = 1, b = 2, c =3;
	}

	public class MyClass : MyClass2
	{
		private int index;
		private Vector vec;

		public void Foo(int index, Vector index2, double index3)
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

			var compiler = new CppCompiler(CsToCpp, CompilerInputTypes.CsCode, CompilerOutputTypes.Cpp_VC);
			compiler.Compile("Output/");
			Console.WriteLine("Done");
			Console.ReadLine();
		}
	}
}
