using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject ButtonToZoom;
    public GameObject TexteToShow;
    public GameObject PressedButton;

    public bool isPressed;

    public float taille;

    public void zoomIn()
    {
        isPressed = true;
    }

    public void Start()
    {
        TexteToShow.SetActive(false);
    }
    public void Update()
    {

        // Si j'appuie le bouton grandit
        if (isPressed == true)
        {
            taille += 0.002f;
            ButtonToZoom.transform.localScale += new Vector3(taille, taille, 0);
        }

        // Si le bouton atteint la bonne taille, il passe � la slide suivante en �teignant la slide active
        if (taille >= 0.1 )
        {
            isPressed = false;
        }
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        TexteToShow.SetActive(true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        TexteToShow.SetActive(false);
    }

}
