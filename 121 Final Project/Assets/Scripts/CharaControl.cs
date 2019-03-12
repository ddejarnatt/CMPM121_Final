using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaControl : MonoBehaviour{

	CharacterController controller;
	private float speed = 0.5f;
	private float gravity = -0.2f;
    private Vector3 movement;
    private Animator m_Animator;
    float m_ForwardAmount;
    float m_TurnAmount;
    bool m_IsGrounded = false;
    public bool canMove = true;
    public bool hasCollectable = false;
    public bool has2ndCollectable = false;
    
    // Start is called before the first frame update
    void Start(){
        controller = GetComponent<CharacterController>();
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update(){
        //move if controls are enabled
        if (canMove == true){
            //check if on the ground
            if (controller.isGrounded){
                movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            } else {
                //gravity
                movement.y += gravity;
            }
            //Q and E rotate the player
            if (Input.GetKey(KeyCode.Q)){
                transform.Rotate(new Vector3(0, -120, 0) * Time.deltaTime);
            } else if (Input.GetKey(KeyCode.E)){
                transform.Rotate(new Vector3(0, 120, 0) * Time.deltaTime);
            }
            //move and animate
            m_TurnAmount = Mathf.Atan2(movement.x, movement.z);
            m_ForwardAmount = movement.z;
            controller.Move(movement * speed * Time.deltaTime);
            UpdateAnimator(movement);
        } else {
            //do nothing if controls aren't enabled
        }
    }

    void UpdateAnimator(Vector3 move){
        //tell animator to animate
        m_Animator.SetFloat("Forward", m_ForwardAmount, 0.1f, Time.deltaTime);
        m_Animator.SetFloat("Turn", m_TurnAmount, 0.1f, Time.deltaTime);
        m_Animator.SetBool("OnGround", m_IsGrounded);
    }
}
