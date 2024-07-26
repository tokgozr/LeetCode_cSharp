public class Solution {
    public int SubtractProductAndSum(int n) {
        int sum = 0;
        int mult = 1;
        while (n >0)
        {
            int digit = n %10;
            sum += digit;
            mult *= digit;
            n /= 10;
        }
        int result = mult - sum;
        return result;
    }
}