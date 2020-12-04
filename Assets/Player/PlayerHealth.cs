/*Created by Classic Cap Studios
Controls Player health and damage, as well as death and explosion */
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public GameObject Xplode;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;
    public Scene GameOver;
    void Start()
    {
        //Sets current health equal to max health
        currentHealth = maxHealth;
    	healthBar.SetMaxHealth(maxHealth);

    }

    //Inflicts recieved damage onto the player
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        //Checks if health <= 0, if yes calls Die(), shows explosion, and starts game over process.
        if (currentHealth <= 0)
                  {
            Die();
            Instantiate(Xplode, transform.position, transform.rotation); // Show Explosion
            FindObjectOfType<GameManager>().EndGame();
                   }
      }

    //Makes player object invisible to allow for view of the explosion
    public void Die()
    {
        transform.localScale = new Vector3(0, 0, 0);

        //Testing: 
        //Destroy(gameObject);
    }


}
