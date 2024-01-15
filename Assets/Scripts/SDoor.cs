using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDoor : LockedDoor
{
    //Max gjort detta
    public override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.gameObject.CompareTag("securityKey"))
        {
            isUnlocked = true;
        }
    }
}
