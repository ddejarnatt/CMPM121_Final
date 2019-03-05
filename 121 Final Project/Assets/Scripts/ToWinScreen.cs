using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToWinScreen : MonoBehaviour{
	public GameObject WinScreen;
	public CharaControl playa;

	void Start(){
		WinScreen.SetActive(false);
	}

    void OnTriggerEnter(Collider other){
    	//if player enters the win area, disable their controls and open the win screen
    	if (other.gameObject.CompareTag("Player")){
    		playa.canMove = false;
    		WinScreen.SetActive(true);
    	}
    }
}
