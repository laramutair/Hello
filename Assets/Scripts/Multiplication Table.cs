using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Multipplication : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i <= 10; i++)
        {

            Debug.Log(i + " x 5 = " +Multiply(5, i)) ;
        }

        
    }

    int Multiply(int Num1, int Num2){

            return Num1 * Num2;
        }
}
