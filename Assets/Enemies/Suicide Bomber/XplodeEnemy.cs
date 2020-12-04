//Classic Cap Studios
//This script spawns an explosion annimation prefab upon the 'Death' of an enemy game object

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XplodeEnemy : MonoBehaviour
{
    public bool isDead;
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject Xplode;
    //public HealthBar healthBar;
    public int AliveTime;
    public Transform target;
    public Transform myTransform;
    public int maxDistance;

    void Start()
    {
        currentHealth = maxHealth;
     //   healthBar.SetMaxHealth(maxHealth);
        StartCoroutine(AliveTimeDelay());
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void Explode()
    {
        Instantiate(Xplode, transform.position, transform.rotation);
    }

    IEnumerator AliveTimeDelay()
    {
        isDead = true;
            if (isDead==true)
            {

                yield return new WaitForSeconds(AliveTime);
                Die();
                Explode();
            }
        }



    void Die()
    {
        Destroy(gameObject);
    }



    void OnTriggerEnter2D(Collider2D hitInfo)
  {
          //Play sound for destruction
          SoundManagerScript.PlaySound ("Explosion");

      PlayerHealth playerHealth = hitInfo.GetComponent<PlayerHealth>();
      if (playerHealth != null)
      {
          playerHealth.TakeDamage(1000);
          Die();
          Explode();
      }
  }
}
