/*Create by Classic Cap Studios
Responsible for decrementing player health when player collider comes into contact
with an enemy collider. */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        //If collider with this script attached comes into contact with the player ship, then cause damage to player ship
        PlayerHealth playerHealth = hitInfo.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            //Play sound for destruction
            SoundManagerScript.PlaySound("Damage");

            playerHealth.TakeDamage(25);
            //Destroy(gameObject);
        }

    }
}
