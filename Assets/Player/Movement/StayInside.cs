/*Created by Classic Cap Studios
Keeps player within the bounds of the camera */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.75f, 2.75f),
        	Mathf.Clamp(transform.position.y, -5f, 5f), transform.position.z);
    }
}
