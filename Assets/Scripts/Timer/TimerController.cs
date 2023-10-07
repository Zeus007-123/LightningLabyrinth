using UnityEngine;
using TMPro;

public class TimerController : MonoBehaviour
{
    public float initialTime = 25.0f;
    private float currentTime;
    public TextMeshProUGUI timerText;
    public GameObject exit;
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
                levelComplete = true;
                CameraShake.Instance.ShakeCamera();
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