/*Create by Classic Cap Studios
Rotates the sprite used for Boss 2*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBoss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (0,0,175*Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
