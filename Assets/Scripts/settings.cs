using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settings : MonoBehaviour
{

    public struct Control
    {
        public bool change;
        public KeyCode key;
    }

    public static Control[] controls = new Control[6];
    //0 - up, 1 - down, 2- left, 3- right, 4-pickup, 5-drop


    void Start()
    {
        controls[0].key = KeyCode.W;
        controls[1].key = KeyCode.S;
        controls[2].key = KeyCode.A;
        controls[3].key = KeyCode.D;
        controls[4].key = KeyCode.E;
        controls[5].key = KeyCode.Q;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < controls.Length; i++)
        {
            if (controls[i].change)
            {
                foreach (KeyCode key in Enum.GetValues(typeof(KeyCode)))
                {
                    if (Input.GetKey(key))
                    {
                        controls[i].key = key;
                        controls[i].change = false;
                        print("New button is " + key);
                    }
                }
            }
        }

    }

    public void changecontrols(int index)
    {
        controls[index].change = true;
        print("choose a button");
    }

}
