using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    public GameObject gameOverScreen;

    void Update()
    {
        if (!gameOverScreen.activeSelf) { 
            float horizontal = Input.GetAxis("Horizontal");
            transform.position += Vector3.right * horizontal * speed * Time.deltaTime;
        }
    }
}
