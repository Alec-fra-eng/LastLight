using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private bool isInRange;
    public GameObject Door;
    public GameObject Celling;

    // Update is called once per frame
    void Update()
    {
        if(isInRange){
            //activates the door the player just passed and disactivates the celling in the room they just left
            Door.SetActive(true);
            Celling.SetActive(false);
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
