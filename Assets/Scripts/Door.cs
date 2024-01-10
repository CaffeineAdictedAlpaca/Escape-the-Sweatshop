using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interact
{
    //Sixten gjorde hela det här scriptet
    public bool open;

    [SerializeField] bool moveY;
    [SerializeField] bool moveX;

    [SerializeField] float speed;

    public float maxMove;
    float moveTrack;
    public override void _Interact()
    {
        open = true;
    }
    public override void _Update()
    {
        if (open == true && moveX == true)
        {
            transform.position += new Vector3(speed,0,0) * Time.deltaTime;
            moveTrack += speed * Time.deltaTime;
        }
        if (moveTrack >= maxMove)
        {
            open = false;
        }
    }
}
