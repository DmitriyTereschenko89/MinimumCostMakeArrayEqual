using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumCostMakeArrayEqual
{
	internal class MinimumCostMakeArrayEqualBinarySearch
	{
		private long GetScore(int[] nums, int[] cost, int baseValue)
		{
			long score = 0;
			for (int i = 0; i < nums.Length; ++i)
			{
				score += 1L * Math.Abs(nums[i] - baseValue) * cost[i];
			}
			return score;
		}
		public long MinCost(int[] nums, int[] cost)
		{
			int minValue = int.MaxValue;
			int maxValue = int.MinValue;
			foreach(int num in nums)
			{
				minValue = Math.Min(minValue, num);
				maxValue = Math.Max(maxValue, num);
			}
			long minCost = GetScore(nums, cost, nums[0]);
			while(minValue < maxValue)
			{
				int middle = (minValue + maxValue) / 2;
				long score1 = GetScore(nums, cost, middle);
				long score2 = GetScore(nums, cost, middle + 1);
				minCost = Math.Min(score1, score2);
				if (score1 > score2)
				{
					minValue = middle + 1;
				}
				else
				{
					maxValue = middle;
				}

			}
			return minCost;
		}
	}
}
