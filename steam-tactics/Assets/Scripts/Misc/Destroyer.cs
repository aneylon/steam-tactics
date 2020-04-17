using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // refactor to take input on creation?
    public float timeToLive = 3;

    void Start()
    {
        Destroy(gameObject, timeToLive);       
    }
}
