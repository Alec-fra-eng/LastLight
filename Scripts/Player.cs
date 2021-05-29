using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //defines variables like the level, health and if the player has picked up items thought out the game
    public int level = 1;
    public static int health = 2000;
    public static bool gotKCU = false;
    public static bool gotCrowbar = false;
    public static bool gotBlackBox = false;
    public static bool gotJerrycan = false;
    public static bool gotKCLab= false;

    //save the game
    public void SavePlayer(){
        SaveSystem.SavePlayer(this);
    }
}
