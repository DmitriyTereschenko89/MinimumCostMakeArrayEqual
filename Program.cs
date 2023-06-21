namespace MinimumCostMakeArrayEqual
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MinimumCostMakeArrayEqualPrefixSum minimumCostMakeArrayEqualPrefixSum = new();
            Console.WriteLine(minimumCostMakeArrayEqualPrefixSum.MinCost(new int[] { 1, 3, 5, 2 }, new int[] { 2, 3, 1, 14 }));
			Console.WriteLine(minimumCostMakeArrayEqualPrefixSum.MinCost(new int[] { 2, 2, 2, 2, 2 }, new int[] { 4, 2, 8, 1, 3 }));
			Console.WriteLine(minimumCostMakeArrayEqualPrefixSum.MinCost(new int[] { 735103, 366367, 132236, 133334, 808160, 113001, 49051, 735598, 686615, 665317, 999793, 426087, 587000, 649989, 509946, 743518 }, new int[] { 724182, 447415, 723725, 902336, 600863, 287644, 13836, 665183, 448859, 917248, 397790, 898215, 790754, 320604, 468575, 825614 }));
			MinimumCostMakeArrayEqualBinarySearch minimumCostMakeArrayEqualBinarySearch = new();
            Console.WriteLine(minimumCostMakeArrayEqualBinarySearch.MinCost(new int[] { 1, 3, 5, 2 }, new int[] { 2, 3, 1, 14 }));
            Console.WriteLine(minimumCostMakeArrayEqualBinarySearch.MinCost(new int[] { 2, 2, 2, 2, 2 }, new int[] { 4, 2, 8, 1, 3 }));
			Console.WriteLine(minimumCostMakeArrayEqualBinarySearch.MinCost(new int[] { 735103, 366367, 132236, 133334, 808160, 113001, 49051, 735598, 686615, 665317, 999793, 426087, 587000, 649989, 509946, 743518 }, new int[] { 724182, 447415, 723725, 902336, 600863, 287644, 13836, 665183, 448859, 917248, 397790, 898215, 790754, 320604, 468575, 825614 }));
		}
	}
}