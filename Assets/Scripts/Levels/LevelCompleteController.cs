using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelCompleteController : MonoBehaviour
{
    [SerializeField] private Button buttonRestart;
    [SerializeField] private Button buttonHome;

    public GameObject LevelCompleteScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

        if (playerController != null)
        {
            CameraShake.Instance.ShakeCamera();
            SoundManager.Instance.Play(Sounds.LevelWin);
            LevelComplete();
        }

    }
    public void LevelComplete()
    {
        LevelCompleteScreen.SetActive(true);
    }
    public void Restart_Scene()
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
