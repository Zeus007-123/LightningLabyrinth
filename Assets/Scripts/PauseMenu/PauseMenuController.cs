using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] private Button buttonResume;
    [SerializeField] private Button buttonHome;

    public GameObject PauseMenuScreen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            PauseMenuScreen.SetActive(true);
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        SoundManager.Instance.Play(Sounds.ButtonClick);
        PauseMenuScreen.SetActive(false);
    }

    public void GoHome()
    {
        SoundManager.Instance.Play(Sounds.ButtonClick);
        SceneManager.LoadScene(0);
    }
}