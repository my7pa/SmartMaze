using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCTRL : MonoBehaviour {

    //opens selected scene
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    //Quits the application (still debugging)
    public void QuitGame()
    {
        Debug.Log("Game is Quitting");
        Application.Quit();
    }
}
