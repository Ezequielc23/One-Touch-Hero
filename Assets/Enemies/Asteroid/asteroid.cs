/*Created by Classic Cap Studios
Handles the speed and direction of the asteroid. Sets the damage
taken by the player ship when collided with*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
	float speed; //for the enemy speed

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;//set speed
    }

    // Update is called once per frame
    void Update()
    {
		transform.Rotate (0,0,50*Time.deltaTime); //rotates 50 degrees per second around z axis

        //Get the enemy current position
        Vector2 position = transform.position;

        //Compute the enemy new position
        position = new Vector2 (position.x, position.y - speed * Time.deltaTime);

        //Compute the enemy new position
        transform.position = position;

        //this is the bottom-left point of the screen
        Vector2 min = Camera.main.ViewportToWorldPoint (new Vector2 (0, 0));

        //if the enemy went outside the screen on the bottom, then destroy the enemy
        if(transform.position.y < min.y)
        {
        	Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
            //Play sound for destruction
            SoundManagerScript.PlaySound ("Explosion");

        PlayerHealth playerHealth = hitInfo.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(1000);
            Destroy(gameObject);
        }
    

        //Destroy the Asteroid

       // Destroy(gameObject);
            //Debug.Log("GOT IT");
        
    }
}
