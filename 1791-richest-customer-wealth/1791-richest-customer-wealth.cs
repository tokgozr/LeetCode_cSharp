public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int sum = 0;
    int before = 0;
    for (int i = 0; i < accounts.Length; i++)
    {
        for (int j = 0; j < accounts[i].Length; j++)
        {
            sum += accounts[i][j];
        }
    sum = sum > before ? sum : before;

        before = sum;
        sum = 0;
    }
    return before;
        
    }
}