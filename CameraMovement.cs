using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform car;
    public float upValue;
    
    private Vector3 offset;
    
    void Start()
    {
        offset = new Vector3(0, upValue, 0);
    }

    void LateUpdate()
    {
        transform.position = car.position + offset;
    }
}
