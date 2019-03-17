using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonForSymbol : MonoBehaviour{
    
    public SymbolControl symbol1;
    public SymbolControl symbol2;
    public SymbolControl symbol3;
    public Animator button;

    void OnTriggerStay(Collider other){
    	//check if player is in range of button and presses interaction key
    	if (other.gameObject.CompareTag("Player") && Input.GetKeyDown("space")){
            //play animation
            button.Play("ButtonPress", 0, 0);
    		//go through all the symbols and flip their color
    		if (symbol1.isRed == true){
    			symbol1.isRed = false;
    			symbol1.changeColor();
    		} else {
    			symbol1.isRed = true;
    			symbol1.changeColor();
    		}
    		if (symbol2.isRed == true){
    			symbol2.isRed = false;
    			symbol2.changeColor();
    		} else {
    			symbol2.isRed = true;
    			symbol2.changeColor();
    		}
    		if (symbol3.isRed == true){
    			symbol3.isRed = false;
    			symbol3.changeColor();
    		} else {
    			symbol3.isRed = true;
    			symbol3.changeColor();
    		}
    	}
    }
}
