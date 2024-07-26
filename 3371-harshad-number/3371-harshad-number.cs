public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        int sumNumber = 0;
        int temp = x;
        while ( temp > 0)
        {
            sumNumber += temp % 10;
            temp /= 10;
        }
        if (x % sumNumber == 0)
            return sumNumber;
        else
            return -1;
        
    }
}