using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public string DamageTag;
    public int HP;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == DamageTag)
        {
            Damage();
        }
    }

    protected virtual void Damage()
    {
        --HP;
        if (HP <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        Destroy(this);
    }

    protected void Attack()
    {

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
