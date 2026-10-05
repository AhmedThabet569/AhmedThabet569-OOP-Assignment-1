public class Solution {
    public  int MaxOperations(int[] nums, int k)
 {
     Array.Sort(nums);
     int left = 0;
     int right = nums.Length - 1;
     int steps = 0;
     while (left < right)
     {
         if (nums[left] + nums[right] == k)
         {
             left++;
             right--;
             steps++;
         }
     else if (nums[left] + nums[right] < k)
     {
         left++;
     }
     else
     {
         right--;
     }
 }
     return steps;
 }
}