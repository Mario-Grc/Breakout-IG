using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = new Vector2(2f, -2f).normalized * speed;
    }

    void FixedUpdate()
    {
        // Mantener velocidad constante
        rb.linearVelocity = rb.linearVelocity.normalized * speed;
    }
}
