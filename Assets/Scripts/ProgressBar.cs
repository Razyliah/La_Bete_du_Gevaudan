using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]

public class ProgressBar : MonoBehaviour
{
    public int maximum;
    public int current;
    public Image Mask;
    public MenuManager menuManager;

    private void Update()
    {
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)maximum;
        Mask.fillAmount = fillAmount;

        if( (float)current == (float)maximum){
            menuManager.VictoryActive();
        }
    }
}
