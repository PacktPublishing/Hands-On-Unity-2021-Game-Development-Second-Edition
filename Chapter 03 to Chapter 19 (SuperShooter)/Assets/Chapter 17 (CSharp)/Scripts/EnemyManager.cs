using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    public List<Enemy> enemies;
    
    public UnityEvent onChanged;

    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
        onChanged.Invoke();
    }
    
    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
        onChanged.Invoke();
    }
    
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.LogError("Duplicated EnemyManager", gameObject);
    }
}