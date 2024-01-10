using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    //Stamina  and sprint (Santiago)
    [SerializeField]
    public float stamina = 5f;



    [SerializeField]
    float speed;
    float halfSpeed;
    float fullSpeed;
    [SerializeField]
    Rigidbody2D player;

    public float rotationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        halfSpeed = speed * 0.6f;
        fullSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {





        if (Input.GetKey(KeyCode.W))//if the W key is pressed add a force upp 
        {
            player.AddForce(Vector2.up * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))//if moving in more than one direction reduce the speed of the player
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(KeyCode.S))//if the S key is pressed add a force down 
        {
            player.AddForce(Vector2.down * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D))//if moving in more than one direction reduce the speed of the player
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(KeyCode.D))//if the D key is pressed add a force right 
        {
            player.AddForce(Vector2.right * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))//if moving in more than one direction reduce the speed of the player
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(KeyCode.A))//if the A key is pressed add a force left 
        {
            player.AddForce(Vector2.left * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D))//if moving in more than one direction reduce the speed of the player
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }

        // Get the direction of movement
        Vector2 direction = GetComponent<Rigidbody2D>().velocity;

        // Calculate the angle in radians
        float angle = Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg;

        // Create a rotation quaternion based on the angle
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Rotate towards the calculated angle smoothly
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}
