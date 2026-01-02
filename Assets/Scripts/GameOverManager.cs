using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverScreen;

    void Start()
    {
        if (gameOverScreen == null)
        {
            gameOverScreen = GameObject.FindWithTag("GameOverScreen");
        }
        gameOverScreen.SetActive(false);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}