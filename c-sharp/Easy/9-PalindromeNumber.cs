# region Problem
/*

    Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.
Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
 

Constraints:

-231 <= x <= 231 - 1
 

Follow up: Could you solve it without converting the integer to a string?

*/
#endregion
namespace LeetCode.Easy
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            // check if is a negative number
            if(x < 0) return false;
            

            int number = x;
            int reversed = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversed = reversed * 10 + digit;
                number = number / 10;
            }
        
            return x == reversed;
        }
    }
}

/*

-- Paste on the program.cs --

using LeetCode.Easy;

var solution = new PalindromeNumber());


*/