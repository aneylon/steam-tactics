using UnityEngine;

public class Begin_02 : MonoBehaviour
{
    int myNumber = 5;

    void Start()
    {
        Debug.Log("Yo! : " + multiplyBy(myNumber, 3));
    }

    int multiplyBy(int input, int multiplier)
    {
        return input * multiplier;
    }

}
