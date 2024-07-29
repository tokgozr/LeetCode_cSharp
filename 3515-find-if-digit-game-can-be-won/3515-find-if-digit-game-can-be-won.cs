public class Solution {
    public bool CanAliceWin(int[] nums) {
        int singleDigitSum = 0;
        int doubleDigitSum = 0;
        foreach(int i in nums)
        {
            if(Math.Abs(i)>=10 && Math.Abs(i)<=99)
            {
                doubleDigitSum += i;
            }
            else
            {
                singleDigitSum += i;
            }
        }
        return (singleDigitSum < doubleDigitSum || singleDigitSum > doubleDigitSum);
        
    }
}