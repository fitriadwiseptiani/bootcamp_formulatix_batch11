class Program
{
	static void Main()
	{
		// 1 float  = 4B
		// LOH khusus untuk yang ukurannya lebih dari 85KB
		// LOH setara dengan Gen 2
		float[] myFloats = new float[100*1024]; //400KB
		Console.WriteLine(GC.GetGeneration(myFloats));
	}
}