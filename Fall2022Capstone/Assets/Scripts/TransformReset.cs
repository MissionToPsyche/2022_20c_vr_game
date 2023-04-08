using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct PositionAndRotation{
    public Vector3 position;
    public Quaternion rotation;
}

public class TransformReset : MonoBehaviour
{
    public GameObject parentObj;
    // Start is called before the first frame update
    Dictionary<Transform, PositionAndRotation> initialPositions = new Dictionary<Transform, PositionAndRotation>();
    
    //store the original positions of the list of game objects
    void Start()
    {
     Transform[] childList = parentObj.GetComponentsInChildren<Transform>();
     //Transform[] originalPositions;
     //int x = 0;
     foreach(var i in childList)
     {
       // set everything stationary
       var rb = i.GetComponent<Rigidbody>();
       rb.velocity = Vector3.zero;
       rb.angularVelocity = Vector3.zero;

       //store the initial transform of the individual books
        PositionAndRotation pandr;
        pandr.position = i.transform.position;
        pandr.rotation = i.transform.rotation;
        initialPositions[i.transform] = pandr;
     }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // set the position of the list of gameObjects back to their original positions
    public void reset()
    {
     //int x = 0;
     Transform[] childList = parentObj.GetComponentsInChildren<Transform>();
     foreach(var i in childList)
     {
        //i.localPosition = Vector3.zero;
     }

     foreach (var pair in initialPositions) {
        Transform t = pair.Key;
        t.position = pair.Value.position;
        t.rotation = pair.Value.rotation;
        var rb = t.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        }
    }
}
