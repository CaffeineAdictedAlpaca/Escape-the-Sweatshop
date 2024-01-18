using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyPadDoor : LockedDoor
{
    //gjord av max fixad av sixten
    public override void _Update()
    {
        base._Update();
        if (safe.isKeyPadOpen == true)
        {
            isUnlocked = true;
        }
    }

    public override void _Interact()
    {
        base._Interact();
    }
}
