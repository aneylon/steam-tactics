using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 150;

    void Update()
    {
        transform.LookAt(target);
        transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);    
    }
}
