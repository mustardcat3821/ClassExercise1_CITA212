using UnityEngine;
using UnityEngine.InputSystem;

public class Start_Move : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    Vector2 movePlayer;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Run();
    }

    public void OnMove(InputValue value)
    {
        movePlayer = value.Get<Vector2>();
    }

    void Run()
    {
        Vector2 playerVelocity = new Vector2(
            movePlayer.x * moveSpeed,
            rb.linearVelocity.y
        );

        rb.linearVelocity = playerVelocity;
    }
}
