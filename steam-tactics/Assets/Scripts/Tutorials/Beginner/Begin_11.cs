using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_11 : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
        Debug.Log("Active self: " + this.gameObject.activeSelf);
        Debug.Log("Active self: " + this.gameObject.activeInHierarchy);
    }
}
