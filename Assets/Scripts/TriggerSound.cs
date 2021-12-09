using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TriggerSound : MonoBehaviour
{
    public AudioSource audioSource;

    private void Start()
    {
        audioSource.Stop();
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            audioSource.Play();
        }
    }

}
