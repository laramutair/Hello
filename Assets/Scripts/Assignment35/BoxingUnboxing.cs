using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxingUnboxing : MonoBehaviour
{
    int health = 100;
    object Box ;
        void Start()
    {
         Debug.Log($"Original int value: {health}");


         // Boxing
        Box = health;  
        Debug.Log($"Box: {Box}");


        //UnBoxing
        int unboxingHealth = (int) health;   
        unboxingHealth -= 10;
        Debug.Log($"UNBox: {unboxingHealth}");

    }

    
}
