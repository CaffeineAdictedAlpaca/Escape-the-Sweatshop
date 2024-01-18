using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LockedDoor : Door
{
    [SerializeField] GameObject doorLockedText;

    public bool isUnlocked = false;

    public override void _Interact()
    {
        if(isUnlocked == true)//Max
        {
            open = true;
        }
        else//Sixten
        {
            StartCoroutine(doorLocked());
        }
    }
    IEnumerator doorLocked()//lets the player know the door is locked -Sixten
    {
        doorLockedText.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        doorLockedText.SetActive(false);
    }

    public override void OnTriggerEnter2D(Collider2D other)//Max
    {
        base.OnTriggerEnter2D(other);
    }


}
