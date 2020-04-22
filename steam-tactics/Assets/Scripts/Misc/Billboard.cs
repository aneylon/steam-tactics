using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Transform targetCamera;

    private void LateUpdate()
    {
        transform.LookAt(transform.position + targetCamera.forward);

    }

}
