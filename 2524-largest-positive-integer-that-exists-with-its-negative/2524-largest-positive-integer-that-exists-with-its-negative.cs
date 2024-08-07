public class Solution {
    public int FindMaxK(int[] nums) {
        Array.Sort(nums);
        int maxK = -1;

        int left = 0, right = nums.Length - 1;
        while(left<right){
            int sum = nums[left] + nums[right];
            if (sum == 0){
                maxK= Math.Max(maxK, Math.Abs(nums[right]));
                left++;right--;

            }
            else if (sum < 0)
                left++;
            else
                right--;

        }
       return maxK; 
    }
}