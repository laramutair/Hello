using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int numOfLives=3;
        while(numOfLives>0)
        {

            if (numOfLives==3)
               Debug.Log("You have" + numOfLives + " lives");
            else if (numOfLives == 1 )
               Debug.Log("The last life");
            numOfLives--;
        }

        Debug.Log("Game Over!");
    }


}
