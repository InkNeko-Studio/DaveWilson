using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	public Transform enemy;
	private Rigidbody2D rb;
	public float moveSpeed;
	public float savespeed;
	private Animator anim;
	public GameManager gm;

	public int enemylife = 2;
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
		
		if (other.collider.CompareTag("Bullet"))
		{
			Destroy(other.gameObject);
			enemylife--;
			if (enemylife <= 0)
			{
				Die();
				gm.MoreScore();
			}else
			Damage();
		}if (other.collider.CompareTag("Bomb"))
		{
			Destroy(other.gameObject);
			enemylife -= 2 ;
			if (enemylife <= 0)
			{
				Die();
				gm.MoreScore();
			}else
				Damage();
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		
	}

	private void Damage()
	{
		savespeed = moveSpeed;
		moveSpeed = 0;
		
		anim.SetBool("Walk",false);
		anim.SetTrigger("Damage");
		Invoke("BackToWalk",0.30f);
	}

	private void BackToWalk()
	{
		anim.SetBool("Walk",true);
		moveSpeed = savespeed;
	}

	private void Die()
	{
		moveSpeed = 0;
		anim.SetBool("Walk",false);
		anim.SetTrigger("Die");
		Destroy(gameObject,1);
	}
}
