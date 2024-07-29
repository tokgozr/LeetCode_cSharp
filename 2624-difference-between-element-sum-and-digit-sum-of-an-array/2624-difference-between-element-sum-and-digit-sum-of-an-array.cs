public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int sum = 0;
        int digitsum = 0;
        foreach ( var n in nums)
            sum += n;
        foreach (var n in nums)
        {
            int m = n;
            while (m > 0)
            {
                int j = m % 10;
                m /= 10;
                digitsum += j;
            }
        }
        return sum - digitsum;
    }
}