using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIde : Interact
{
    Collider2D coll;
    SpriteRenderer playerSprite;
    public bool hiding = false;
    public Transform Cabinet;
    public Transform stopHideTP;

    private void Start()
    {
        coll = player.GetComponent<Collider2D>();
        playerSprite = player.GetComponent<SpriteRenderer>();
    }
    public override void _Update()
    {
        if ((Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && hiding == true)
        {
            notHiding();
            interactText.SetActive(false);
            player.transform.position = stopHideTP.position;
            hiding = false;
        }
    }

    public override void _Interact()
    {
        isHiding();
        player.transform.position = Cabinet.position;

        hiding = true;


    }
    public void isHiding()
    {
        interactText.SetActive(false);

        coll.enabled = false;
        playerSprite.enabled = false;
    }
    public void notHiding()
    {
        coll.enabled = true;
        playerSprite.enabled = true;
    }

}