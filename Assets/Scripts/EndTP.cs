using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTP : MonoBehaviour
{
    [SerializeField] Transform endTP;
    [SerializeField] Transform player;
    public void OnTriggerEnter2D(Collider2D collision)
    {
         player.position = endTP.position;
    }
}
