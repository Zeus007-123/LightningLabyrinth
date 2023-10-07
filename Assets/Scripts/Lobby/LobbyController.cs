using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LobbyController : MonoBehaviour
{
    [SerializeField] private Button buttonPlay;
    [SerializeField] private Button buttonQuit;

    public void PlayGame()
    {
        //SoundManager.Instance.Play(Sounds.buttonClick);
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        //SoundManager.Instance.Play(Sounds.buttonClick);
        Application.Quit();
    }
}