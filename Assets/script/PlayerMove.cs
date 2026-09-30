using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Transform cameraPivot;

    public float sensitivity = 2.0f;
    public float speed = 1f;
    private float xRotation = 0f;

    static public bool PlayerPose = false;

    Rigidbody rb;

    void Start()
    {
        rb  = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPose = !PlayerPose;
        }

        if (!PlayerPose)
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");

            float mx = Input.GetAxis("Mouse X") * sensitivity;
            float my = Input.GetAxis("Mouse Y") * sensitivity;
            xRotation -= my;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            cameraPivot.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            Vector3 movement = (transform.forward * z + transform.right * x).normalized;
            rb.linearVelocity = new Vector3(movement.x * speed, rb.linearVelocity.y, movement.z * speed);
            transform.Rotate(Vector3.up * mx);
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
        
    
}
