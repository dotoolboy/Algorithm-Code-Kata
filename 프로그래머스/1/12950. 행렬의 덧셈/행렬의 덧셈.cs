public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        
        // GetLength 는 Array 안에 요소의 수
        // 이차원 배열은 Length가 아닌 GetLength를 써야함
        int[,] answer = new int[arr1.GetLength(0),arr1.GetLength(1)];
            
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                answer[i, j] = arr1[i, j] + arr2[i, j];
            }
        }
        return answer;
    }
}