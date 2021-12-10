using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class TransitionManager : MonoBehaviour
{
    //public bool isMenu = true;
    public int isNiveau;



    private void Start()
    {
        isNiveau = PlayerPrefs.GetInt("level", 1);
        Debug.Log(isNiveau);
    }

    // SCENE TRANSITION

    //Open Scene
    public void OpenMenuScene()
    {
        SceneManager.LoadScene (sceneName:"Menu");
        Screen.orientation = ScreenOrientation.Portrait;
    }

    public void LevelUp(){
  
        if (isNiveau == 1){
            PlayerPrefs.SetInt("level", 2);
        }

        else if (isNiveau == 2){
            PlayerPrefs.SetInt("level", 3);
        }

        else if (isNiveau == 3){
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
        PlayerPrefs.DeleteKey("level");
    }
}
