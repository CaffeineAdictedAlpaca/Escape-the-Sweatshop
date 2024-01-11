using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : Door
{
    bool securityKey = false;

    public override void _Update()
    {
        base._Update();

    }
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("securityKey"))
        {
            _Interact();
        }
        
    }
}
