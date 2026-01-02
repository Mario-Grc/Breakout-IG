using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public float minVerticalSpeed = 1.0f;
    private Rigidbody2D rb;
    public GameOverManager gameOverManager;
    private Transform playerTransform;

    void Start()
    {
        gameOverManager = GameObject.FindGameObjectWithTag("GameOverManager").GetComponent<GameOverManager>();
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(0f, -2f).normalized * speed;
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void FixedUpdate()
    {
        Vector2 vel = rb.linearVelocity;

        // para asegurarnos de que la pelota no se queda atascada
        if (Mathf.Abs(vel.y) < minVerticalSpeed) {
            // Forzar un componente vertical m�nimo
            vel.y = minVerticalSpeed * Mathf.Sign(vel.y);
            // Si y era 0, forzar hacia abajo
            if (vel.y == 0) vel.y = -minVerticalSpeed;
        }

        // Mantener velocidad constante
        rb.linearVelocity = vel.normalized * speed;

        if (playerTransform != null && transform.position.y < (playerTransform.position.y - 1))
        {
            gameOverManager.gameOver();
        }
    }
}
