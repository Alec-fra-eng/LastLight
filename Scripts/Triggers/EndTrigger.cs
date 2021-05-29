using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    private bool isInRange;
    public GameObject EndUI;

    // Update is called once per frame
    void Update()
    {
        //check to see if the player has the black box
        if (Player.gotBlackBox){
            if(isInRange){
                //activates the end interface and pauses the games
                 EndUI.SetActive(true);
                 Time.timeScale = 0f;
            }
        }
    }
    
    //load the main menu and unpause the game
    public void LoadMainMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    //check to see if the player is in the hitbox of the object
    private void OnTriggerEnter(Collider other){
        isInRange = true;
    }
    //check to see if the player leaves the hitbox of the object
    private void OnTriggerExit(Collider other){
        isInRange = false;
    }
}
