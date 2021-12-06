using UnityEngine.Audio;
using System;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void Pause()
    {
        GetComponent<AudioSource>().Pause();
    }

    public void Stop()
    {
        GetComponent<AudioSource>().Stop();
    }

    // Update is called once per frame

}
