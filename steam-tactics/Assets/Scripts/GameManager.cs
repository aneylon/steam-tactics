using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MusicManager musicManager;
    void Start()
    {
        Debug.Log("Start it up.");
    }

    void Update()
    {
        
    }

    public void StartButton()
    {
        Debug.Log("Click start button");
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
