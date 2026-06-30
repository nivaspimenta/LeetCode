#region Problem
/*

Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"


Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.

*/
#endregion
namespace LeetCode.Easy
{

    public class LongestCommonPref
    {
        public string LongestCommonPrefix(string[] strs)
        {
            Console.WriteLine("Array size: " + strs.Length);

            string prefix = "";

            for (int x = 0; x < strs.Length; x++)
            {
                for (int y = 1; y <= strs[x].Length; y++)
                {
                    string candidate = strs[x].Substring(0, y);
                    int _precount = 0;

                    for (int z = 0; z < strs.Length; z++)
                    {
                        if (x == z) continue;

                        if (strs[z].StartsWith(candidate))
                        {
                            _precount++;
                        }
                    }

                    if (_precount == strs.Length - 1 && candidate.Length > prefix.Length)
                    {
                        prefix = candidate;
                    }
                }
            }

            return prefix;
        }
    }

}


/*


-- Paste on the program.cs --

using LeetCode.Easy; // Normally is present on the Program.cs

string[] strg = ["abc"];

Console.WriteLine($"Array: [ {string.Join(", ", strg)} ] \nPrefix: {solution.LongestCommonPrefix(strg)}");


*/