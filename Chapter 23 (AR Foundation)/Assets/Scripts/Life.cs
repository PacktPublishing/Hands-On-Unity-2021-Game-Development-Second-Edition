using UnityEngine;

public class Life : MonoBehaviour
{
    public int amount;

    public void Damage(int damageAmount)
    {
        amount -= damageAmount;
        if(amount <= 0)
            Destroy(gameObject);
    }
}