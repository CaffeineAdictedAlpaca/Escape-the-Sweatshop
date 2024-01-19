using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GuardAnimation : MonoBehaviour
{
    public Vector2 movement;
    public Animator anim;
    private Renderer rend;

    [SerializeField] Transform guard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(guard.position.x, guard.position.y + 0.6f);//make the guard animation follow the guard and give it an affset for grafical reasons -Sixten

        if ((int)guard.rotation.z == 0f)//if the guard is moving to the right play the right walking animation -Sixten
        {
            movement = new Vector2(1, 0);
        }
        if (guard.rotation.z > 0.6f && guard.rotation.z < 0.8f)//if the guard is moving up play the up walking animation -Sixten
        {
            movement = new Vector2(0, 1);
        }
        if (guard.rotation.z < -0.6f && guard.rotation.z > -0.8f)//if the guard is moving down play the down walking animation -Sixten
        {
            movement = new Vector2(0, -1);
        }
        if ((int)guard.rotation.z == -1f)//if the guard is moving to the left play the left walking animation -Sixten
        {
            movement = new Vector2(-1, 0);
        }

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
    }
}
