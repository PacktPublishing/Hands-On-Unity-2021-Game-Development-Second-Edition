using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnEnable()
    {
        EnemyManager.instance.all.Add(this);
    }

    void OnDisable()
    {
        EnemyManager.instance.all.Remove(this);
    }
}

