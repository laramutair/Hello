using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
        void Start()
    {
        int counter=0;
        while(counter<20){

            int RandomValue=Random.Range(1,21);

            Debug.Log(RandomValue);

            if (RandomValue == 5 )continue;

            else if (RandomValue == 15 )break;

            counter++;

        }

        
    }

}
