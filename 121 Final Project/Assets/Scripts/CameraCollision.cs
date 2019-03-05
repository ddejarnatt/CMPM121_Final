using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour{

	//min distance from player
	[SerializeField]
	private float minDistance = 3.0f;
	//max distance from player
	[SerializeField]
	private float maxDistance = 10f;
	Vector3 dollyDir;
	[SerializeField]
	private float distance;


    void Awake(){
        dollyDir = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
    }

    // Update is called once per frame
    void Update(){
        Vector3 desiredPos = transform.parent.TransformPoint(dollyDir * maxDistance);
        RaycastHit hit;
        //if the camera collides with a wall, bring it closer to the player
        if (Physics.Linecast(transform.parent.position, desiredPos, out hit)){
            if (hit.collider.gameObject.CompareTag("Wall")){
                distance = Mathf.Clamp((hit.distance * 0.8f), minDistance, maxDistance);
            }
        	
        } else {
        	//have the camera be at standard distance
        	distance = maxDistance;
        }
        //move the camera
        transform.localPosition = Vector3.Lerp(transform.localPosition, dollyDir * distance, Time.deltaTime * 10f);
    }
}
