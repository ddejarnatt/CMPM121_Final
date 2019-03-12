using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBehavior : MonoBehaviour{
	
	public GameObject pSys;
    public CharaControl playa;

    void OnTriggerEnter(Collider other){
        pSys.SetActive(true);
        if (other.gameObject.CompareTag("Player")){
            this.gameObject.SetActive(false);
            //check which collectable has been picked up
            if (this.gameObject.CompareTag("Collectable2")){
                playa.has2ndCollectable = true;
            } else {
                playa.hasCollectable = true;
            }
        }
    }
}
