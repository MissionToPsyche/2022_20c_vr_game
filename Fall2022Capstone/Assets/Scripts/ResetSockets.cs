using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResetSockets : MonoBehaviour
{
    public XRSocketInteractor[] sockets;
    // Start is called before the first frame update
    
    public void turnOff()
    {
        foreach (var i in sockets)
        {
            i.socketActive = false;
        }
    }

    public void turnOn()
    {
        foreach (var i in sockets)
        {
            i.socketActive = true;
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
