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
        //�ndrar spelets volym beroende p� sliderns v�rde. -Adrian
        AudioListener.volume = masterSlider.value;
    }

    public void ChangeMusicVolume()
    {
        //�ndar music v�rdet i mixern beroende p� sliders v�rde. - Adrian
        float volume = musicSlider.value;
        myMixer.SetFloat("Music", Mathf.Log10(volume)*20);
    }
    public void ChangeSFXVolume()
    {
        //�ndar music v�rdet i mixern beroende p� sliders v�rde. - Adrian
        float volume = sfxSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
}
