using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace Assignment29
{
public static class Utilities 
{
    public static int SumOfArray(params int[] numbers)
    {
         int sum = 0;

        foreach(int  num in numbers)
           sum+=num;
        return sum;
        
    }

    public static string RepearString(this string word , int repeatNum )
    {
        string sentence="";
        if(repeatNum>0)
        {
            for(int i=0 ; i< repeatNum ; i++)
             sentence += word;
        }
        return sentence;
       
    }
    
}
}
