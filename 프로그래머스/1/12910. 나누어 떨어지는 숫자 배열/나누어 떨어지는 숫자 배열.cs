using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
       // result 리스트를 만들어 준다.
        List<int> result = new List<int>();
        
        // 입력받은 arr의 길이만큼 for문을 돌면서 arr의 원소하나하나를 확인
        for(int i=0; i<arr.Length; i++)
        {
        	// arr의 원소 중 divisor로 나누어 떨어지면
            if(arr[i]%divisor == 0)
            {
            	// 아까 만든 리스트의 원소로 넣어준다.
                result.Add(arr[i]);
            }
        }
        
        // 만약 나눠떨어진게 없어서 리스트가 0개라면 -1을 출력
        if (result.Count == 0)
            return new int[] { -1 };
            
        // result리스트를 오름차순으로 정렬해준다.
        result.Sort();
        
        // 배열을 반환해달라고 했으므로 ToArray()를 써서 배열로 리턴함
        return result.ToArray();
    }
}