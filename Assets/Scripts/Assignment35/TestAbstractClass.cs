using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAbstractClass : MonoBehaviour
{
    
    void Start()
    {
        DerivedClassExample derivedClassExample= new DerivedClassExample();
        derivedClassExample.PerformAction();
        derivedClassExample.PrintInfo();

        
    }

   
}
