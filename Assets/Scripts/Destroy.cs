using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public ProgressBar myBar;
    public Compass myCompass;
    public GameObject gameObj;
    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Collectibles>() != null)
        {
            Collectibles _collect = other.GetComponent<Collectibles>();
            _collect.gameObject.SetActive(false);
            myCompass.removeMarker(_collect);
            myBar.current += 10;
        }


        // Je d�termine si l'objet est un collectible
        // Je donne au compas la r�f�rence du collectible en collision
        // Je d�truis l'objet collectible





    }


}