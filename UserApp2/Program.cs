using System;
using GoRogue.Random;

namespace UserApp2
{
	class Program
	{
		// Proof that the same problem plaguing UserApp also happens if the intermediate library is installed via NuGet.
		// This package references GoRogue, a .NET Standard 2.0 package that implements IGenerator.  Trying to
		// use one yields the same problem as in UserApp: runtime exception
		static void Main(string[] args)
		{
			var ints = new int[] { 1, 2, 3 };
			var generator = new KnownSeriesGenerator(ints); // One of GoRogue's IGenerator implementations

			Console.WriteLine(generator.Next());
		}
	}
}
