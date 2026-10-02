using UnityEngine;

public class Bullet : MonoBehaviour
{
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

}
