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
        if ((Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) && hiding == true)//if the player enters a movement key they stop hiding -Sixten
        {
            notHiding();
            interactText.SetActive(false);
            player.transform.position = stopHideTP.position;
            hiding = false;
        }
    }

    public override void _Interact()//on interact start hiding -Sixten
    {
        isHiding();
        player.transform.position = Cabinet.position;

        hiding = true;
    }
    public void isHiding()//disables the player collider and sprite renderer when hiding -Sixten
    {
        interactText.SetActive(false);

        coll.enabled = false;
        playerSprite.enabled = false;
    }
    public void notHiding()//enables the player collider and sprite renderer when the player stops hiding -Sixten
    {
        coll.enabled = true;
        playerSprite.enabled = true;
    }

}