using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDoorControl : MonoBehaviour{

	public CharaControl playa;
	public Animator animate;

    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
        	if (playa.hasCollectable && playa.has2ndCollectable){
        		animate.Play("OpenWinDoor", 0, 0);
        	}
        }
    }
}
