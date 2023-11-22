public class Solution {
    public int[] solution(long n) {
        string x = n.ToString();
        int[] answer = new int[x.Length];
        for(int i= 0; i <x.Length; i++)
        {
            answer[x.Length - i - 1] = int.Parse(x[i].ToString());
        }
        return answer;
    }
}