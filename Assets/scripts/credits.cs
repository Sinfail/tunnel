﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour {

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
    public void RestartGame()
    {
        Debug.Log("Restarted");
        SceneManager.LoadScene("Level1"); 

    }
}
