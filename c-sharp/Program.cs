using LeetCode.Easy;

var solution = new LongestCommonPref();

string[] strg = ["abc"];

Console.WriteLine($"Array: [ {string.Join(", ", strg)} ] \nPrefix: {solution.LongestCommonPrefix(strg)}");