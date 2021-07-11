using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    
    float lastShootTime;
    public float fireRate;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            var timeSinceLastShoot = Time.time - lastShootTime;
            if(timeSinceLastShoot < fireRate)
                return;

            lastShootTime = Time.time;

            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
    }
}