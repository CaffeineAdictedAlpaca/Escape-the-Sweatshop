using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] 
    public float rotationSpeed;
    private bool rotateClockwise = true;

    void Update()
    {
        if (transform.rotation.z > 0.5f)
        {
            rotateClockwise = !rotateClockwise;
        }
        if (transform.rotation.z < -0.5f)
        {
            rotateClockwise = !rotateClockwise;
        }

        if (rotateClockwise == true)
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }

        if (rotateClockwise == false)
        {
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
}