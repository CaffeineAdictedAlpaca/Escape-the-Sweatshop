using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LockedDoor : Door
{
    //max gjort detta
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
    }


}
