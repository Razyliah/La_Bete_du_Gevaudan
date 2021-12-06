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
  

    // SCENE TRANSITION
    
    //Open Scene
    public void OpenMenuScene()
    {
        SceneManager.LoadScene (sceneName:"Menu");

        if (isNiveau1 == true){
        isNiveau2 = true;
        isNiveau1 = false;
        }

        else if (isNiveau2 == true){
        isNiveau3 = true;
        isNiveau2 = false;
        }

        else if (isNiveau3 == true){
        isNiveau4 = true;
        isNiveau3 = false;
        }
    }

    public void OpenMenuIngameScene()
    {
        SceneManager.LoadScene (sceneName:"Menu Ingame");
    }

    public void OpenGameScene()
    {
        SceneManager.LoadScene (sceneName:"Playground");
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
}
