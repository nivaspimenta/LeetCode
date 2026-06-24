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

using LeetCode.Easy;

var solution = new TwoSumSolution();

int[] result = solution.TwoSum(new int[] {2, 2, 3, 4, 5}, 9);

Console.WriteLine($"Output: [{String.Join(", ", result)}]");
*/