using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Assignment8Ex2 : MonoBehaviour
{
    
    void Start()
    {
        string [] words={"cat", "dog", "car", "pizza", "hat", "fish", "tree", "monkey", "ball", "bird"};

        int counter = 0;
        
        string newSentence = "";
      
        while (counter < words.Length)
        {
           newSentence += words[Random.Range(0,words.Length)] + " ";
           counter++;
        }
        Debug.Log (newSentence);
    }


}
