using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float frequency;

    void Awake()
    {
        InvokeRepeating("Spawn", frequency, frequency);
    }

    void Spawn()
    {
        var obj = Instantiate(prefab, transform.position, transform.rotation);

        var myCollider = GetComponentInChildren<Collider>();
        var spawnedCollider = obj.GetComponentInChildren<Collider>();
        
        //Check if both objects have collider
        if (myCollider != null && spawnedCollider != null)
        {
            Physics.IgnoreCollision(myCollider, spawnedCollider);
        }
    }
}