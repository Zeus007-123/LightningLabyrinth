using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;

    private float horizontal;
    private float vertical;

    [SerializeField] private Button buttonResume;
    [SerializeField] private Button buttonHome;
    [SerializeField] private float moveLimiter = 0.7f;
    [SerializeField] private float runSpeed = 20.0f;

    public ScoreController scoreController;
    public GameObject PauseMenuScreen;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            PauseMenuScreen.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        if (horizontal != 0 && vertical != 0) 
        {
            // limit movement speed diagonally
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }

        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
    public void PickUpKey()
    {
        scoreController.IncreaseScore(5);
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
