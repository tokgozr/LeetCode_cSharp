public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int i = 1;
        int j = n;
        int[] result = new int[nums.Length];
        result[0] = nums[0];
        for (int k = 1; k < nums.Length;
        k++)
        {
            result[k] = (k % 2 == 1) ? nums[j++] : nums[i++];
        }
        return result;
    }
}