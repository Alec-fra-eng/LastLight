using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchMech : MonoBehaviour
{
    public bool isOn = false;
    public GameObject light;
    
    // Update is called once per frame
    void Update()
    {
        //check if the player presses the f key
        if(Input.GetKeyDown(KeyCode.F)){
            //check if the light is on
            if(isOn == false){
                //activate the torch
                light.SetActive(true);
                isOn = true;
            }
            //check if the light is off
            else
            {
                //disactivate the torch
                light.SetActive(false);
                isOn = false; 
            }
       }
    }
}
