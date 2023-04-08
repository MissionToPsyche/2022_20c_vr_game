using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    
    public Transform head;
    public float spawnDistance = 2;
    public GameObject menu;
    public InputActionProperty showButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPressedThisFrame())
        {
            // turns on menu with button
            menu.SetActive(!menu.activeSelf);

            // Spawns menu in front of player
            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }

        // Makes Menu face player
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z) );
        // flips menu to correct orientation
        menu.transform.forward *= -1;
    }
}
