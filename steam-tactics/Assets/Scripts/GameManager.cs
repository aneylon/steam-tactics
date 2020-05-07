using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MusicManager musicManager;
    public GameBoard GameBoard;

    void Start()
    {
        Debug.Log("Start it up.");
        GameBoard = GetComponent<GameBoard>();
    }

    void Update()
    {
        
    }

    public void StartButton()
    {
        Debug.Log("Click start button");
        Debug.Log(GameBoard);
        GameBoard.CreateGameBoard(3, 4);
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
