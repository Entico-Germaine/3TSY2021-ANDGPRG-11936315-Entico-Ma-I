using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    [SerializeField] private string loadLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(loadLevel);
    }
}
