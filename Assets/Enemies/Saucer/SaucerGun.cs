/*Create by Classic Cap Studios
Determines the firerate and initialization of the bullet*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerGun : MonoBehaviour
{
	public GameObject EnemyBullet; //this is our enemy bullet prefab

    // Start is called before the first frame update
    void Start()
    {
        //fire an enemy bullet after  1 second
        Invoke ("FireEnemyBullet", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Function to fire an enemy bullet
    void FireEnemyBullet()
    {
    	//get a reference to the player's ship
    	GameObject playerShip = GameObject.Find ("Ship");

    	if(playerShip != null)//if the player is not dead
    	{
    		//instantiate an enemy bullet
    		GameObject bullet = (GameObject)Instantiate(EnemyBullet);

    		//set the bullet's initial position
    		bullet.transform.position = transform.position;

    		//compute the bullet's direction towards the player's ship
    		Vector2 direction = playerShip.transform.position - bullet.transform.position;

    		bullet.GetComponent<SaucerBullet>().SetDirection(direction);
    	}
    }
}


