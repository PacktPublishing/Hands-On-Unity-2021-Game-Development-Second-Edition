using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SpawnerPlacer : MonoBehaviour
{
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject spawnerPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) &&
            GetComponent<ARRaycastManager>().Raycast(Input.mousePosition, hits))
        {
            Instantiate(spawnerPrefab, hits[0].pose.position, hits[0].pose.rotation);
        }
    }
}


