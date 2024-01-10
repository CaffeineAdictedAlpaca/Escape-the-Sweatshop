using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    Transform[] destination;

    // Speed at which the object rotates -Sixten
    public float rotationSpeed = 5.0f;

    public int nextDestination;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void moveToNextPoint()//changes the destination to the next point in the destination array -Sixten
    {
        nextDestination += 1;
        if (nextDestination >= destination.Length)//loops the path the enemy walks by making the destination after the last destination into the first destination -Sixten
        {
            nextDestination = 0;
        }

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination[nextDestination].position, speed * Time.deltaTime);//move toward the current destination -Sixten

        if (transform.position == destination[nextDestination].position)//when enemy has arrived to its destination change the destination to the next point in the destination array -Sixten
        {
            moveToNextPoint();
        }

        // Check if the target point is not null -Sixten
        if (destination[nextDestination] != null)
        {
            // Calculate the direction to the next destination -Sixten
            Vector2 direction = destination[nextDestination].position - transform.position;

            // Ensure the object is not already at the target point -Sixten
            if (direction != Vector2.zero)
            {
                // Calculate the angle between the current direction and the right vector (1, 0) -Sixten
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

                // Create a rotation quaternion based on the calculated angle -Sixten
                Quaternion targetRotation = Quaternion.Euler(0, 0, angle);

                // Smoothly rotate towards the target rotation -Sixten
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }
        }
    }
}
