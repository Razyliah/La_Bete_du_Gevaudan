using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternEnable : MonoBehaviour
{


    public GameObject myLight;
    public AudioSource audiosource;
    public AudioSource scorePointFx;
    public bool alreadyPlayed = false;
    private void Start()
    {
        myLight.SetActive(false);
        audiosource.Stop();
        scorePointFx.Stop();
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player" && !alreadyPlayed)
        {
            myLight.SetActive(true);
            audiosource.Play();
            audiosource.loop = true;
            scorePointFx.Play();
            alreadyPlayed = true;
            

        }
    }
}
    
