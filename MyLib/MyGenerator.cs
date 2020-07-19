using Troschuetz.Random;

namespace MyLib
{
	// Trivial sample implementation of IGenerator.
	public class MyGenerator : IGenerator
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

		// Can't implement this; we target .NET Standard 2.0 and Span isn't supported on that target.
		//void IGenerator.NextBytes(Span<byte> buffer) => buffer[0] = 1;
	}
}
