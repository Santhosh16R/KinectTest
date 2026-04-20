using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 120f;

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    public void MoveBackward()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
    }

    public void RotateLeft()
    {
        transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);
    }

    public void RotateRight()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}