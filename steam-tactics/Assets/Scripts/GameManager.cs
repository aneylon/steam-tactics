using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MusicManager musicManager;
    public GameObject GameTile;

    void Start()
    {
        Debug.Log("Start it up.");
    }

    public void CreateGameBoard(int length, int width)
    {
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Instantiate(GameTile, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }

    public void StartButton()
    {
        Debug.Log("Click start button");
        CreateGameBoard(3, 4);
    }

    public void ExitButton()
    {
        Debug.Log("Exit button clicked.");
        // check for user confirmation?
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }

    public void OptionsButton()
    {
        Debug.Log("Options Button clicked.");
    }
}
