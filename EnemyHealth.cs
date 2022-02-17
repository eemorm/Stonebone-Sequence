using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 30f;
    public CollisionDetection cd;

    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;
        if (enemyHealth <= 0) { EnemyDead(); }
    }

    void EnemyDead()
    {
        Destroy(gameObject);
    }
}
