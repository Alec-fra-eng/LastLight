using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseUKC : MonoBehaviour
{
 private bool isInRange;
    public GameObject StorageDoor;
    public GameObject RedLight;
    public GameObject GreenLight;
    // Update is called once per frame
    //Debug.Log(Player.gotKCU);
    void Update()
    {
        //check to see if the player has the Utility Keycard
        if(Player.gotKCU == true){
            //check to see if the player is in range and if they presses the e key
            if(isInRange && Input.GetKeyDown(KeyCode.E)){
                //turns off the red light and turns on the lights and green light
                StorageDoor.SetActive(false);
                RedLight.SetActive(false);
                GreenLight.SetActive(true);
            }
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
