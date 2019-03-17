using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnText : MonoBehaviour{
	public GameObject HintText;

    // Start is called before the first frame update
    void Start(){
        HintText.SetActive(false);
    }

    void OnTriggerEnter(Collider other){
    	//if player enters the area, display the hint text
    	if (other.gameObject.CompareTag("Player")){
    		HintText.SetActive(true);
    	}
    }

    void OnTriggerExit(Collider other){
    	//if player leaves the area, hide hint text
    	if (other.gameObject.CompareTag("Player")){
    		HintText.SetActive(false);
    	}
    }
}
