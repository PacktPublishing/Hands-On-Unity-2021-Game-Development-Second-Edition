using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        Life life = other.GetComponent<Life>();
        if (life != null)
        {
            life.amount -= damage;
        }
    }
}