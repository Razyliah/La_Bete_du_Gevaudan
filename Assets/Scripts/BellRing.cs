using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellRing : MonoBehaviour
{


    public AudioSource audiosource;
    private void Start()
    {
        audiosource.Stop();
        StartCoroutine(WaitForSec());
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(60);
        audiosource.Play();
        StartCoroutine(WaitForSec());
    }

}
