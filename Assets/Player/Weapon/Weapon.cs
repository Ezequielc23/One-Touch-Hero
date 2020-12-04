/*Created by Classic Cap Studios
Controlls the "weapon" which fires player bullets*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bullletPrefab;

    // Update is called once per frame
    void Start()
    {
        //Shoot repeatedly at predetermined time
	    InvokeRepeating("Shoot",1.0f, 1.25f);


        /*  //For Testing
            //Use space bar to fire
            if (Input.GetButtonDown("Jump"))
            {
            Shoot();
            }
        */
    }

    //Creates bullets when called
    void Shoot()
    {
        GameObject.Instantiate(bullletPrefab, firePoint.position, firePoint.rotation);
    }
}