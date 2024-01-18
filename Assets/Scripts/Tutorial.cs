using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tutorial : MonoBehaviour
{

    public Image w;
    public Image a;
    public Image s;
    public Image d;
    public Image interact;
    public Image q;
    public Image shift;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            w.enabled = false;
        }


        if (Input.GetKey(KeyCode.A))
        {
            a.enabled = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            s.enabled = false;
        }


        if (Input.GetKey(KeyCode.D))
        {
            d.enabled = false;
        }


        if (Input.GetKey(KeyCode.Q))
        {
            q.enabled = false;
        }


        if (Input.GetKey(KeyCode.E))
        {
            interact.enabled = false;
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            shift.enabled = false;
        }

        


    }
}
