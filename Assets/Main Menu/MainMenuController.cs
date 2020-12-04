/*Created by Classic Cap Studios
Handles the main menu buttons and what those buttons do*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;

    //Loads the game scene
    public void playGame()
    {
        SceneManager.LoadScene("Main Game");
    }

    //Displays options
    public void options()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    //Goes back to main menu from options
    public void back()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }

    //Exits to Main Menu (From Game Over)
    public void menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //Quits application.
    //Only works on device, button is not functional if used within Unity editor
    public void exitGame()
    {
        Application.Quit();
    }

    //Loads credits scene
    public void credits()
    {
        SceneManager.LoadScene("Credits");
    }

}