using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectable : MonoBehaviour{

	[SerializeField]
    private SymbolControl symbol1;
    [SerializeField]
    private SymbolControl symbol2;
    [SerializeField]
    private SymbolControl symbol3;
    [SerializeField]
    private SymbolControl symbol4;
    [SerializeField]
    private SymbolControl symbol5;
    [SerializeField]
    private TorchLight correctOuter;
    [SerializeField]
    private TorchLight correctInner;
    [SerializeField]
    private GameObject Collectable;
    [SerializeField]
    private GameObject Collectable2;
    private bool hasCreated = false;
    private bool hasCreated2nd = false;

    // Update is called once per frame
    void Update(){
        //if all symbols in sideroom 2 are green, spawn collectable
        if (symbol1.isRed == false && symbol2.isRed == false && symbol3.isRed == false 
        	&& symbol4.isRed == false && symbol5.isRed == false && hasCreated == false){
            //make sure collectable can only be "created" once
        	hasCreated = true;
        	Collectable.SetActive(true);
        }
        //if the correct torches in sideroom 1 are lit, spawn 2nd collectable
        if (correctOuter.onFire == true && correctInner.onFire == true && hasCreated2nd == false){
            //make sure collectable can only be "created" once
            hasCreated2nd = true;
            Collectable2.SetActive(true);
        }
    }
}
