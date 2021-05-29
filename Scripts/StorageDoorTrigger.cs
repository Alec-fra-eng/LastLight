using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageDoorTrigger : MonoBehaviour
{
    private bool isInRange;
    public GameObject Door;
    public GameObject Celling;

    // Update is called once per frame
    void Update()
    {
        if(isInRange){
            Door.SetActive(true);
            Celling.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other){
        isInRange = true;
    }
    private void OnTriggerExit(Collider other){
        isInRange = false;
    }
}
