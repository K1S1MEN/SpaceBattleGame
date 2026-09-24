using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody rb;

    void Start()
    {
        rb  = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        if (Mathf.Abs(mx) > 0.001f)
        {
            transform.RotateAround(transform.position, Vector3.up, mx);

        }
        Vector3 movement = (transform.forward * z + transform.right * x).normalized;
        rb.linearVelocity = new Vector3(movement.x * speed, rb.linearVelocity.y, movement.z * speed);
    }
}
