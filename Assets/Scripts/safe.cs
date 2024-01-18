using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe : MonoBehaviour
{
    //gjort av max

    //S�tt script p� player

    [SerializeField]
    GameObject codePanel,door;

    public static bool isKeyPadOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        //s�tter p� och av s� att safe �r st�ngt och s� keypad inte visas 
        codePanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isKeyPadOpen == true)//om safe �r open s�tt p� opensafe gameobject
        {
            codePanel.SetActive(false);
            door.transform.position += new Vector3(3, 0, 0) * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //om player g�r in i safe ska keypad visas
    {
        if (collision.gameObject.CompareTag("keyPad") && !isKeyPadOpen)
        {
            codePanel.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)//n�r player g�r bort fr�n safe s� ska keypad inte visas
    {
        if (collision.gameObject.CompareTag("keyPad") && !isKeyPadOpen)
        {
            codePanel.SetActive(false);
        }
    }
}
