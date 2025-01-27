using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadLevel(int indexLoader)
    {
        SceneManager.LoadScene(indexLoader);
    }

    public void LoadLevelAdditive(int indexLoader)
    {
        SceneManager.LoadScene(indexLoader, LoadSceneMode.Additive);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
