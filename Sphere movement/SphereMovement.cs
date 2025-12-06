using UnityEngine;
using UnityEngine.InputSystem;

public class SphereMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    private Vector2 moveInput;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveInput.x, 0, moveInput.y);

        rb.MovePosition(transform.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
