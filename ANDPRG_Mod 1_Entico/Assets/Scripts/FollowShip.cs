using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowShip : MonoBehaviour
{
    // from an online script 

    public Transform ShipTransform;
    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtShip = false;

    void Start()
    {
        _cameraOffset = transform.position - ShipTransform.position;
    }


    void Update()
    {
        Vector3 newPos = ShipTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtShip)
        {
            transform.LookAt(ShipTransform);
        }
    }
            
}
