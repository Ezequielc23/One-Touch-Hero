/*Created by Classic Cap Studios
Controls "Enemy" health and death. Allows a
health integer to be assigned to enemy. Controls sound,
explosion, and death of an enemy. */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Xplode;
    public Transform target;
    public Transform myTransform;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    //Set enemy health to maximum value specified for that enemy
    void Start()
    {
        currentHealth = maxHealth;
    	healthBar.SetMaxHealth(maxHealth);

    }

    //Decrements enemy health by value of accepted damage int
    public void TakeDamage(int damage)
    {
        currentHealth -= damage; //decrease health

        healthBar.SetHealth(currentHealth); //update healthBar

        SoundManagerScript.PlaySound("Damage"); //Play damage noise

        if (currentHealth <= 0)
        {
            Instantiate(Xplode, transform.position, transform.rotation); // Show Explosion
            Die();

        }
    }

    //Destroy enemy object, play explosion noise
    void Die()
    {
        SoundManagerScript.PlaySound("Explosion");
        //Play sound for destruction
        Destroy(gameObject);
    }
}
