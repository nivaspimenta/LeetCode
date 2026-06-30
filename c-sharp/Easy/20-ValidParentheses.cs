#region Problem
/*

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 
Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false

Example 4:
Input: s = "([])"
Output: true

Example 5:
Input: s = "([)]"
Output: false

 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.

*/
#endregion
namespace LeetCode.Easy
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> brackets = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '['},
                {'}', '{'}
            };

            foreach(char c in s)
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);                    
                } else
                {
                    if(stack.Count == 0) return false;

                    if(stack.Pop() != brackets[c])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

/*

var solution = new ValidParentheses();

string pare = "()[]{}";

Console.WriteLine($"Input : {pare}\n Output : {solution.IsValid(pare)} ");

*/