using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment26
{
public class Kangaroo : Creature , IRunnable , IJumpable
{
    public void Run()
    {
        Debug.Log("Kangaroo is Run");
    }

    public void Jump()
    {
        Debug.Log("Kangaroo is Jump");
    }
    
}
}
