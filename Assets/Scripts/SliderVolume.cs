using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour
{
    public AudioSource AudioSource;
    public Slider volumeSlider;
    private float MusicVolume = 1f;

    private void Start(){
        AudioSource.Play();
        MusicVolume = PlayerPrefs.GetFloat("volume");
        AudioSource.volume = MusicVolume;
        volumeSlider.value = MusicVolume;
        AudioSource.volume = 0.5f;
    }

    private void Update(){
        AudioSource.volume = MusicVolume;
        PlayerPrefs.SetFloat("volume", MusicVolume);
    }

    public void VolumeUpdater(float volume){
        MusicVolume = volume;
    }

    public void MusicReset() {
        PlayerPrefs.DeleteKey("volume");
        AudioSource.volume = 1;
        volumeSlider.value = 1;
    }

}
