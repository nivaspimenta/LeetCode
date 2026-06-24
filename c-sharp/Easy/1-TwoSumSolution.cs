# region Problem
/*

Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.

*/
#endregion

namespace LeetCode.Easy
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            
            List<int> values = new List<int>();
            for (int x = 0; x <= nums.Length - 1; x++)
            {
                for (int y = x + 1; y <= nums.Length - 1; y++)
                {
                    if(nums[x] + nums[y] == target)
                    {
                        return new int[] { x , y };
                    }
                }
            }
            return Array.Empty<int>();
        }
    }
}

/*

-- Paste on the program.cs --

using LeetCode.Easy; // Normally is present on the Program.cs

var solution = new TwoSumSolution();

int[] result = solution.TwoSum(new int[] {2, 2, 3, 4, 5}, 9);

Console.WriteLine($"Output: [{String.Join(", ", result)}]");

*/