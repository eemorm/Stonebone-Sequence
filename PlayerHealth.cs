using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 100f;

    public void DeductHealth(float deductHealth)
    {
        playerHealth -= deductHealth;
        if (playerHealth <= 0) { PlayerDead(); }
    }

    void PlayerDead()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Spinner")
        {
            DeductHealth(5);
        }
    }
}
