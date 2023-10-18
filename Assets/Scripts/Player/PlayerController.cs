using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;

    private float horizontal;
    private float vertical;

    [SerializeField] private float moveLimiter = 0.7f;
    [SerializeField] private float runSpeed = 20.0f;

    public ScoreController scoreController;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

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
}
