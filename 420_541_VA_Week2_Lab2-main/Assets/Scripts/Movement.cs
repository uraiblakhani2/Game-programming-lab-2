using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 4.0f;
    private Rigidbody rigidBody;
    private Vector3 movement;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        movement.Set(-vertical, 0, horizontal);

        rigidBody.MovePosition(rigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
