using UnityEngine;

public class ContactDamager_Chapter17 : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        Life_Chapter17 life = other.GetComponent<Life_Chapter17>();
        if (life != null)
        {
            life.amount -= damage;
        }
    }
}