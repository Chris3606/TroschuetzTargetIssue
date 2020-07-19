using System;

namespace UserApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// This project targets .NET Core 3.1, and references MyApp (a .NET Standard 2.0 project).
			// MyApp uses Troschuetz.Random, and implements IGenerator via MyGenerator.
			// This package's target is used to determine targets for all dependencies.  This package
			// targets on .NET Core 3.1, so the .NET Standard 2.1 target is chosen for Troschuetz.Random.
			// But that target expects the Span overload to be implemented, even though the package implementing
			// MyGenerator is targeting .NET Standard 2.0 and is incapable of implementing it.  When run, this project
			// yields the following exception:
			// Unhandled exception. System.TypeLoadException: Method 'NextBytes' in type 'MyLib.MyGenerator' from assembly
			// 'MyLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' does not have an implementation.
			var generator = new MyLib.MyGenerator();
			Console.WriteLine(generator.Next(1));
		}
	}
}
