/*Created by Classic Cap Studios
Responsible for moving a background sprite to top of camera after
"ScrollingObject.cs" has moved it below camera view. */
using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour
{
    private float spaceVerticalHeight;

    //Awake is called before Start.
    private void Awake()
    { 
        //Store the size of the space tile along the y axis (its length in units).
        spaceVerticalHeight = 11.2196f;
    }

    //Update runs once per frame
    private void Update()
    {
        //Check if the difference along the y axis between the main Camera and the position of the object this is attached to is greater than spaceVerticalHeight.
        if (transform.position.y < -spaceVerticalHeight)
        {
            //If true, this means this object is no longer visible and we can safely move it forward to be re-used.
            RepositionBackground();
        }
    }

    //Moves the object this script is attached to top in order to create our looping background effect.
    private void RepositionBackground()
    {
        //This is how far upward we will move our background object, in this case, twice its length. This will position it directly above the currently visible background object.
        Vector2 spaceOffSet = new Vector2(0, spaceVerticalHeight * 2f);

        //Move this object from it's position offscreen, below the player, to the new position off-camera above the player.
        transform.position = (Vector2)transform.position + spaceOffSet;
    }
}