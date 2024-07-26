public class Solution {
    public int CountDigits(int num) {
        int count = 0, x;
        x = num;
        while (x!= 0)
        {
            if (num % (x % 10) == 0)
            {
                count++;  
            } 
            x = x /10; 
        }
        
        return count;
    }
}