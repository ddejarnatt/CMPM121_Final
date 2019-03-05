using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour{

	public Animator door;
	public GameObject doorname;
 
 	void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            if (doorname.tag == "Door2"){
            	door.Play("OpenDoor2", 0, 0);
            } else {
            	door.Play("OpenDoor", 0, 0);
            }
        }
    }

    void OnTriggerExit(Collider other){
    	if (other.gameObject.CompareTag("Player")){
    		if (doorname.tag == "Door2"){
            	door.Play("CloseDoor2", 0, 0);
            } else {
            	door.Play("CloseDoor", 0, 0);
            }
    	}
    }
}
