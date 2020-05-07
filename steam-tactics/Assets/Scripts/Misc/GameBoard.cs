using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public GameObject GameTile;

    public void CreateGameBoard(int length, int width)
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Instantiate(GameTile, new Vector3(i, j, 0), Quaternion.identity);
            }
        }
    }
}
