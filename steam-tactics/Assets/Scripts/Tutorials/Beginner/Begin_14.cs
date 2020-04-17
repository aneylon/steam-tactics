using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_14 : MonoBehaviour
{
    public GameObject target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(target, 1.5f);
        }
    }
}
