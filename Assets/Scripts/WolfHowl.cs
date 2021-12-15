using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfHowl : MonoBehaviour
{


    public AudioSource audiosource;
    private void Start()
    {
        audiosource.Play();
        StartCoroutine(WaitForSec());
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(20);
        audiosource.Play();
    }
}
