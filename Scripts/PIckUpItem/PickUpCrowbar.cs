using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCrowbar : MonoBehaviour
{
    public GameObject crowbar;
    private bool isInRange;

    private void Update(){
        // check to see if the player is in range and if the player press the e key
        if(isInRange && Input.GetKeyDown(KeyCode.E)){
            //removes the crowbar and says the player has it
            crowbar.SetActive(false);
            Player.gotCrowbar=true;
        }
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
