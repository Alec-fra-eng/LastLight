using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseLabKC : MonoBehaviour
{
    private bool isInRange;
    public GameObject DoorLab;
    public GameObject LabCelling;
    public GameObject RedLight;
    public GameObject GreenLight;
    public GameObject Furniture;

    // Update is called once per frame
    void Update()
    {
        //check to see if the player has the Lab Keycard
        if (Player.gotKCLab){
            //check to see if the player is in range and if they presses the e key
            if(isInRange && Input.GetKeyDown(KeyCode.E)){
                //turns off the red light and the door and turns on the lights and green light
                DoorLab.SetActive(false);
                LabCelling.SetActive(true);
                RedLight.SetActive(false);
                GreenLight.SetActive(true);
                Furniture.SetActive(true);
                Debug.Log("Done");
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
