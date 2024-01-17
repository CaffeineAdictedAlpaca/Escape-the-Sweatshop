using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : Interact
{
    [SerializeField] GameObject[] cameras;

    public override void _Interact()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].SetActive(false);
        }
    }
}
