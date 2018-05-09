﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    Rigidbody2D myRigidBody;
    [SerializeField] float moveSpeed = 1f;
	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(isFacingRight()){
            myRigidBody.velocity = new Vector2(moveSpeed, 0);
        }else{
            myRigidBody.velocity = new Vector2(-moveSpeed, 0);
        }

	}
    bool isFacingRight(){
        return transform.localScale.x > 0;
    }
	private void OnTriggerExit2D(Collider2D collision)
	{
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidBody.velocity.x)), 1f);

	}
}
