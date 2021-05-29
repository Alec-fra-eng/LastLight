using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCrowbar : MonoBehaviour
{
    private bool isInRange;
    public GameObject Door;
    public GameObject Furniture;
    // Update is called once per frame
    void Update()
    {
        //check to see if the player has the crowbar
        if (Player.gotCrowbar == true){
            //check to see if the player is in range and if they click the mouse button
            if(isInRange && Input.GetMouseButtonDown(0)){
                //removes the door 
                Door.SetActive(false);
                Furniture.SetActive(true);
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
