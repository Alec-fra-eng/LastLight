using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreTrigger : MonoBehaviour
{
    private bool isInRange;
    public GameObject DoorToRooms;

    // Update is called once per frame
    void Update()
    {
        if(isInRange){
            //removes the door blocking access to the rooms
            DoorToRooms.SetActive(false);
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
