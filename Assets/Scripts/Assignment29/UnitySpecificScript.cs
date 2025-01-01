using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
public class UnitySpecificScript : MonoBehaviour
{
    GameObject TargetObject;
    GameObject JokerObject;
    Light lightObject;



    void OnEnable()
    {
        print("GameObject Enabled");
    }
   
    void Start()
    {
        Debug.Log("Game started");
        TargetObject = GameObject.Find("TargetObject");
        if(TargetObject != null)
           print($"The name of the object {TargetObject.name}");
        else
           print("No TargetObject object found");


        JokerObject = GameObject.FindGameObjectWithTag("Joker");
        if(JokerObject != null)
           print($"The name of the object {JokerObject.name}");
        else
           print("No Joker object found");


        lightObject = GameObject.FindObjectOfType<Light>();
        if(lightObject != null)
           print($"The name of the object {lightObject.name}");
        else
           print("No Joker object found");

        
        
    }

    
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.D))
        {
            if(TargetObject != null)
            {
                TargetObject.SetActive(false);
                print("TargetObject deactivated!");
            }
          
        }
        
    }

    void OnDisable()
    {
        
        print("GameObject Disabled");

    }
}
}
