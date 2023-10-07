using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject GameOverScreen;

    [SerializeField] private Button buttonRestart;
    [SerializeField] private Button buttonHome;

    public void GameOver()
    {
        SoundManager.Instance.Play(Sounds.DeathMusic);
        GameOverScreen.SetActive(true);
    }

    public void RestartLevel()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoHome()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene(0);
    }
}