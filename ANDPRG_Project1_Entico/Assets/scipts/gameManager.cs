using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public float delayRestart = 1f;
    bool gameEnded = false;

    public void restartGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart", delayRestart);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
