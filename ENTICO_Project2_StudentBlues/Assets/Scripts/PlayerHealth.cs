using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float currentHP;
    public float maxHP;

    [SerializeField] private string loadLevel;

    private void OnCollisionEnter2D (Collision2D other)
    {

        if(other.collider.tag == "enemy")
        {
            FindObjectOfType<AudioManager>().Play("hit");
            currentHP--;
        }

        if (other.collider.tag == "Exit")
        {
            FindObjectOfType<AudioManager>().Play("exit");
        }

        if (currentHP <= 0)
        {
            SceneManager.LoadScene(loadLevel);
        }
    }
}
