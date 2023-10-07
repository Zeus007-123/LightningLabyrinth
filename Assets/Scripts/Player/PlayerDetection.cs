using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public GameOverController gameOverController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("LightSource"))
        {
            LightSourceController lightSource = other.GetComponent<LightSourceController>();

            if (lightSource != null && lightSource.IsLightActive())
            {
                CameraShake.Instance.ShakeCamera();
                SoundManager.Instance.Play(Sounds.Alarm);
                Detect();
            }
        }
    }

    private void Detect()
    {
        gameOverController.GameOver();
    }
}