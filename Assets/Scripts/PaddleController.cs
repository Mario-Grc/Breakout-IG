using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;
    public float minx = -9.1f;
    public float maxx = 9.1f;
    public GameObject gameOverScreen;

    void Update()
    {
        if (!gameOverScreen.activeSelf) { 
            float horizontal = Input.GetAxis("Horizontal");

            Vector3 pos = transform.position;

            pos.x += horizontal * speed * Time.deltaTime;
            pos.x = Mathf.Clamp(pos.x, minx, maxx);

            transform.position = pos;
        }
    }
}
