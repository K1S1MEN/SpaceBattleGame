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


        Vector3 movement = new Vector3(x, 0.0f, z);
        rb.linearVelocity = movement * speed;
    }
}
