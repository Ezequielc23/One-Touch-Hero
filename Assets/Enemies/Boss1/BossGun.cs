/*Create by Classic Cap Studios
Handles the shooting of bullets by Boss 1*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGun : MonoBehaviour
{
    public GameObject EnemyBullet; //this is our enemy bullet prefab

    // Start is called before the first frame update
    void Start()
    {
        //fire an enemy bullet after  1 second
        InvokeRepeating ("FireEnemyBullet", 1f, .35f);
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

    		bullet.GetComponent<bossbullet>().SetDirection(direction);
    	}
    }
}
