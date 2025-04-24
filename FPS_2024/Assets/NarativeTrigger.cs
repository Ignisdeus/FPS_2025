using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus; 

public class NarativeTrigger : MonoBehaviour
{
    public GameObject flowChart; 
    public string message; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player"){
            Fungus.Flowchart.BroadcastFungusMessage(message);
            Destroy(gameObject); 
        }
    }
}
