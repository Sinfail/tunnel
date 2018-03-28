
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelComplete : MonoBehaviour {

	public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // gets the active scene number then loads the next scene according to the scene hiaracy in the build index.
    }
}
