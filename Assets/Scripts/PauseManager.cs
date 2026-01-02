using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;   // panel con los botones de Resume, Quit, etc.
    private bool isPaused = false;
    public GameObject gameOverScreen;   // para saber si ya esta la otra pantalla
    public GameObject winScreen;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && !gameOverScreen.activeSelf && !winScreen.activeSelf)
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f;           // pausa todo lo que depende de Time.deltaTime
            pauseMenu.SetActive(true);      // muestra el menu
        }
        else
        {
            Time.timeScale = 1f;           // reanuda
            pauseMenu.SetActive(false);     // oculta el menu
        }
    }

    public void ResumeGame()
    {
        // Para llamar desde el bot�n "Resume"
        isPaused = false;
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ResumeGame();
    }
}