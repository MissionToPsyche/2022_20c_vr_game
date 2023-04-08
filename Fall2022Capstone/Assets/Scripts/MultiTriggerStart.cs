using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTriggerStart : MonoBehaviour
{
    public GameObject triggerObj;
    public int counter = 0;

    public int triggers;
    
    // Start is called before the first frame update
    /*void Start()
    {
        //counter = 0;
        resetCount();
        triggerObj.SetActive(false);
    }*/

    public void incrementTriggers()
    {
        counter++;

        if(triggers == counter)
        {
            turnOn();
            //triggerObj.enabled = true;
        }
    }

    public void decrementTriggers()
    {
        counter--;

    }

    public void turnOn()
    {
        triggerObj.SetActive(true);
    }

    public void resetCount()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(triggers != counter)
        {
            //triggerObj.SetActive(false);
        }
    }
}
