using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletShooter : MonoBehaviour
{
    public Transform spawn;
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, spawn.transform.position, transform.rotation);
        }
    }
}
