using UnityEngine;

public class KeyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerController playerController = collision.gameObject.GetComponent<PlayerController>();

        if (playerController != null)
        {
            playerController.PickUpKey();
            CameraShake.Instance.ShakeCamera();
            //SoundManager.Instance.Play(Sounds.KeyPickUp);
            Destroy(gameObject);
        }
    }
}
