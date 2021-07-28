using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    public GameObject bullet;

    void OnCollisionEnter(Collision obstacle)
    {
        if (obstacle.collider.tag == "glass")
        {
            Destroy(obstacle.gameObject);

            Destroy(bullet);
            FindObjectOfType<AudioManager>().Play("SmashWall");
        }
    }
}
