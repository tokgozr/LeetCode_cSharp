public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
         List<int> result = new List<int>();

        for (int i = left; i <= right; i++)
        {
            if (SelfDivide(i)) result.Add(i);
        }
        
        return result;
    }
    private bool SelfDivide(int n)
    {
        int number = n;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit == 0) return false;
            if (n % digit != 0) return false;
            number /= 10;
        }
        return true;
        
    }
}