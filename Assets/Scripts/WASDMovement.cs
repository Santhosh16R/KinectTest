using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 120f;

    void Update()
    {
        Move();
        Rotate();
    }

    void Move()
    {
        float vertical = Input.GetAxis("Vertical");   // W/S
        Vector3 move = transform.forward * vertical * moveSpeed * Time.deltaTime;
        transform.position += move;
    }

    void Rotate()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A/D
        float rotation = horizontal * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotation, 0f);
    }
}
