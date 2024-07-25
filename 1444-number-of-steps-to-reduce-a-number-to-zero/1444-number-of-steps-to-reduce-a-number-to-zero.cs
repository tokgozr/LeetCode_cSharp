public class Solution {
    public int NumberOfSteps(int num) {
        int steps = 0;
        return Process(num, steps);
        
    }

    public int Process(int num, int steps)
    {
        if (num == 0) return steps;

        else if (num % 2 == 0) num = num / 2;

        else num -=1;

        steps++;
        return Process(num, steps);
    }   


}