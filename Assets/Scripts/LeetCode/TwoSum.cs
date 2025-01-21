using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoSum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] arr = {1,4,5,3};

        int [] result = TwoSums( arr , 7);

        Debug.Log($"[{result[0]} , {result[1]} ]");
        
    }
    public static int[] TwoSums(int[] nums, int target)
    {
        int[] TwoSumArr = new int [2];

        for (int i = 0 ; i< nums.Length - 1 ; i++)
        {
            for ( int j = 1 + i ; j< nums.Length ; j++ )
            {
                if ( nums[i] + nums[j] == target)
                {

                    return new int[] {nums[i], nums[j]};

                }
            }
       
        }
            return new int[0] {};
        
    }
}
