using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Crouch : MonoBehaviour
{
    CharacterController playerCol;
    float originalHeight;
    public float reducedHeight;
    public FirstPersonController playerSpd;
    float originalWalkSpeed;
    public float reducedWalkSpeed;
    float originalRunSpeed;

    // Start is called before the first frame update
    void Start()
    {
        playerCol = GetComponent<CharacterController>();
        playerSpd = GetComponent<FirstPersonController>();
        originalHeight = playerCol.height;
        originalWalkSpeed = playerSpd.m_WalkSpeed;
        originalRunSpeed = playerSpd.m_RunSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            crouch();
        }
        else if(Input.GetKeyUp(KeyCode.C)){
            uncrouch();
        }
    }

    //Method to reduce height and speed
    void crouch(){
        playerCol.height = reducedHeight;
        playerSpd.m_WalkSpeed = reducedWalkSpeed;
        playerSpd.m_RunSpeed = reducedWalkSpeed; 
    }

     //Method to reset height and speed
    void uncrouch(){
        playerCol.height = originalHeight; 
        playerSpd.m_WalkSpeed = originalWalkSpeed;
        playerSpd.m_RunSpeed = originalRunSpeed;
    }
}
