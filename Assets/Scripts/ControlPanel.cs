using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : Interact
{
    [SerializeField] GameObject[] cameras;//drop in all security camera view colliders in this array -Sixten
    [SerializeField] GameObject cameraOffText;
    
    public override void _Interact()//on interact disable the camera view coliders -Sixten
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].SetActive(false);
        }
        cameraOffText.SetActive(true);
        Destroy(gameObject);
    }
}
