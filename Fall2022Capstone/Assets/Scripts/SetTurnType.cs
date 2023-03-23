using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    public ActionBasedContinuousTurnProvider contTurn;
    public ActionBasedSnapTurnProvider snapTurn;

    // Start is called before the first frame update
    public void SetTypeFromIndex(int index)
    {
        if(index == 0)
        {
            snapTurn.enabled = false;
            contTurn.enabled = true;
        }
        else if(index == 1)
        {
            contTurn.enabled = false;
            snapTurn.enabled = true;
        }
    }

    
}
