using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Elevator : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim; // elavator animatior 



    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Player"){
            anim.SetTrigger("Open"); 
            Destroy(gameObject); 
        }
    }
}
