/*Create by Classic Cap Studios
Handles the score counter for the UI*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public Text scoreText;

	public float scoreCount;

	public float pointsPerSecond;

	public bool scoreIncreasing;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //increments the score as time increases
        scoreCount += pointsPerSecond * Time.deltaTime;

        //displays the score to the UI
        scoreText.text = "Score:" + Mathf.Round(scoreCount);
        
    }
}
