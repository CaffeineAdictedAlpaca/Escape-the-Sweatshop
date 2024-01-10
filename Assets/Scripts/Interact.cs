using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject interactText;//drag and drop InteractText in unity
    public bool canInteract = false;
    public GameObject player;
    public Rigidbody playerRb;


    // Start is called before the first frame update
    void Start()
    {
        interactText.SetActive(false);//hide interact text on start
    }

    // Update is called once per frame
    void Update()
    {
        _Update();
        if (canInteract == true && Input.GetKeyDown(KeyCode.E))//if you press space when can interac is true, add force in the direction the canonPointer is pointing
        {
            _Interact();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))//when the player is in the canonInteract box, interactText is active and can canInteract is true
        {
            player = other.gameObject;
            interactText.SetActive(true);
            canInteract = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))//when the player is not in the canonInteract box, interactText is not active and can canInteract is false
        {
            player = other.gameObject;
            interactText.SetActive(false);
            canInteract = false;
        }
    }
    public virtual void _Interact()//ovveride this to set what hapens on interact
    {

    }
    public virtual void _Update()//override this to use update in child skript
    {

    }
}
