using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIde : Interact
{

    public bool hiding = false;
    public Transform Cabinet;

    public void Start()
    {

        interactText.SetActive(false);
        var collider = Cabinet.GetComponent<Collider>();

    }

    private void Update()
    {
        

    }
    public override void _Update()
    {
        if (hiding == false&&canInteract == true)
        {
            interactText.SetActive(true);
        }

        if (hiding == true)
        {
            interactText.SetActive(false);

        }


        if (Input.GetKey(KeyCode.W) && hiding == true)
        {
            hiding = false;
            interactText.SetActive(false);
        }


        if (Input.GetKey(KeyCode.A) && hiding == true)
        {
            hiding = false;
            interactText.SetActive(false);
        }

        if (Input.GetKey(KeyCode.S) && hiding == true)
        {
            hiding = false;
            interactText.SetActive(false);
        }

        if (Input.GetKey(KeyCode.D) && hiding == true)
        {
            hiding = false;
            interactText.SetActive(false);
        }

    }

    public override void _Interact()
    {
        player.transform.position = Cabinet.position;
        
        hiding = true;

        
    }

}
