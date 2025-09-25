using UnityEngine;

public class Pausescene : MonoBehaviour
{
    public KeyCode pausekey = KeyCode.Escape;
    public GameObject pauseMenu;
    bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(pausekey))
        {
            PauseSystem();
        }
    }

    public void PauseSystem()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            if (pauseMenu != null)
            {
                pauseMenu.SetActive(true);
            }
            Time.timeScale = 0f;
        }
        else
        {
            if (pauseMenu != null)
            {
                pauseMenu.SetActive(false);
            }
            Time.timeScale = 1f;
        }
    }
}
