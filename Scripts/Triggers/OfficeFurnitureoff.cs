using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfficeFurnitureoff : MonoBehaviour
{
    private bool isInRange;
    public GameObject EF;//get the Enterance furnitures from the game

    // Update is called once per frame
    void Update()
    {
        if(isInRange){
            //disactivates the all furnitures that are active
            EF.SetActive(false);
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
