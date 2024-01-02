using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        // 문자열을 각각의 단일문자들로 저장
        char[] temp = s.ToCharArray();

        // 배열 정렬
        Array.Sort(temp);
        // 배열 역순
        Array.Reverse(temp);

        // 단일문자 배열을 다시 문자열로 재구성
        answer = new string(temp);
        
        return answer;
    }
}