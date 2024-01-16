using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDoor : LockedDoor
{
    //Max gjort detta
    public override void OnTriggerEnter2D(Collider2D other)//om securitykey nuddar dörren så kan man interacta med dörren
    {
        base.OnTriggerEnter2D(other);
        if (other.gameObject.CompareTag("securityKey"))
        {
            isUnlocked = true;
        }
    }
}
