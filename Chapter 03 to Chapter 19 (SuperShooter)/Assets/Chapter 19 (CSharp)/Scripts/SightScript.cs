using UnityEngine;

public class SightScript : MonoBehaviour
{
    public float distance;
    public float angle;
    public LayerMask objectsLayers;
    public LayerMask obstacleLayers;

    public GameObject sensedObject;

    void Update()
    {
        Collider[] detectedObjects = Physics.OverlapSphere(transform.position, distance, objectsLayers);

        sensedObject = null;
        
        foreach (var detectedObject in detectedObjects)
        {
            Vector3 directionToObject = Vector3.Normalize(detectedObject.transform.position - transform.position);
            float angleToObject = Vector3.Angle(transform.forward, directionToObject);

            if (angleToObject < angle)
            {
                if (!Physics.Linecast(transform.position, detectedObject.transform.position, obstacleLayers))
                {
                    sensedObject = detectedObject.gameObject;
                    break;
                }
            }
        }
    }
}
