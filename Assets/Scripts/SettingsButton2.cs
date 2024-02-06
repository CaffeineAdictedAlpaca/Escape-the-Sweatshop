using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsButton2 : MonoBehaviour
{
    [SerializeField] GameObject settingsButton2;
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//enable the settings button if it is inaktive and dissable it if ti is active -Sixten
        {
            settingsButton2.SetActive(!settingsButton2.activeSelf);
        }
    }
}
