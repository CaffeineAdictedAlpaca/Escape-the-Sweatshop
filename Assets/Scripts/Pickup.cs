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
            ItemIcon.SetActive(false);//stänger av item iconen , Santiago
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
    public override void _Interact()//när du interagerar så...
    {
        transform.parent = player.transform;//gör objektet till en child av player, Santiago
        transform.position = itemHolder.position;// objektet teleporteras till itemholderns position, Santiago
        transform.rotation = player.transform.rotation;//roterar objektet parallelt med spelaren, Santiago
        ItemIcon.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
    }



}
