using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPadDoor : LockedDoor
{
    //gjord av max

  
    public override void _Interact()
    {
        base._Interact();
        if (safe.isKeyPadOpen == true)
        {
            isUnlocked = true;
        }

    }
}
