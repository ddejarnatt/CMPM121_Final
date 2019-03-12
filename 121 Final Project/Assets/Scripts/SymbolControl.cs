using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolControl : MonoBehaviour{

	public Material sRed;
	public Material sGreen;
	private Renderer rend;
	public bool isRed;
    // Start is called before the first frame update
    void Start(){
    	//grab renderer and set defaults to red
        rend = GetComponent<Renderer>();
        isRed = true;
        rend.material = sRed;
    }

    public void changeColor(){
    	//change the color of the symbol
    	if (isRed == true){
    		rend.material = sRed;
    	} else {
    		rend.material = sGreen;
    	}
    }
}
