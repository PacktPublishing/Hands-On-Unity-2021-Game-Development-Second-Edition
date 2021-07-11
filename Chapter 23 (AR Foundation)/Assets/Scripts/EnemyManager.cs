using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    public List<Enemy> all = new List<Enemy>();

    void Awake()
    {
        instance = this;
    }
}

