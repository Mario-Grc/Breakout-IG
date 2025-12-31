using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu;   // panel con los botones de Resume, Quit, etc.
    private bool isPaused = false;
    public GameObject gameOverScreen;   // para saber si ya esta la otra pantalla

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && !gameOverScreen.activeSelf)
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
            pauseMenu.SetActive(true);      // muestra el menú
        }
        else
        {
            Time.timeScale = 1f;           // reanuda
            pauseMenu.SetActive(false);     // oculta el menú
        }
    }

    public void ResumeGame()
    {
        // Para llamar desde el botón "Resume"
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