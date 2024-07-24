public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 1) return strs[0];

        string pre = "";
        int index = 0;
        while (index != strs[0].Length)
        {
            char compare = strs[0][index];
            for (int i = 1; i < strs.Length; i++)
            {
                if(index == strs[i].Length || strs[i][index] != compare)
                    return pre;
            }
            pre += compare;
            index ++;
        }
        return pre;
    }

}       