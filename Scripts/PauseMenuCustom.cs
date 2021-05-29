using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuCustom : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject DeathUI;
    public GameObject EndUI;

    // Update is called once per frame
    void Update()
    {
        //check to see if the escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape)){
            //check to see if the death user interface and end interface are not active
            if(DeathUI.activeSelf==false && EndUI.activeSelf==false){
                Debug.Log(Application.persistentDataPath);
                //check the bool in GameIsPaused
                if (GameIsPaused){
                    //do the method Resume
                    Resume();
                }else
                {
                    //do the method Pause
                    Pause();
                }
            }
        }
    }

    public void Resume(){
        //disactivate the pause menu interface and resumes the play of the game and changes the GameIsPaused to false
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    } 

    void Pause(){
        //activate the pause menu and pause the play of the game changes the GameIsPaused to true
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void SaveGame(){
          //save the game
        Debug.Log("Game Saving...");
       // SaveSystem.SavePlayer(this);
    }

    //load the main menu and unpause the game
    public void LoadMainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
