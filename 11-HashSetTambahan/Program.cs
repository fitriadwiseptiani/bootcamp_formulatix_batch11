// HashSet Union
using System.Collections.Generic;

class Program
{
	static void Main ()
	{
		HashSet<int> A = new () { 1, 2, 3 };
		HashSet<int> B = new () { 3,4,5,6,7 };
		
		A.UnionWith(B);
		Console.WriteLine(A);
		
	}
}

// HashSet Intersect

// class Program
// {
// 	static void Main ()
// 	{
// 		HashSet<int> A = new () { 1, 2, 3 };
// 		HashSet<int> B = new () { 3,4,5,6,7 };
		
// 		A.IntersectWith(B);
// 		Console.WriteLine(A);
// 	}
// }

// HashSet Except

// class Program
// {
// 	static void Main ()
// 	{
// 		HashSet<int> A = new () { 1, 2, 3 };
// 		HashSet<int> B = new () { 3,4,5,6,7 };
		
// 		A.Except(B);
// 		Console.WriteLine(A);
		
// 	}
// }


// HashSet Subset Superset

// class Program
// {
// 	static void Main ()
// 	{
// 		HashSet<int> A = new () { 1, 2, 3 };
// 		HashSet<int> B = new () { 1,2,3,4,5,6,7 };
		
// 		bool status = A.IsSupersetOf(B);
// 		Console.WriteLine(status);
		
// 		bool status2 = A.IsSubsetOf(B);
// 		Console.WriteLine(status2);
		
// 		bool status3 = B.IsSupersetOf(B);
// 		Console.WriteLine(status3);
		
// 	}
// }