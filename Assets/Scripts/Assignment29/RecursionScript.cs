using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
public class RecursionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(FibonacciRecursive(6));
        Debug.Log(FibonacciIterative(6));
        Debug.Log(FibonacciIterative(1));
        Debug.Log(FibonacciIterative(0));
        Debug.Log(FibonacciIterative(-2));



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    int previous=0;
    int fibo =1;

    int FibonacciIterative(int n)
    {
        if(n==0) return 0;
        else if (n==1) return 1;
        else if (n<0) return -1;
        else
        {
            for(int i=2 ; i<=n ; i++)
            {
            int next = previous + fibo;
                previous = fibo;
                fibo = next;
            }
            return fibo;
        }
        
    }
}
}
