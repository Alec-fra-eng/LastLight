using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
 private bool isInRange;
    //get the game object for the light for both rooms
    public GameObject LightArea1;
    public GameObject LightArea2;

    // Update is called once per frame
    void Update()
    {
        if(isInRange){
            //disactivates the all furnitures that are active
            LightArea1.SetActive(true);
            LightArea2.SetActive(true);
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

