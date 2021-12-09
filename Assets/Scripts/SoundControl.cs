using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;
        
public class SoundControl : MonoBehaviour
{
    // Start is called before the first frame update
   
    public Slider mainSlider;
    float m_MySliderValue;
    
    

    public Sound[] sounds;

    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            
            s.source.pitch = s.pitch;
            m_MySliderValue = 0.5f;
        }
    }

    public void VolumeControl(){
         foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.volume =  m_MySliderValue;
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
