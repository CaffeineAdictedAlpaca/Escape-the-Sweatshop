using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] 
    public float rotationSpeed;
    private bool rotateClockwise = true;
    public float maxMove;
    public float minMove;
    //gjord av derrick och sixten
    void Update()
    {
        if (transform.rotation.z > maxMove)//when the camera rotates past max rotation the rotation direction reverses -Sixten
        {
            rotateClockwise = !rotateClockwise;
        }
        if (transform.rotation.z < minMove)//when the camera rotates past minimum rotation the rotation direction reverses -Sixten
        {
            rotateClockwise = !rotateClockwise;
        }

        if (rotateClockwise == true)//if rotate clockwise is true rotate clokwise -Sixten
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }

        if (rotateClockwise == false)//if rotate clockwise is fals rotate counter clokwise -Sixten
        {
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
}