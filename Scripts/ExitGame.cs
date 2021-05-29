using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
  //quits the game
  public void doExitGame(){
    Debug.Log("Game Closed");
    Application.Quit();
  }
}
