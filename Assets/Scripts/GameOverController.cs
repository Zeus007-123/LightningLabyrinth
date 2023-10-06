using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject GameOverScreen;

    [SerializeField] private Button buttonRestart;
    [SerializeField] private Button buttonHome;
    
    public void RestartLevel()
    {
        Debug.Log(" Reloading Active Scene ");
        //SoundManager.Instance.Play(Sounds.buttonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoHome()
    {
        Debug.Log(" Going to Home Lobby Screen/Scene ");
        //SoundManager.Instance.Play(Sounds.buttonClick);
        SceneManager.LoadScene(0);
    }
}