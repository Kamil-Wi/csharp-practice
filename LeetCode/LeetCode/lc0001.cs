namespace LeetCode.LeetCode
{  
    //You are given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //You can return the answer in any order.

    //Example 1:

    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0, 1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    //Example 2:

    //Input: nums = [3, 2, 4], target = 6
    //Output: [1, 2]
    //Example 3:

    //Input: nums = [3, 3], target = 6
    //Output: [0, 1]


    //Constraints:

    //2 <= nums.length <= 104
    //-109 <= nums[i] <= 109
    //-109 <= target <= 109
    //Only one valid answer exists.


    //Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
    public class lc0001 : Solutions
    {
        public override void Solution()
        {
            var foo = TwoSum(new int[] { 2, 7, 11, 15 }, 9);
            var boo = TwoSum(new int[] { 3, 2, 4 }, 6);
            var doo = TwoSum(new int[] { 3, 3 }, 6);
        }

        //4ms
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];
                if (dict.ContainsKey(diff))
                    return new int[2] { dict[diff], i };
                else
                    dict[nums[i]] = i;
            }
            return Array.Empty<int>();
        }        
        
        //30ms
        /*public int[] TwoSum(int[] nums, int target)
            {
                var result = new int[] { };
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++) 
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            result = new int[] { i, j };
                            return result;
                        }
                    }
                }
                return result;
            }*/
    }
}
