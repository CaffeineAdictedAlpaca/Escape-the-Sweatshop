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
            ItemIcon.SetActive(false);//st�nger av item iconen , Santiago
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    public override void _Interact()//n�r du interagerar s�...
    {
        transform.parent = player.transform;//g�r objektet till en child av player, Santiago
        transform.position = itemHolder.position;// objektet teleporteras till itemholderns position, Santiago
        transform.rotation = player.transform.rotation;//roterar objektet parallelt med spelaren, Santiago
        ItemIcon.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
    }



}
