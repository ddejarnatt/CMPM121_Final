using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchLight : MonoBehaviour{

	public Material unLit;
	public Material isLit;
	private Renderer rend;
	public GameObject pSys;
	public bool onFire;

    // Start is called before the first frame update
    void Start(){
        //grab renderer and set defaults to unlit
        rend = GetComponent<Renderer>();
        onFire = false;
        rend.material = unLit;
        pSys.SetActive(false);
    }

    public void changeLight(){
    	//light the torch
    	if (onFire == true){
    		rend.material = isLit;
    		pSys.SetActive(true);
    	} else {
    		rend.material = unLit;
    		pSys.SetActive(false);
    	}
    }

    public void turnOff(){
    	//turn off torch
    	onFire = false;
    	rend.material = unLit;
    	pSys.SetActive(false);
    }
}
