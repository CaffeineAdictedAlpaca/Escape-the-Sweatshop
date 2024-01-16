using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JDoor : LockedDoor
{
    //max gjort detta
    public override void OnTriggerEnter2D(Collider2D other) //om janitor key nuddar dörren så kan man interacta med dörren
    {
        base.OnTriggerEnter2D(other);
        if (other.gameObject.CompareTag("janitorKey"))
        {
            isUnlocked = true;
        }
    }
}
