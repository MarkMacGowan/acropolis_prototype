using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour
{   
    public Scene sceneToLoad;
    private int sceneindex;

    public void loadScene()
    {
        sceneindex = sceneToLoad.buildIndex;
        SceneManager.LoadScene(1);
    }
    public void exitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
