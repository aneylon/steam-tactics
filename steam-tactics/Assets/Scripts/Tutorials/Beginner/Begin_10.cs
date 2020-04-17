using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_10 : MonoBehaviour
{
    private Light myLight;
    //private bool isOn = true;

    void Start()
    {
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // isOn = !isOn;
            // myLight.enabled = isOn;
            myLight.enabled = !myLight.enabled;
        }
    }
}
