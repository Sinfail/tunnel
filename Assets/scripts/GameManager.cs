
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

    public GameObject completeLevelUI;

    public float RestartDelay = 1f;
    bool GameEnded = false;

    public void CompleteLevel()
    {
        Debug.Log("Level complete");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("GAME OVER BITCH");
            Invoke("Restart", RestartDelay);
            // Restart Game
        }
    }
    void Restart()
    {
        // SceneManager.LoadScene("Level1"); this is one way to load a scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //how to load active scene/last active scene or something
    }
}
