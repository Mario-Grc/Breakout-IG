using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * horizontal * speed * Time.deltaTime;
    }
}
