using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 120f;

    bool forward;
    bool backward;
    bool left;
    bool right;

    void Update()
    {
        if (forward)
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (backward)
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

        if (left)
            transform.Rotate(Vector3.up * -rotationSpeed * Time.deltaTime);

        if (right)
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    // ---------- BUTTON FUNCTIONS ----------
    public void Forward(bool value) => forward = value;
    public void Backward(bool value) => backward = value;
    public void Left(bool value) => left = value;
    public void Right(bool value) => right = value;
}