using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{

    public AudioSource audiosource;
    private bool alreadyPlayed;
    
    private void Start()
    {
        audiosource.Stop();
        alreadyPlayed = false;
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player" && !alreadyPlayed)
        {
            audiosource.Play();
            alreadyPlayed = true;
        }

    }
   
}