using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadlevel : MonoBehaviour
{
    public int leveltoLoad = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Loadscene(leveltoLoad);
        }
    }
    public void Loadscene(int LevelID)
    {
        SceneManager.LoadScene(LevelID);
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
