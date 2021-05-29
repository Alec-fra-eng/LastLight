using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureOffOn : MonoBehaviour
{
  private bool isInRange;
    public GameObject OffFurniture;
    public GameObject OnFurniture;
    // Update is called once per frame
    void Update()
    {
        // check to see if the player is in range
        if(isInRange){
            //removes some furniture and add some furniture
            OffFurniture.SetActive(false);
            OnFurniture.SetActive(true);
            Debug.Log("changed");

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
