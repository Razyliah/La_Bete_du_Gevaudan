using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject Niveau, Accueil, Options, MainMenu, Lore, TutoBalise, TutoMap, TutoLoupe, TutoProgress, TutoBoussole, MenuIngame, OptionsIngame;

    // OPEN CANVAS
    public void OptionActive()
    {
        Options.SetActive(true);
    }

    public void NiveauActive()
    {
        Niveau.SetActive(true);
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



    // CLOSE CANVAS
    public void CloseOptions()
    {
        Options.SetActive(false);
    }

    public void CloseNiveau()
    {
        Niveau.SetActive(false);
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

}


