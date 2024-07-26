public class Solution {
    public int SumOfMultiples(int n) {
        int sum = 0;
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = i + 1;
            if (array[i] % 3 == 0 || array[i] % 5 == 0 || array[i] % 7 == 0)
            {
                sum += array[i];
            }
        }
        return sum;
    }
}