using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerOutage : MonoBehaviour
{
    private bool isInRange;
    public GameObject RoomDoors;
    public GameObject LQCelling;
    public GameObject LQDoor;
    public GameObject MainCelling;
    public GameObject PowerOutageTrigger;
    public GameObject LQLightTrigger;
    public GameObject ULightTrigger;
    public GameObject SLightTrigger;


    // Update is called once per frame
    void Update()
    {
        if(isInRange){
            //turns off all active lights, shuts doors and removes the trigger
            LQCelling.SetActive(false);
            MainCelling.SetActive(false);
            RoomDoors.SetActive(true);
            LQDoor.SetActive(true);
            PowerOutageTrigger.SetActive(false);
            LQLightTrigger.SetActive(false);
            ULightTrigger.SetActive(false);
            SLightTrigger.SetActive(false);
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
