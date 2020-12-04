//Classic Cap Studios
//This script destroys a game object that it gets attached to
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer: MonoBehaviour
{

    void Die()
    {
        Destroy(gameObject); //Destroys game object 
    }
}
