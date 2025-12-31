using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public GameOverManager gameOverManager;
    private Transform playerTransform;

    void Start()
    {
        gameOverManager = GameObject.FindGameObjectWithTag("GameOverManager").GetComponent<GameOverManager>();
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(2f, -2f).normalized * speed;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        // Mantener velocidad constante
        rb.linearVelocity = rb.linearVelocity.normalized * speed;

        if (playerTransform != null && transform.position.y < playerTransform.position.y)
        {
            gameOverManager.gameOver();
        }
    }
}
