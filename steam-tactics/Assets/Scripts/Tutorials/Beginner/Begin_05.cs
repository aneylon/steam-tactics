using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_05 : MonoBehaviour
{
    int cupsInSink = 4;
    int count = 5;

    void Start()
    {
        while (cupsInSink > 0)
        {
            Debug.Log("Wash one down.");
            cupsInSink--;
        }

        do
        {
            print("Count down. : " + count);
            count--;
        } while (count >= 0);

        for(int i = 0; i < 5; i++)
        {
            Debug.LogError("Add it up! : " + i);
        }

        // foreach!
    }
}
