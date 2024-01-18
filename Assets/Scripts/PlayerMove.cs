using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    Vector2 movement;
    //Stamina  and sprint (Santiago)
    [SerializeField]
    public TextMeshProUGUI staminaText;

    [SerializeField]
    private bool timerDone = false;
    public float stamina = 5f;
    public float staminaTimer = 2;


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
    public Animator anim;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {

        

        halfSpeed = speed * 0.8f;
        fullSpeed = speed;
        sprintSpeed = speed * 2;
        halfSprintSpeed = sprintSpeed * 0.8f;
        noSprintHalfSpeed = speed * 0.8f;
        maxStamina = stamina;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);


        staminaText.text = ("Stamina: ") +  stamina.ToString("F1");

        staminaTimer += 1 * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift) && stamina > 0)
        {
            staminaTimer = 0;
            stamina -= 1 * Time.deltaTime;
            timerDone = false;
        }
        else if ((maxStamina > stamina) && timerDone == true)
        {
            stamina += 1 * Time.deltaTime;
        }

        
        if(staminaTimer >= 2)
        {
            timerDone = true;
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
            //anim.SetFloat("Horizontal", 1);
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
            //anim.SetFloat("Horizontal", -1);
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
            //anim.SetFloat("Vertical", 1);
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
            //anim.SetFloat("Vertical", -1);
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
        /*
        // Get the direction of movement -Sixten
        Vector2 direction = GetComponent<Rigidbody2D>().velocity;

        // Calculate the angle in radians -Sixten
        float angle = Mathf.Atan2(-direction.x, direction.y) * Mathf.Rad2Deg;

        // Create a rotation quaternion based on the angle -Sixten
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        // Rotate towards the calculated angle smoothly -Sixten
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        */
    }
}
