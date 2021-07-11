using UnityEngine;

public class Damager : MonoBehaviour
{
    public int amount;
    
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Life>()?.Damage(amount);
        Destroy(gameObject);
    }
}

    