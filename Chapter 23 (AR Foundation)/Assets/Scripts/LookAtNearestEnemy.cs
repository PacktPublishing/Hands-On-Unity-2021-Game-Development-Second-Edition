using UnityEngine;

public class LookAtNearestEnemy : MonoBehaviour
{
    void Update()
    {
        if(EnemyManager.instance.all.Count <= 0) return;
        
        var nearestEnemy = EnemyManager.instance.all[0];

        for (var i = 1; i < EnemyManager.instance.all.Count; i++)
        {
            var enemy = EnemyManager.instance.all[i];
            var distToNearest = Vector3.Distance(nearestEnemy.transform.position, transform.position);
            var distToEnemy = Vector3.Distance(enemy.transform.position, transform.position);

            if (distToEnemy < distToNearest)
                nearestEnemy = enemy;
        }

        if (nearestEnemy)
            transform.forward = nearestEnemy.transform.position - transform.position;
    }
}
