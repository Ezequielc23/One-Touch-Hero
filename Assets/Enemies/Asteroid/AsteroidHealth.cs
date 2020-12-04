/*Created by Classic Cap Studios
Determines the health of the asteroid*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{

    public int maxHealth = 240;
    public int currentHealth;

    //Sets the asteroids health to maximum
    void Start()
    {
        currentHealth = maxHealth;

    }

    //Decrements asteroid health by value of accepted damage int
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        //Destroy asteroid
        Destroy(gameObject);
    }
}