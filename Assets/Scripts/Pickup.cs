using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pickup : Interact
{
    
    

    public GameObject Item;
    public Transform itemHolder;
    public Transform itemDrop;

    


    

    public override void _Update()
    {
       


        if(Input.GetKeyDown(KeyCode.Q))
        {
            Drop();
        }


    }
    public override void _Interact()
    {


        transform.parent = player.transform;
        transform.position = itemHolder.position;
        transform.rotation = player.transform.rotation;
    }

    public void Drop()
    {
       // player.transform.Find(Item) = Item.transform.parent;

        transform.parent = itemDrop.transform;

    }


}
