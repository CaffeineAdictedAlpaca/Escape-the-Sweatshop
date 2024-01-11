using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LockedDoor : Door
{

    public bool isUnlocked = false;

    public override void _Interact()
    {
        if(isUnlocked == true)
        {
            open = true;
        }
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.gameObject.CompareTag("securityKey"))
        {
            isUnlocked = true;
        }
    }

    public override void _Update()
    {
        base._Update();
    }
}
