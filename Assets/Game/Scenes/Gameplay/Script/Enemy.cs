using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	public Transform enemy;
	private Rigidbody2D rb;
	public float moveSpeed;
	private Animator anim;
	public bool walking;
	void Start ()
	{
		enemy = GetComponent<Transform>();
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		anim.SetBool("Walk",true);
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 ( moveSpeed, rb.velocity.y);
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.CompareTag("A"))
		{
			moveSpeed = 1;
			enemy.transform.localScale = new Vector3(-0.8f, 0.8f, 0.8f);
		}else if (other.collider.CompareTag("B"))
		{
			moveSpeed = -1;
			enemy.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
		}

		
	}
}
