using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuardAnimation : MonoBehaviour
{
    public Vector2 movement;
    public Animator anim;
    private Renderer rend;

    [SerializeField] Transform destination;

    [SerializeField] Transform guard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination.position, 2 * Time.deltaTime);//move toward the current destination -Sixten
        //transform.position = guard.position;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
    }
}
