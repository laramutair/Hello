using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
public class TestingScript : MonoBehaviour
{
    // testing script for part 2
    CustomObject customObject1=new CustomObject(1, "Lara");
    CustomObject customObject2=new CustomObject(1, "Lamar");

    
    void Start()
    {   // testing script for part 2

        print(customObject1);
        print(customObject2 == customObject1);
        print(customObject2 != customObject1);




        // testing script for part 3

        Debug.Log(Utilities.SumOfArray(1,2,3));
        Debug.Log("Hello".RepearString(3));


  


        
    }

    
}
}
