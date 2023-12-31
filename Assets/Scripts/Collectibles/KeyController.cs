using UnityEngine;

public class KeyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

        if (playerController != null)
        {
            CameraShake.Instance.ShakeCamera();
            playerController.PickUpKey();
            SoundManager.Instance.Play(Sounds.KeyPickUp);
            Destroy(gameObject);
        }
    }
}
