using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_08 : MonoBehaviour
{
    // monobehaviour scripting wizard
    // ctrl+shift+m for unity methods

    private void FixedUpdate()
    {
        // called each physics step on consistent intervals
        // used with rigidbody objects
        Debug.Log("Fixed Update time : " + Time.deltaTime);
    }

    void Update()
    {
        // called every frame
        // timers, input non physics movement
        Debug.Log("Update Time : " + Time.deltaTime);        
    }
}
