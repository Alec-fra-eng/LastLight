using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMech : MonoBehaviour
{
    public GameObject MACelling;
    public GameObject LQCelling;
    public GameObject SCelling;
    public GameObject UCelling;
    public GameObject LCelling;
    public GameObject Torch;

    // Update is called once per frame
    void Update()
    {
        //check to see if there is no celling 
        if(MACelling.activeSelf==false && LQCelling.activeSelf==false && SCelling.activeSelf==false && UCelling.activeSelf==false && LCelling.activeSelf==false){
            //check if the torch is active
            if(Torch.activeSelf==false){
                //the player takes damage
                Player.health--;
            }
        }
    }
}
