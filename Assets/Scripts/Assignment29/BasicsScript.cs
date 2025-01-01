using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assignment29
{
public class BasicsScript : MonoBehaviour
{
    
    void Start()
    {
        var name = "Lara";
        var number = 22;
        var isStudent = true;

        Debug.Log( number % 2 == 0 ? $" The number { number } is EVEN" :$"the number { number } is ODD"); 

        Debug.Log($"Current Date: {DateTime.Now.Date}");
        Debug.Log($"Current Time: {DateTime.Now.TimeOfDay}");
        Debug.Log($"Current Day:  {DateTime.Now.DayOfWeek}");


    }

    
}
}
