using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{
    public float distance;
    public float angle;
    public LayerMask objectsLayers;
    public LayerMask obstaclesLayers;

    public Collider detectedObject;
    
    static Collider[] colliders = new Collider[100];

    void Update()
    {
        int detectedAmount= Physics.OverlapSphereNonAlloc(transform.position, distance, colliders, objectsLayers);

        detectedObject = null;
        for (int i = 0; i < detectedAmount; i++)
        {
            Collider collider = colliders[i];
            
            Vector3 directionToCollider = Vector3.Normalize(collider.bounds.center - transform.position);
            
            float angleToCollider = Vector3.Angle(transform.forward, directionToCollider);
            
            if (angleToCollider < angle)
            {
                if (!Physics.Linecast(transform.position, collider.bounds.center, out RaycastHit hit, obstaclesLayers))
                {
                    Debug.DrawLine(transform.position, collider.bounds.center, Color.green);
                    detectedObject = collider;
                    break;
                }
                else
                {
                    Debug.DrawLine(transform.position, hit.point, Color.red);
                }
            }
        }
        
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, distance);

        Vector3 rightDirection = Quaternion.Euler(0, angle, 0) * transform.forward;
        Gizmos.DrawRay(transform.position, rightDirection * distance);
        
        Vector3 leftDirection = Quaternion.Euler(0, -angle, 0) * transform.forward;
        Gizmos.DrawRay(transform.position, leftDirection * distance);
    }
}


public class Pool : MonoBehaviour
{
    List<GameObject> storedObjects = new List<GameObject>();

    [SerializeField] GameObject prefab;

    public GameObject Get()
    {
        if (storedObjects.Count > 0)
        {
            var obj = storedObjects[0];
            storedObjects.RemoveAt(0);
            obj.SetActive(true);
            return obj;
        }
        else
        {
            return Instantiate(prefab);
        }
    }

    public void Return(GameObject obj)
    {
        obj.SetActive(false);
        storedObjects.Add(obj);
    }
}

