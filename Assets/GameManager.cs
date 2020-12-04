/*Created by Classic Cap Studios
Handles the loading of game over scene*/
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Sets game as NOT over
    bool gameHasEnded = false;

    //Optional delay between time that game is over and the loading of the gameOver scene 
    public float gameOverDelay = 0f;

    //When called, sets game as "Ended" after specified delay
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("GameOver", gameOverDelay);
        }
    }

    //Loads the Game Over scene
    void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

}
