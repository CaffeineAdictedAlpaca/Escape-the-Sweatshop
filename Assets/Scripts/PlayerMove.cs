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
    float sprintSpeed;
    float halfSprintSpeed;
    float noSprintHalfSpeed;
    float maxStamina;
    [SerializeField]
    Rigidbody2D player;
    public float rotationSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        halfSpeed = speed * 0.6f;
        fullSpeed = speed;
        sprintSpeed = speed * 2;
        halfSprintSpeed = sprintSpeed * 0.6f;
        noSprintHalfSpeed = speed * 0.6f;
        maxStamina = stamina;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0)
        {
            stamina -= 1 * Time.deltaTime;
        }
        else if(maxStamina >= stamina)
        {
            stamina += 1 * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            
            halfSpeed = halfSprintSpeed;
            fullSpeed = sprintSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            halfSpeed = noSprintHalfSpeed;
            fullSpeed = sprintSpeed / 2;
        }

        if (stamina <= 0.00f)
        {
            halfSpeed = noSprintHalfSpeed;
            fullSpeed = speed;
        }
            


        
        if (Input.GetKey(KeyCode.W))//if the W key is pressed add a force upp -Sixten

        {
            player.AddForce(Vector2.up * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))//if moving in more than one direction reduce the speed of the player -Sixten
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(KeyCode.S))//if the S key is pressed add a force down -Sixten
        {
            player.AddForce(Vector2.down * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D))//if moving in more than one direction reduce the speed of the player -Sixten
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(KeyCode.D))//if the D key is pressed add a force right -Sixten
        {
            player.AddForce(Vector2.right * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))//if moving in more than one direction reduce the speed of the player -Sixten
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(KeyCode.A))//if the A key is pressed add a force left -Sixten
        {
            player.AddForce(Vector2.left * speed * Time.deltaTime);
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D))//if moving in more than one direction reduce the speed of the player -Sixten
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }

        // Get the direction of movement -Sixten
        Vector2 direction = GetComponent<Rigidbody2D>().velocity;

        // Calculate the angle in radians -Sixten
        float angle = Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg;

        // Create a rotation quaternion based on the angle -Sixten
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Rotate towards the calculated angle smoothly -Sixten
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}
