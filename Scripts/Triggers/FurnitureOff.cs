using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureOff : MonoBehaviour
{
    private bool isInRange;
    public GameObject LQF;//get the Living Quarter furnitures from the game
    public GameObject UF;//get the Utility furnitures from the game
    public GameObject SF;//get the Storage furnitures from the game
    public GameObject LF;//get the Lab furnitures from the game

    // Update is called once per frame
    void Update()
    {
        if(isInRange){
            //disactivates the all furnitures that are active
            LQF.SetActive(false);
            UF.SetActive(false);
            SF.SetActive(false);
            LF.SetActive(false);
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
