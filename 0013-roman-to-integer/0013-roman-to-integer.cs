public class Solution {
    public int RomanToInt(string s) {

        var chars = s.ToCharArray();
        var result = 0;
        var currValue = 0;
        for(var i = 0; i < chars.Length - 1; i++)
        {
            currValue = RomanNumerals(chars[i]);
            result += (RomanNumerals(chars[i+1]) > currValue ? -1 : 1) * currValue;
        }
        
        return result +  RomanNumerals(chars[chars.Length - 1]);
    }
    
    public int RomanNumerals(char c)
    {
        switch(c){
            case 'I' : return 1;
            case 'V' : return 5;
            case 'X' : return 10;
            case 'L' : return 50;
            case 'C' : return 100;
            case 'D' : return 500;
            case 'M' : return 1000;
        };  
        return 0;
    }
}