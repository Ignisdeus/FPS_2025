using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainCamera;
    public GameObject player;
    public GameObject shooting; 
    private void Start()
    {
        ToggleMovement();
    }

    bool canPlayGame = true; 
    void ToggleMovement(){

        canPlayGame = !canPlayGame;
        mainCamera.GetComponent<CinemachineBrain>().enabled = canPlayGame;
        player.GetComponent<ScriptMachine>().enabled = canPlayGame;
        shooting.GetComponent<ScriptMachine>().enabled = canPlayGame;



    } 
}
