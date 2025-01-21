using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastDelegateExample : MonoBehaviour
{
    public delegate void MathOperation ( int number);
    void DoubleNumber(int number) => Debug.Log($"Double Number: {number * 2}");

    void SquareNumber(int number) => Debug.Log($"Square Number: {number * number}");

    void CubeNumber(int number) => Debug.Log($"Cube Number: {number * number * number}");

    void Start()
    {
        MathOperation operation;
        operation= null;
        operation+= DoubleNumber;
        operation+= SquareNumber;
        operation+= CubeNumber;



        operation?.Invoke(5);
        
    }

}
