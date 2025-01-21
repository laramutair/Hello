using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventExample : MonoBehaviour
{
    public UnityEvent onEventTriggered;
    void Start()
    {
        onEventTriggered = new UnityEvent();
        onEventTriggered.AddListener(onEventResponce);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyUp(KeyCode.Space))
        {
            onEventTriggered?.Invoke();
        }
        
    }

    public void onEventResponce()
    {
        Debug.Log("The event has been triggrred!");
    }

    
}
