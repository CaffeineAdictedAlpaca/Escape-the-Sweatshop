using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        //Kollar ifall det finns en sparad volym, annars laddar full volym
        if (!PlayerPrefs.HasKey("masterVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        //Ändrar spelets volym beroende på sliderns värde.
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("masterVolume");
    }
    private void Save()
    {
        //Sparar volymets värde som en float;
        PlayerPrefs.SetFloat("masterVolume", volumeSlider.value);
    }
}
