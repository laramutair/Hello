using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListMethodsExample : MonoBehaviour
{
    void Start()
    {
        
        List<int> numbers = new List<int>{ 3, 1, 4, 1, 5, 9 };
        numbers.Sort((int x , int y) => y.CompareTo(x));
        Debug.Log(string.Join(", " , numbers));


        List<int> numbers2 = new List<int>{ 3, 1, 4, 1, 5, 9, 2, 6};
        List<int> filteredNumbers = numbers2.FindAll((int i)=> i % 2 == 0);
        Debug.Log(string.Join(", " , filteredNumbers));

        
    }

    
}
