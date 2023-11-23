using System;

public class Solution {
    public long solution(long n) {
        char[] charArray = n.ToString().ToCharArray();
        
        Array.Sort(charArray);
        
        Array.Reverse(charArray);
        
        return long.Parse(new string(charArray));
    }
}
