using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Interact
{
    [SerializeField] GameObject ItemIcon;

    public GameObject item;
    public Transform itemHolder;
    public Transform itemDorp;

    public override void _Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.parent = itemDorp.transform;
            ItemIcon.SetActive(false);
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    public override void _Interact()
    {
        transform.parent = player.transform;
        transform.position = itemHolder.position;
        transform.rotation = player.transform.rotation;
        ItemIcon.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
    }



}
