
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour {

	public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // load next active scene
    }
}
