using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LockedDoor : Door
{
    [SerializeField] GameObject doorLockedText;
    //max gjort detta
    public bool isUnlocked = false;

    public override void _Interact()
    {
        if(isUnlocked == true)
        {
            open = true;
        }
        else
        {
            StartCoroutine(doorLocked());
        }
    }
    IEnumerator doorLocked()//lets the player know the door is locked
    {
        doorLockedText.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        doorLockedText.SetActive(false);
    }

    public override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
    }


}
