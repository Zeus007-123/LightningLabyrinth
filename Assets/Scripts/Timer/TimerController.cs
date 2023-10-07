using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    [SerializeField] private float initialTime = 25.0f;
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private GameObject exit;

    private float currentTime;
    private bool levelComplete;

    public LevelCompleteController levelCompleteController;
    public GameOverController gameOverController;

    private void Start()
    {
        currentTime = initialTime;

        UpdateTimerText(currentTime);
        levelComplete = false;
    }

    private void Update()
    {
        if (!levelComplete)
        {
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
                UpdateTimerText(currentTime);
            }
            else
            {
                CameraShake.Instance.ShakeCamera();
                gameOverController.GameOver();
            }

            if (Vector2.Distance(transform.position, exit.transform.position) < 1.0f)
            {
                CameraShake.Instance.ShakeCamera();
                levelComplete = true;
                levelCompleteController.LevelComplete();
            }
        }
    }

    private void UpdateTimerText(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        string formattedTime = string.Format("TIME: {0:00}:{1:00}", minutes, seconds);
        timerText.text = formattedTime;
    }
}