using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        int answer = 0;
        
        for(int i = 0; i<absolutes.Length ; i++)
        {
            //조건연산자 조건식 ? true일때 : false일때
            answer += signs[i] ? absolutes[i] : -absolutes[i]; 
        }
        
        return answer;
    }
}