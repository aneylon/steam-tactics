using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin_03 : MonoBehaviour
{
    float temp = 85.0f;
    float hot = 70.0f;
    float cold = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempTest();

        temp -= Time.deltaTime * 5f;
    }

    void TempTest()
    {
        if(temp> hot)
        {
            print("too hot");
        }
        else if( temp < cold)
        {
            print("too cold");
        }
        else
        {
            print("just right");
        }
    }
}
