using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class TransitionManager : MonoBehaviour
{
    public bool isMenu = true;
    public bool isNiveau1 = true;
    public bool isNiveau2;
    public bool isNiveau3;
    public bool isNiveau4;

    private void Start()
    {
        // Methode 1
        //DontDestroyOnLoad(gameObject);
    }

    // SCENE TRANSITION

    //Open Scene
    public void OpenMenuScene()
    {
        SceneManager.LoadScene (sceneName:"Menu");
        Screen.orientation = ScreenOrientation.Portrait;

        if (isNiveau1 == true){
            isNiveau2 = true;
            isNiveau1 = false;
            PlayerPrefs.SetInt("level", 2);
        }

        else if (isNiveau2 == true){
            isNiveau3 = true;
            isNiveau2 = false;
            PlayerPrefs.SetInt("level", 3);
        }

        else if (isNiveau3 == true){
            isNiveau4 = true;
            isNiveau3 = false;
            PlayerPrefs.SetInt("level", 4);
        }
    }

    public void OpenMenuIngameScene()
    {
        SceneManager.LoadScene (sceneName:"Menu Ingame");
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void OpenGameScene()
    {
        SceneManager.LoadScene (sceneName:"Playground");
        Screen.orientation = ScreenOrientation.Landscape;
    }

    public void PauseGame ()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
    }

    public void ResumeGame ()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
    }

    public void ResetSave()
    {
        PlayerPrefs.SetInt("level", 1);
    }
}
