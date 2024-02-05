using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tutorial : MonoBehaviour
{

    public GameObject w;
    public GameObject a;
    public GameObject s;
    public GameObject d;
    public GameObject interact;
    public GameObject q;
    public GameObject shift;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            w.SetActive(false);
        }


        if (Input.GetKey(KeyCode.A))
        {
            a.SetActive(false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            s.SetActive(false);
        }


        if (Input.GetKey(KeyCode.D))
        {
            d.SetActive(false);
        }


        if (Input.GetKey(KeyCode.Q))
        {
            q.SetActive(false);
        }


        if (Input.GetKey(KeyCode.E))
        {
            interact.SetActive(false);
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            shift.SetActive(false);
        }

        


    }
}
