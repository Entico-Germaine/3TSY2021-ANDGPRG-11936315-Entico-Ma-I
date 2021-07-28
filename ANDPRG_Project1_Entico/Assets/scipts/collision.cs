using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    public GameObject player;

    void OnCollisionEnter(Collision obstacle)
    {
        if(obstacle.collider.tag == "obstacle")
        {
            Destroy(player);

            FindObjectOfType<gameManager>().restartGame();
            FindObjectOfType<AudioManager>().Play("PlayerDie");
        }

        if (obstacle.collider.tag == "glass")
        {
            FindObjectOfType<AudioManager>().Play("HitGlass");
        }
    }
}
