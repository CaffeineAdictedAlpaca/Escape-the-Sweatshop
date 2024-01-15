using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIde : Interact
{
    Collider2D coll;
    public bool hiding = false;
    public Transform Cabinet;
    public Transform stopHideTP;

    public override void _Update()
    {
        coll = player.GetComponent<Collider2D>();
        if (hiding == false&&canInteract == true)
        {
            interactText.SetActive(true);
        }

        if (hiding == true)
        {
            interactText.SetActive(false);

            coll.enabled = false;
        }
        if(hiding == false)
        {
            coll.enabled = true;
        }


        if (Input.GetKey(KeyCode.W) && hiding == true)
        {
            hiding = false;
            interactText.SetActive(false);
            player.transform.position = stopHideTP.position;
        }


        if (Input.GetKey(KeyCode.A) && hiding == true)
        {
            hiding = false;
            interactText.SetActive(false);
            player.transform.position = stopHideTP.position;
        }

        if (Input.GetKey(KeyCode.S) && hiding == true)
        {
            hiding = false;
            interactText.SetActive(false);
            player.transform.position = stopHideTP.position;
        }

        if (Input.GetKey(KeyCode.D) && hiding == true)
        {
            hiding = false;
            interactText.SetActive(false);
            player.transform.position = stopHideTP.position;
        }

    }

    public override void _Interact()
    {

        player.transform.position = Cabinet.position;
        
        hiding = true;

        
    }

}
