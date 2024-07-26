public class Solution {
    public int SubsetXORSum(int[] nums) {
        int n = nums.Length;
        int totalSum = 0;
        for (int i= 0; i < (1 << n); i++)
        {
            int currX0R = 0;
            for (int j = 0; j< n; j++)
            {
                if((i & (1 << j)) != 0)
                {
                    currX0R ^= nums[j];
                }
            }
            totalSum += currX0R;
        }
        return totalSum;
    }
}