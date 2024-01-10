using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Interact
{
    public GameObject item;
    public Transform itemHolder;

    public override void _Update()
    {

    }
    public override void _Interact()
    {
        transform.parent = player.transform;
        transform.position = itemHolder.position;
        transform.rotation = player.transform.rotation;
    }



}
