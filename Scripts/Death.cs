using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject DeathUI;
    // Update is called once per frame
    void Update()
    {
        //check to see if the players health is equal to zero
        if(Player.health==0){
            //active the screen that appears once a player dies and pause the game
            DeathUI.SetActive(true);
            Time.timeScale = 0f;
      }  
    }
    //load the main menu and unpause the game
    public void LoadMainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
