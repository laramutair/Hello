using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltInDelegatesExample : MonoBehaviour
{
    
    void Start()
    {
        //ActionDelegate

        Action<string>logMessage= (string message) => Debug.Log (message);
        logMessage?.Invoke("Hello");
        

        //Fun Delegate
        Func <int , int > square = (int num) => num * num;
        Debug.Log($"Square:  {square?.Invoke(5)}");

        //Predicate Delegate
        Predicate<int> isEven = (int num) => (num % 2 == 0);
        int test = 4;
        Debug.Log($"Is {test} even? {isEven(test)}");
        
    }

}
