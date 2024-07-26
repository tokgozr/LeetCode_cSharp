public class Solution {
    public int MinimumSum(int num) {
       int [] array = new int[4];
       int fPair = 0;
       int sPair = 0;
       for (int i = 0; i < 4; i++)
       {
        array[i] = num % 10;
        num /= 10;
       } 
       Array.Sort(array);
       fPair = array[0] * 10 + array[3];
       sPair = array[1] * 10 + array[2];
       return fPair + sPair;
    }
}