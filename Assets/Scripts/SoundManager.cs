using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [Header("Audio Sliders")]
    [SerializeField] private Slider masterSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;
    [SerializeField] AudioMixer myMixer;
    // Update is called once per frame
    public void ChangeMasterVolume()
    {
        //Ändrar spelets volym beroende på sliderns värde. -Adrian
        AudioListener.volume = masterSlider.value;
    }

    public void ChangeMusicVolume()
    {
        //Ändar music värdet i mixern beroende på sliders värde. - Adrian
        float volume = musicSlider.value;
        myMixer.SetFloat("Music", Mathf.Log10(volume)*20);
    }
    public void ChangeSFXVolume()
    {
        //Ändar music värdet i mixern beroende på sliders värde. - Adrian
        float volume = sfxSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
}
