using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roostermorning : MonoBehaviour
{


    public AudioSource audiosource;
    private void Start()
    {
        audiosource.Play();
        StartCoroutine(WaitForSec());
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(500);
        audiosource.Play();
    }
}
