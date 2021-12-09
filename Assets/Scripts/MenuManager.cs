using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TransitionManager transitionManager;
    
    public GameObject Niveau, Niveau_2,Niveau_3,Niveau_4, Accueil, Options, MainMenu, Lore, Lore2, Lore3, Lore4, TutoBalise, TutoMap, TutoLoupe, TutoProgress, TutoBoussole, MenuIngame, OptionsIngame, TransitionGame, MapIngame, Victory;

    public GameObject HideButton, ShowButton;
    
    private bool HideIcons;
    public int isNiveau;

    // Sauvegarde de valeurs entre scènes
    private void Start()
    {
        isNiveau = PlayerPrefs.GetInt("level",1);
        //PlayerPrefs.SetInt("level", 1);

        if(Accueil != null)
        {
            if(isNiveau == 1){
                Accueil.SetActive(true);
            }
            else if (isNiveau == 2){
                Niveau_2.SetActive(true);
            }
            else if (isNiveau == 3){
                Niveau_3.SetActive(true);
            }
            else if (isNiveau == 4){
                Niveau_4.SetActive(true);
            }
        }
    }

    // OPEN CANVAS
    public void OptionActive()
    {
        Options.SetActive(true);
    }

    public void NiveauActive()
    {

        Niveau.SetActive(true);

        if (isNiveau == 2){
            Niveau_2.SetActive(true);
        }
        else if (isNiveau == 3){
            Niveau_3.SetActive(true);
        }
        else if (isNiveau == 4){
            Niveau_4.SetActive(true);
        }
    }

    public void Niveau2Active()
    {

        Niveau_2.SetActive(true); 
    }

    public void Niveau3Active()
    {
        Niveau_3.SetActive(true);
    }

    public void Niveau4Active()
    {
        Niveau_4.SetActive(true);
    }

    public void MainMenuActive()
    {
        MainMenu.SetActive(true);
    }

    public void LoreActive()
    {
        Lore.SetActive(true);
    }

    public void TutoBaliseActive()
    {
        TutoBalise.SetActive(true);
        
        if (isNiveau == 2 || isNiveau == 3 || isNiveau == 4){
            TransitionGameActive();
            transitionManager.OpenGameScene();
        }

    }

    public void TutoMapActive()
    {
        TutoMap.SetActive(true);
    }
    public void TutoLoupeActive()
    {
        TutoLoupe.SetActive(true);
    }

    public void TutoProgressActive()
    {
        TutoProgress.SetActive(true);
    }
    public void TutoBoussoleActive()
    {
        TutoBoussole.SetActive(true);
    }

    public void MenuIngameActive()
    {
        MenuIngame.SetActive(true);
    }
    public void OtionsIngameActive()
    {
        OptionsIngame.SetActive(true);
    }

    public void TransitionGameActive()
    {
        TransitionGame.SetActive(true);
    }

    public void MapIngameActive()
    {
        MapIngame.SetActive(true);
        HideIcons = true;
    }

    public void VictoryActive(){
        Victory.SetActive(true);
    }


    // CLOSE CANVAS
    public void CloseOptions()
    {
        Options.SetActive(false);
    }

    public void CloseNiveau()
    {
        Niveau.SetActive(false);
    }

    public void CloseNiveau2()
    {
        Niveau_2.SetActive(false);
    }

    public void CloseNiveau3()
    {
        Niveau_3.SetActive(false);
    }

    public void CloseNiveau4()
    {
        Niveau_4.SetActive(false);
    }

    public void CloseMainMenu()
    {
        MainMenu.SetActive(false);
    }

    public void CloseLore()
    {
        Lore.SetActive(false);
    }

    public void CloseTutoBalise()
    {
        TutoBalise.SetActive(false);
    }

    public void CloseTutoMap()
    {
        TutoMap.SetActive(false);
    }

    public void CloseTutoLoupe()
    {
        TutoLoupe.SetActive(false);
    }

    public void CloseTutoProgress()
    {
        TutoProgress.SetActive(false);
    }

    public void CloseTutoBoussole()
    {
        TutoBoussole.SetActive(false);
    }

    public void CloseMenuIngame()
    {
        MenuIngame.SetActive(false);
    }
    public void CloseOptionsIngame()
    {
        OptionsIngame.SetActive(false);
    }

    public void CloseTransitionGame()
    {
        TransitionGame.SetActive(false);
    }
    
    public void CloseMapIngame()
    {
        MapIngame.SetActive(false);
        HideIcons = false;
    }

    public void CloseVictory(){
        Victory.SetActive(false);
    }

    // ICONE MANAGER

    public void Update(){
        if(HideButton != null && ShowButton != null)
        {
            if (HideIcons != true){
                    HideButton.SetActive(true);
                    ShowButton.SetActive(false); 
                }  
            }       
    }
}


