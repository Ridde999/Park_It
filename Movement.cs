using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    void Update()
    {
        transform.Translate(-1 * speed *Time.deltaTime, 0, 0);

        if(Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.forward, -turnSpeed * Time.deltaTime);
        }
    }
}
