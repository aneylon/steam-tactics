using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("up");
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Down");
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Left");
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Right");
            transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        }
    }
}
