using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
            // 입력된 문자열을 공백을 기준으로 잘라서 저장
            string[] temp = s.Split();
            // for문을 돌려서 문자열을 하나씩 호출함.
            for (int i = 0; i < temp.Length; i++)
            {
            // 호출된 문자열에서 차례로 문자 하나씩을 꺼냄
                for (int j = 0; j < temp[i].Length; j++)
                {
                // 0번째는 짝수 취급이므로 대문자로함
                    if (j == 0)
                    {
                        answer += Char.ToUpper(temp[i][j]);  //Char.ToUpper = 대문자
                        continue;
                    }
                    // 짝수는 대문자로, 홀수는 소문자로 바꿈
                    if (j % 2 == 0)
                    {
                        answer += Char.ToUpper(temp[i][j]);
                    }
                    else
                    {
                        answer += Char.ToLower(temp[i][j]);  //Char.ToLower = 소문자
                    }
                }
                // 띄어쓰기가 전부 생략되어있으므로 문자열이 하나 끝날때마다 띄어쓰기를 넣어줌.
                // 단, 마지막에는 띄어쓰기를 추가하면 안되므로 temp.Leght-1로 설정해준다.
                if (i != temp.Length-1)
                {
                    answer += " ";
                }
            }
            
            return answer;
    }
}