public class Solution {
    public bool SquareIsWhite(string nums) {
         if((nums[0]%2!=0&&nums[1]%2==0)||nums[0]%2==0&&nums[1]%2!=0) 
         return true;
            else 
            return false;

        
    }
}