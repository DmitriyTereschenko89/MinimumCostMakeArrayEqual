using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCostMakeArrayEqual
{
	internal class MinimumCostMakeArrayEqualPrefixSum
	{
		public long MinCost(int[] nums, int[] cost)
		{
			int n = nums.Length;
			int[][] numsCost = new int[n][];
			for (int i = 0; i < n; ++i)
			{
				numsCost[i] = new int[] { nums[i], cost[i] };
			}
			Array.Sort(numsCost, (a, b) => a[0] - b[0]);
			long[] prefixSum = new long[n + 1];
			for (int i = 0; i < n; ++i)
			{
				prefixSum[i + 1] = prefixSum[i] + numsCost[i][1];
			}
			long totalCost = 0;
			for (int i = 1; i < n; ++i)
			{
				totalCost += 1L * numsCost[i][1] * (numsCost[i][0] - numsCost[0][0]);
			}
			long minCost = totalCost;
			for (int i = 1; i < n; ++i)
			{
				int gap = numsCost[i][0] - numsCost[i - 1][0];
				totalCost += 1L * prefixSum[i] * gap;
				totalCost -= 1L * (prefixSum[n] - prefixSum[i]) * gap;
				minCost = Math.Min(minCost, totalCost);
			}
			return minCost;
		}
	}
}
