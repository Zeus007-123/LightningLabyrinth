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
            LevelComplete();
        }

    }
    public void LevelComplete()
    {
        LevelCompleteScreen.SetActive(true);
    }
    public void Restart_Scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }
}
