using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectable : MonoBehaviour{

	public SymbolControl symbol1;
    public SymbolControl symbol2;
    public SymbolControl symbol3;
    public SymbolControl symbol4;
    public SymbolControl symbol5;
    public GameObject Collectable;
    private bool hasCreated = false;

    // Update is called once per frame
    void Update(){
        if (symbol1.isRed == false && symbol2.isRed == false && symbol3.isRed == false 
        	&& symbol4.isRed == false && symbol5.isRed == false && hasCreated == false){
        	hasCreated = true;
        	Collectable.SetActive(true);
        }
    }
}
