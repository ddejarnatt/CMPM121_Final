using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrazierControl : MonoBehaviour{
	[SerializeField]
	private GameObject leftBrazier;
	[SerializeField]
	private GameObject rightBrazier;
	[SerializeField]
	private GameObject leftPsys;
	[SerializeField]
	private GameObject rightPsys;
	[SerializeField]
	private CharaControl playa;
	public Material unLit;
	public Material isLit;
	private Renderer leftRend;
	private Renderer rightRend;
	private bool isDone = false;
	private bool isDone2 = false;
	
    // Start is called before the first frame update
    void Start(){
    	//grab renderers and set defaults
    	leftRend = leftBrazier.GetComponent<Renderer>();
    	rightRend = rightBrazier.GetComponent<Renderer>();
    	leftRend.material = unLit;
    	rightRend.material = unLit;
    	leftPsys.SetActive(false);
    	rightPsys.SetActive(false);
        
    }

    // Update is called once per frame
    void Update(){
    	//light right brazier if player has collectable 1
        if (playa.hasCollectable && isDone == false){
        	//make sure this call is only called once
        	isDone = true;
        	rightRend.material = isLit;
        	rightPsys.SetActive(true);
        }
        //light left brazier if player has collectable 2
        if (playa.has2ndCollectable && isDone2 == false){
        	//make sure this call is only called once
        	isDone2 = true;
        	leftRend.material = isLit;
        	leftPsys.SetActive(true);
        }
    }
}
