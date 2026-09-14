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
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        if (Mathf.Abs(mx) > 0.001f)
        {
            transform.RotateAround(transform.position, Vector3.up, mx);

        }
        Vector3 movement = new Vector3(x, 0.0f, z);
        rb.linearVelocity = movement * speed;
    }
}
