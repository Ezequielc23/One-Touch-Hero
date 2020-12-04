/*Created by Classic Cap Studios
Handles various health bars for both player and enemy*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    //Slider is used inside of a frame (sprite/UI grpahic) to set appearance of healthbar.
    public Slider slider;

    //Sets health bar slider at max value to start
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    //Sets health bar slider at new value each time this is called
    public void SetHealth (int health)
    {
        slider.value = health;
    }
}
