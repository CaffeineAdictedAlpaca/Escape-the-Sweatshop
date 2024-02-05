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

    public Image staminaBar;
    private bool timerDone = false;
    public float stamina = 1f;
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
    //Variables för animation - Adrian
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
        // Animerar karaktären - Adrian
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.sqrMagnitude);

        // Stamina script - Santiago
        staminaText.text = ("Stamina: ") +  stamina.ToString("F1");

        staminaTimer += 1 * Time.deltaTime;

        if (Input.GetKey(settings.controls[5].key) && stamina > 0)
        {

            staminaTimer = 0;
            staminaBar.fillAmount -= 1 * Time.deltaTime;
            stamina -= 1 * Time.deltaTime;
            timerDone = false;
        }
        else if ((maxStamina > stamina) && timerDone == true)
        {
            staminaBar.fillAmount += 1 * Time.deltaTime;
            stamina += 1 * Time.deltaTime;
        }

        
        if(staminaTimer >= 2)
        {
            timerDone = true;
        }

        if (Input.GetKeyDown(settings.controls[5].key) && stamina > 0)
        {
            
            halfSpeed = halfSprintSpeed;
            fullSpeed = sprintSpeed;
        }

        if (Input.GetKeyUp(settings.controls[5].key))
        {
            halfSpeed = noSprintHalfSpeed;
            fullSpeed = sprintSpeed / 2;
        }

        else if (stamina <= 0f)
        {
            halfSpeed = noSprintHalfSpeed;
            fullSpeed = speed;
        }
            


        
        if (Input.GetKey(settings.controls[0].key))//if the W key is pressed add a force upp -Sixten

        {
            //anim.SetFloat("Horizontal", 1);
            player.AddForce(Vector2.up * speed * Time.deltaTime);
            if (Input.GetKey(settings.controls[2].key) || Input.GetKey(settings.controls[1].key) || Input.GetKey(settings.controls[3].key))//if moving in more than one direction reduce the speed of the player -Sixten
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(settings.controls[1].key))//if the S key is pressed add a force down -Sixten
        {
            //anim.SetFloat("Horizontal", -1);
            player.AddForce(Vector2.down * speed * Time.deltaTime);
            if (Input.GetKey(settings.controls[2].key) || Input.GetKey(settings.controls[0].key) || Input.GetKey(settings.controls[3].key))//if moving in more than one direction reduce the speed of the player -Sixten
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(settings.controls[3].key))//if the D key is pressed add a force right -Sixten
        {
            //anim.SetFloat("Vertical", 1);
            player.AddForce(Vector2.right * speed * Time.deltaTime);
            if (Input.GetKey(settings.controls[2].key) || Input.GetKey(settings.controls[0].key) || Input.GetKey(settings.controls[1].key))//if moving in more than one direction reduce the speed of the player -Sixten
            {
                speed = halfSpeed;
            }
            else
            {
                speed = fullSpeed;
            }
        }
        if (Input.GetKey(settings.controls[2].key))//if the A key is pressed add a force left -Sixten
        { 
            //anim.SetFloat("Vertical", -1);
            player.AddForce(Vector2.left * speed * Time.deltaTime);
            if (Input.GetKey(settings.controls[1].key) || Input.GetKey(settings.controls[0].key) || Input.GetKey(settings.controls[3].key))//if moving in more than one direction reduce the speed of the player -Sixten
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
