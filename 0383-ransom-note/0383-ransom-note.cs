public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        var list = new List<char>(ransomNote);
        var counter = 0;
        foreach (var letters in magazine)
        {
            if(list.Remove(letters))  counter++;
        }   

        return ransomNote.Length == counter;
        
    }
}