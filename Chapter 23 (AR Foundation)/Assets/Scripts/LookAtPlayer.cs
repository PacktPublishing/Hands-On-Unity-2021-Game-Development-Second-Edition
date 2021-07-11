using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    void Update()
    {
        if(PlayerManager.instance == null) return;

        transform.forward = PlayerManager.instance.transform.position - transform.position;
    }
}


