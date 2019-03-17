using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchControl : MonoBehaviour{
    public TorchLight thisLight;
    [SerializeField]
    private List<TorchLight> otherTorches = new List<TorchLight>();

    void OnTriggerStay(Collider other){
    	//check if player is in range of button and presses interaction key
    	if (other.gameObject.CompareTag("Player") && Input.GetKeyDown("space")){
    		if (thisLight.onFire == false){
    			thisLight.onFire = true;
    			thisLight.changeLight();
    			for (int i = 0; i < otherTorches.Count; i++){
    				otherTorches[i].turnOff();
    			}
    		} else {
    			thisLight.onFire = false;
    			thisLight.changeLight();
    		}
    	}
    }
}
