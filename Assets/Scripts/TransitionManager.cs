using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public bool isMenu = true;
  
    //public GameScene MenuScene, GameScene, MenuIngameScene;
    
    // Start is called before the first frame update
    // void Start()
    // {
      
    // }

    // Update is called once per frame
    // void Update()
    // {
    //     if (isMenu == true){
    //         // le screen ne peut être qu'en portrait

    //     }
    //     else {
    //         // le screen ne peut être qu'en paysage
            
    //     }
    // }
    
    // SCENE TRANSITION
    
    //Open Scene
    public void OpenMenuScene()
    {
    SceneManager.LoadScene (sceneName:"Menu");
    }

    public void OpenMenuIngameScene()
    {
    SceneManager.LoadScene (sceneName:"Menu Ingame");
    }

    public void OpenGameScene()
    {
    SceneManager.LoadScene (sceneName:"Playground");
    }
}
