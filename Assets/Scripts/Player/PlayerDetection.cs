using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public GameOverController gameOverController;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the trigger belongs to a light source
        if (other.CompareTag("LightSource"))
        {
            LightSourceController lightSource = other.GetComponent<LightSourceController>();

            // Check if the light source is active
            if (lightSource != null && lightSource.IsLightActive())
            {
                CameraShake.Instance.ShakeCamera();
                Detect();
            }
        }
    }

    private void Detect()
    {
        gameOverController.GameOver();
    }
}