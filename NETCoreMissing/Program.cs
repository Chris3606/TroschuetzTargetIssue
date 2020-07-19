using System;
using Troschuetz.Random;

namespace NETCoreMissing
{
	// Trivial sample implementation of IGenerator
	class MyGenerator : IGenerator
	{
		public bool Reset() => true;

		public bool Reset(uint seed) => true;

		public int Next() => 1;

		public int NextInclusiveMaxValue() => 1;

		public int Next(int maxValue) => maxValue - 1;

		public int Next(int minValue, int maxValue) => minValue;

		public double NextDouble() => 1.0;

		public double NextDouble(double maxValue) => maxValue - 1;

		public double NextDouble(double minValue, double maxValue) => maxValue - 1;

		public uint NextUInt() => 1;

		public uint NextUIntExclusiveMaxValue() => 1;

		public uint NextUIntInclusiveMaxValue() => 1;

		public uint NextUInt(uint maxValue) => 1;

		public uint NextUInt(uint minValue, uint maxValue) => 1;

		public bool NextBoolean() => true;

		public void NextBytes(byte[] buffer) => buffer[0] = 1;

		public uint Seed { get; }
		public bool CanReset { get; }

		// Fails to compile; method doesn't exist in this target.  I can of course implement it publicly,
		// but it's not available on IGenerator like it could be.  If you change the project to target .NET Core
		// 3.0 or .NET Core 3.1, this no longer errors
		void IGenerator.NextBytes(Span<byte> buffer) => buffer[0] = 1;
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Sanity check to prove that span exist on .NET Core 2.2
			byte[] myArr = new byte[10];
			Span<byte> x = myArr;
			x[1] = 10;
			Console.WriteLine($"X[1]: {x[1]}");
		}
	}
}
