namespace MinimumCostMakeArrayEqual
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MinimumCostMakeArrayEqualPrefixSum minimumCostMakeArrayEqualPrefixSum = new();
            Console.WriteLine(minimumCostMakeArrayEqualPrefixSum.MinCost(new int[] { 1, 3, 5, 2 }, new int[] { 2, 3, 1, 14 }));
			Console.WriteLine(minimumCostMakeArrayEqualPrefixSum.MinCost(new int[] { 2, 2, 2, 2, 2 }, new int[] { 4, 2, 8, 1, 3 }));
			MinimumCostMakeArrayEqualBinarySearch minimumCostMakeArrayEqualBinarySearch = new();
            Console.WriteLine(minimumCostMakeArrayEqualBinarySearch.MinCost(new int[] { 1, 3, 5, 2 }, new int[] { 2, 3, 1, 14 }));
            Console.WriteLine(minimumCostMakeArrayEqualBinarySearch.MinCost(new int[] { 2, 2, 2, 2, 2 }, new int[] { 4, 2, 8, 1, 3 }));
        }
	}
}