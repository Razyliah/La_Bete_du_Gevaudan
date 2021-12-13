using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour
{

    public AudioSource audiosource;
    
    private void Start()
    {
        audiosource.Stop();
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            audiosource.Play();
        }
    }
   
}