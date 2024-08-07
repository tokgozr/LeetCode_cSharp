public class Solution {
    public bool HaveConflict(string[] event1, string[] event2) 
       => event1[0].CompareTo(event2[1]) <= 0 && 
        event2[0].CompareTo(event1[1]) <= 0;
        
    }
