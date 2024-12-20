using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment27
{
public class CallByReference : MonoBehaviour
{ 
    int a;
    int b;
    int value;
    
    void Start()
    {
        a = 10;
        b = 0;

        
        Debug.Log("the initial of a is: " + a);
        CallbyValue(a);
        Debug.Log("After Call By Value");
        Debug.Log(a);

        Debug.Log("the initial of b is: " + b);
        CallbyRef(ref b);
        Debug.Log("After Call By Ref");
        Debug.Log(b);

        CallbyOut(out value);
        Debug.Log("After Call By Out ");
        Debug.Log(value);

    }

   
    public void CallbyValue(int num)
    {
        num += 10;
    }

    public void CallbyRef(ref int num)
    {
        num += 10;
    }

    public void CallbyOut(out int num)
    {
        num = 10;
    }

    
}
}
