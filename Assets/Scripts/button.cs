using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public GameObject Button;
    public GameObject Texte;
    public bool isPressed = false;
    public bool isShowed = false;
    public float taille;

    public void zoomIn()
    {
        isPressed = true;
    }

    public void showText()
    {
        isShowed = true;
    }
    public void Update()
    {

        // Si j'appuie le bouton grandit
        if (isPressed == true)
        {
            taille += 0.002f;
            Button.transform.localScale += new Vector3(taille, taille, 0);
        }

        // Si le bouton atteint la bonne taille, il passe à la slide suivante en éteignant la slide active
        if (taille >= 0.1 )
        {
            isPressed = false;
        }

        // Si le bouton est pressé, j'affiche mon texte
        if (isShowed == true)
        {
            Texte.SetActive(true);
        }
        else
        {
            Texte.SetActive(false);
            isShowed = false;
        }
    }
}
