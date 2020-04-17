using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_12 : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    private void Update()
    {
        //transform.Translate(new Vector3(0, 0, 1));
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
    }
}
