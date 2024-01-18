using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safe : MonoBehaviour
{
    //gjort av max

    //Sätt script på player

    [SerializeField]
    GameObject codePanel,door;

    public static bool isKeyPadOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        //sätter på och av så att safe är stängt och så keypad inte visas 
        codePanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isKeyPadOpen == true)//om safe är open sätt på opensafe gameobject
        {
            codePanel.SetActive(false);
            door.transform.position += new Vector3(3, 0, 0) * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //om player går in i safe ska keypad visas
    {
        if (collision.gameObject.CompareTag("keyPad") && !isKeyPadOpen)
        {
            codePanel.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)//när player går bort från safe så ska keypad inte visas
    {
        if (collision.gameObject.CompareTag("keyPad") && !isKeyPadOpen)
        {
            codePanel.SetActive(false);
        }
    }
}
