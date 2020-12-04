/*Created by Classic Cap Studios
Controlls the movement of bullets fired by the player and the damage they inflict*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 9f;
    public Rigidbody2D rb;
    public int damage = 40;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the bullet into motion
        rb.velocity = transform.up * bulletSpeed;
    }

    //Checks for collisions with either enemy or asteroid, deals the damage attached to the bullet
    void OnTriggerEnter2D(Collider2D hitInfo){

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        AsteroidHealth asteroid = hitInfo.GetComponent<AsteroidHealth>();
        if (asteroid != null)
        {
            asteroid.TakeDamage(damage);
        }

        if (hitInfo.tag == "Enemy")
        {
        Destroy(gameObject);
        }


   }

}
