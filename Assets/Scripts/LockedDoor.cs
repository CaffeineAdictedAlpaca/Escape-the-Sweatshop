using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LockedDoor : Door
{

    bool isUnlocked = false;

    public override void _Interact()
    {
        if(isUnlocked == true)
        {
            open = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("securityKey"))
        {
            isUnlocked = true;
        }
        
    }
}
