using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{
    public string sceneToLoad;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void PerformButtonAction(string action)
    {
        if (action == "ChangeScene")
        {
            ChangeScene();
        }
        else if (action == "ExitGame")
        {
            ExitGame();
        }
    }

    private void ExitGame()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }
}
