using System.Numerics;

namespace LeetCode.LeetCode
{
    public class lc0003 : Solutions
    {
        /*        Given a string s, find the length of the longest substring without duplicate characters.

                Example 1:

                Input: s = "abcabcbb"
                Output: 3
                Explanation: The answer is "abc", with the length of 3. Note that "bca" and "cab" are also correct answers.
                Example 2:

                Input: s = "bbbbb"
                Output: 1
                Explanation: The answer is "b", with the length of 1.
                Example 3:

                Input: s = "pwwkew"
                Output: 3
                Explanation: The answer is "wke", with the length of 3.
                Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.



                Constraints:

                0 <= s.length <= 105
                s consists of English letters, digits, symbols and spaces.*/
        public override void Solution()
        {
            //var foo = LengthOfLongestSubstring("abcabcbb");
            //var goo = LengthOfLongestSubstring("bbbbb");
            //var boo = LengthOfLongestSubstring("pwwkew");
            //var soo = LengthOfLongestSubstring("S");
            var roo = LengthOfLongestSubstring("1R1T7");
        }

        public int LengthOfLongestSubstring(string s)
        {
            var lastVisited = new Dictionary<char, int>();
            int maxLength = 0;  

            for (int current = 0; current < s.Length; current++)
            {
                if (!lastVisited.ContainsKey(s[current]))
                {
                    lastVisited[s[current]] = current;
                    maxLength = Math.Max(maxLength, lastVisited.Max(x => x.Value) +1);
                }
                else
                {
                    lastVisited.Clear();
                    s = s[1..];
                    current = -1;
                }
            }
            return maxLength;




            //while (s.Length > 0)
            //{
            //    foreach (char c in s)
            //    {
            //        if (!set.Contains(c))
            //        {
            //            set.Add(c);
            //            temp += c.ToString();
            //        }
            //        else
            //        {
            //            dict[];
            //            set.Clear();
            //            break;
            //        }
            //    }
            //    dict.TryAdd(temp.ToString(), temp.Length);
            //    set.Clear();
            //    temp = "";
            //    s = s[1..];
            //}
            //dict.TryAdd(temp.ToString(), temp.Length);
            //return Int32.Parse(dict.Values.Max().ToString());
        }
    }
}
