/*Create by Classic Cap Studios
Handles the sound effects for events within the game*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

	public static AudioClip DeathSound, HurtSound;
	static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        //Sound for when a ship dies
        DeathSound = Resources.Load<AudioClip> ("Explosion");

        //Sound for when a ship takes damage
        HurtSound = Resources.Load<AudioClip> ("Damage");

        //source for audio
        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        //Switches between whichever sound is being played
    	switch (clip) {
    		case "Explosion":
    		audioSrc.PlayOneShot (DeathSound);
    		break;
            case "Damage":
            audioSrc.PlayOneShot (HurtSound);
            break;
    	}
    }
}
