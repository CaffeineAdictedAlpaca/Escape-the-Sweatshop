using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    //public GameObject floor;
    //private SpriteRenderer floorSpriteRenderer;
   


    private float rotation;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //floorSpriteRenderer = floor.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        


        rotation += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}
