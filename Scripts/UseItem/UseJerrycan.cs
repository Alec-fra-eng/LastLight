using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseJerrycan : MonoBehaviour
{
    private bool isInRange;
    public GameObject UtilityCelling;
    public GameObject RoomDoors;
    public GameObject LQDoors;
    public GameObject LQLightTrigger;
    public GameObject ULightTrigger;
    public GameObject SLightTrigger;
    // Update is called once per frame
    void Update()
    {
        //check to see if the player has the jerry can
        if (Player.gotJerrycan){
            //check to see if the player is in range and if they presses the e key
            if(isInRange && Input.GetKeyDown(KeyCode.E)){
                //activate the lights and removes the doors the LQ
                UtilityCelling.SetActive(true);
                RoomDoors.SetActive(false);
                LQDoors.SetActive(false);
                LQLightTrigger.SetActive(true);
                ULightTrigger.SetActive(true);
                SLightTrigger.SetActive(true);
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
