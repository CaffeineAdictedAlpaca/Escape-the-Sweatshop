using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : Door
{
    bool doorkey = false;

    public override void _Update()
    {
        base._Update();

    }
    public override void _Interact()
    {
        if (doorkey == true)
        {
            open = true;
        }

    }
    
    
}
